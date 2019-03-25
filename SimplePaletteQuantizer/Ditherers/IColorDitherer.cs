using System;
using SimplePaletteQuantizer.Helpers;
using SimplePaletteQuantizer.PathProviders;
using SimplePaletteQuantizer.Quantizers;

namespace SimplePaletteQuantizer.Ditherers
{
    public interface IColorDitherer : IPathProvider
    {
        Boolean IsInplace { get; }

        void Prepare(IColorQuantizer quantizer, Int32 colorCount, ImageBuffer sourceBuffer, ImageBuffer targetBuffer);

        Boolean ProcessPixel(Pixel sourcePixel, Pixel targetPixel);

        void Finish();
    }
}
