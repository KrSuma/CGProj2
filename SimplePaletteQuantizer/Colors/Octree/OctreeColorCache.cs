using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SimplePaletteQuantizer.ColorCaches.Common;
using SimplePaletteQuantizer.Helpers;

namespace SimplePaletteQuantizer.ColorCaches.Octree
{
    public class OctreeColorCache : BaseColorCache
    {
        private OctreeCacheNode root;

        public override Boolean IsColorModelSupported
        {
            get { return false; }
        }

        public OctreeColorCache()
        {
            ColorModel = ColorModel.RedGreenBlue;
            root = new OctreeCacheNode();
        }

        public override void Prepare()
        {
            base.Prepare();
            root = new OctreeCacheNode();
        }

        protected override void OnCachePalette(IList<Color> palette)
        {
            Int32 index = 0;

            foreach (Color color in palette)
            {
                root.AddColor(color, index++, 0);
            }
        }

        protected override void OnGetColorPaletteIndex(Color color, out Int32 paletteIndex)
        {
            Dictionary<Int32, Color> candidates = root.GetPaletteIndex(color, 0);

            paletteIndex = 0;
            Int32 index = 0;
            Int32 colorIndex = ColorModelHelper.GetEuclideanDistance(color, ColorModel, candidates.Values.ToList());

            foreach (Int32 colorPaletteIndex in candidates.Keys)
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
