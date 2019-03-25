using System;
using System.Collections.Generic;
using System.Drawing;
using SimplePaletteQuantizer.Helpers;
using SimplePaletteQuantizer.PathProviders;

namespace SimplePaletteQuantizer.Quantizers
{
    /// This interface provides a color quantization capabilities.
    public interface IColorQuantizer : IPathProvider
    {
        Boolean AllowParallel { get; }
        void Prepare(ImageBuffer image);
        void AddColor(Color color, Int32 x, Int32 y);
        List<Color> GetPalette(Int32 colorCount);
        Int32 GetPaletteIndex(Color color, Int32 x, Int32 y);
        Int32 GetColorCount();
        void Finish();
    }
}