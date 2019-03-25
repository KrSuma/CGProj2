using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using SimplePaletteQuantizer.Helpers;
using SimplePaletteQuantizer.ColorCaches.Common;

namespace SimplePaletteQuantizer.ColorCaches.LocalitySensitiveHash
{
    public class LshColorCache : BaseColorCache
    {
        private const Byte DefaultQuality = 16; // 16
        private const Int64 MaximalDistance = 4096;

        private const Single NormalizedDistanceRGB = 1.0f / 196608.0f; // 256*256*3 (RGB) = 196608 / 768.0f
        private const Single NormalizedDistanceHSL = 1.0f / 260672.0f; // 360*360 (H) + 256*256*2 (SL) = 260672 / 872.0f
        private const Single NormalizedDistanceLab = 1.0f / 507.0f; // 13*13*3 = 507 / 300.0f

        private Byte quality;
        private Int64 bucketSize;
        private Int64 minBucketIndex;
        private Int64 maxBucketIndex;
        private BucketInfo[] buckets;

        /// Gets or sets the quality.
        public Byte Quality
        {
            get { return quality; }
            set
            {
                quality = value;

                bucketSize = MaximalDistance / quality;
                minBucketIndex = quality;
                maxBucketIndex = 0;

                buckets = new BucketInfo[quality];
            }
        }

        /// Gets a value indicating whether this instance is color model supported.
        public override Boolean IsColorModelSupported
        {
            get { return true; }
        }

        public LshColorCache()
        {
            ColorModel = ColorModel.RedGreenBlue;
            Quality = DefaultQuality;
        }

        public LshColorCache(ColorModel colorModel, Byte quality)
        {
            ColorModel = colorModel;
            Quality = quality;
        }

 
        private Int64 GetColorBucketIndex(Color color)
        {
            Single normalizedDistance = 0.0f;
            Single componentA, componentB, componentC;

            switch (ColorModel)
            {
                case ColorModel.RedGreenBlue: normalizedDistance = NormalizedDistanceRGB; break;
                case ColorModel.HueSaturationLuminance: normalizedDistance = NormalizedDistanceHSL; break;
                case ColorModel.LabColorSpace: normalizedDistance = NormalizedDistanceLab; break;
            }

            ColorModelHelper.GetColorComponents(ColorModel, color, out componentA, out componentB, out componentC);
            Single distance = componentA*componentA + componentB*componentB + componentC*componentC;
            Single normalized = distance * normalizedDistance * MaximalDistance;
            Int64 resultHash = (Int64) normalized / bucketSize;

            return resultHash;
        }

        private BucketInfo GetBucket(Color color)
        {
            Int64 bucketIndex = GetColorBucketIndex(color);

            if (bucketIndex < minBucketIndex)
            {
                bucketIndex = minBucketIndex;
            }
            else if (bucketIndex > maxBucketIndex)
            {
                bucketIndex = maxBucketIndex;
            }
            else if (buckets[bucketIndex] == null)
            {
                Boolean bottomFound = false;
                Boolean topFound = false;
                Int64 bottomBucketIndex = bucketIndex;
                Int64 topBucketIndex = bucketIndex;

                while (!bottomFound && !topFound)
                {
                    bottomBucketIndex--;
                    topBucketIndex++;
                    bottomFound = bottomBucketIndex > 0 && buckets[bottomBucketIndex] != null;
                    topFound = topBucketIndex < quality && buckets[topBucketIndex] != null;
                }

                bucketIndex = bottomFound ? bottomBucketIndex : topBucketIndex;
            }

            return buckets[bucketIndex];
        }

        public override void Prepare()
        {
            base.Prepare();
            buckets = new BucketInfo[quality];
        }

        protected override void OnCachePalette(IList<Color> palette)
        {
            Int32 paletteIndex = 0;
            minBucketIndex = quality;
            maxBucketIndex = 0;

            foreach (Color color in palette)
            {
                Int64 bucketIndex = GetColorBucketIndex(color);
                BucketInfo bucket = buckets[bucketIndex] ?? new BucketInfo();
                bucket.AddColor(paletteIndex++, color);
                buckets[bucketIndex] = bucket;

                if (bucketIndex < minBucketIndex) minBucketIndex = bucketIndex;
                if (bucketIndex > maxBucketIndex) maxBucketIndex = bucketIndex;
            }
        }

        protected override void OnGetColorPaletteIndex(Color color, out Int32 paletteIndex)
        {
            BucketInfo bucket = GetBucket(color);
            Int32 colorCount = bucket.Colors.Count();
            paletteIndex = 0;

            if (colorCount == 1)
            {
                paletteIndex = bucket.Colors.First().Key;
            }
            else
            {
                Int32 index = 0;
                Int32 colorIndex = ColorModelHelper.GetEuclideanDistance(color, ColorModel, bucket.Colors.Values.ToList());

                foreach (Int32 colorPaletteIndex in bucket.Colors.Keys)
                {
                    if (index == colorIndex)
                    {
                        paletteIndex = colorPaletteIndex;
                        break;
                    }

                    index++;
                }
            }
        }
    }
}
