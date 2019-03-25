using System;
using System.Drawing;
using System.Collections.Generic;
using SimplePaletteQuantizer.ColorCaches;
using SimplePaletteQuantizer.Helpers;

namespace SimplePaletteQuantizer.Quantizers
{
    public abstract class BaseColorCacheQuantizer : BaseColorQuantizer
    {
        private IColorCache colorCache;

        protected BaseColorCacheQuantizer()
        {
            colorCache = null;
        }

        /// Changes the cache provider.
        public void ChangeCacheProvider(IColorCache colorCache)
        {
            this.colorCache = colorCache;
        }

        /// Caches the palette.
        public void CachePalette(IList<Color> palette)
        {
            GetColorCache().CachePalette(palette);
        }

        private IColorCache GetColorCache()
        {
            // if there is no cache, it attempts to create a default cache; integrated in the quantizer
            IColorCache result = colorCache ?? (colorCache = OnCreateDefaultCache());

            // if the cache exists; or default one was created for these purposes.. use it
            if (result == null)
            {
                String message = string.Format("The color cache is not initialized! Please use SetColorCache() method on quantizer.");
                throw new ArgumentNullException(message);
            }

            // cache is fine, return it
            return result;
        }

        protected abstract IColorCache OnCreateDefaultCache();

        protected abstract List<Color> OnGetPaletteToCache(Int32 colorCount);

        protected override void OnPrepare(ImageBuffer image)
        {
            base.OnPrepare(image);

            GetColorCache().Prepare();
        }
        protected sealed override List<Color> OnGetPalette(Int32 colorCount)
        {
            // use optimization, or calculate new palette if color count is lower than unique color count
            List<Color> palette = base.OnGetPalette(colorCount) ?? OnGetPaletteToCache(colorCount);
            GetColorCache().CachePalette(palette);
            return palette;
        }

        /// See <see cref="BaseColorQuantizer.OnGetPaletteIndex"/> for more details.
        protected override void OnGetPaletteIndex(Color color, Int32 key, Int32 x, Int32 y, out int paletteIndex)
        {
            base.OnGetPaletteIndex(color, key, x, y, out paletteIndex);

            // if not determined, use cache to determine the index
            if (paletteIndex == InvalidIndex)
            {
                GetColorCache().GetColorPaletteIndex(color, out paletteIndex);
            }
        }
    }
}
