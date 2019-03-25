using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Collections.Generic;
using SimplePaletteQuantizer.ColorCaches.Common;

namespace SimplePaletteQuantizer.ColorCaches
{
    public abstract class BaseColorCache : IColorCache
    {
        private readonly ConcurrentDictionary<Int32, Int32> cache;
        protected ColorModel ColorModel { get; set; }
        public abstract Boolean IsColorModelSupported { get; }

        protected BaseColorCache()
        {
            cache = new ConcurrentDictionary<Int32, Int32>();
        }

        public void ChangeColorModel(ColorModel colorModel)
        {
            ColorModel = colorModel;
        }

        protected abstract void OnCachePalette(IList<Color> palette);
        protected abstract void OnGetColorPaletteIndex(Color color, out Int32 paletteIndex);

        public virtual void Prepare()
        {
            cache.Clear();
        }

        public void CachePalette(IList<Color> palette)
        {
            OnCachePalette(palette);
        }

        public void GetColorPaletteIndex(Color color, out Int32 paletteIndex)
        {
            Int32 key = color.R << 16 | color.G << 8 | color.B;

            paletteIndex = cache.AddOrUpdate(key,
                colorKey =>
                {
                    Int32 paletteIndexInside;
                    OnGetColorPaletteIndex(color, out paletteIndexInside);
                    return paletteIndexInside;
                }, 
                (colorKey, inputIndex) => inputIndex);
        }
    }
}
