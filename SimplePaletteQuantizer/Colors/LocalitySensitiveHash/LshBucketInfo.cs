using System;
using System.Collections.Generic;
using System.Drawing;

namespace SimplePaletteQuantizer.ColorCaches.LocalitySensitiveHash
{
    public class BucketInfo
    {
        private readonly SortedDictionary<Int32, Color> colors;


        /// Gets the colors.
        public IDictionary<Int32, Color> Colors
        {
            get { return colors; }
        }

        /// Initializes a new instance of the BucketInfo.
        public BucketInfo()
        {
            colors = new SortedDictionary<Int32, Color>();
        }


        /// Adds the color to the bucket informations.
        public void AddColor(Int32 paletteIndex, Color color)
        {
            colors.Add(paletteIndex, color);
        }
    }
}
