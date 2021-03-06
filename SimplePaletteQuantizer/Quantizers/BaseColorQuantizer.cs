﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using SimplePaletteQuantizer.Helpers;
using SimplePaletteQuantizer.PathProviders;

namespace SimplePaletteQuantizer.Quantizers
{
    public abstract class BaseColorQuantizer : IColorQuantizer
    {
        protected const Int32 InvalidIndex = -1;
        private Boolean paletteFound;
        private Int64 uniqueColorIndex;
        private IPathProvider pathProvider;
        protected readonly ConcurrentDictionary<Int32, Int16> UniqueColors;

        protected BaseColorQuantizer()
        {
            pathProvider = null;
            uniqueColorIndex = -1;
            UniqueColors = new ConcurrentDictionary<Int32, Int16>();
        }

        public void ChangePathProvider(IPathProvider pathProvider)
        {
            this.pathProvider = pathProvider;
        }

        private IPathProvider GetPathProvider()
        {
            // if there is no path provider, it attempts to create a default one; integrated in the quantizer
            IPathProvider result = pathProvider ?? (pathProvider = OnCreateDefaultPathProvider());

            // if the provider exists; or default one was created for these purposes.. use it
            if (result == null)
            {
                String message = string.Format("The path provider is not initialized! Please use SetPathProvider() method on quantizer.");
                throw new ArgumentNullException(message);
            }

            // provider was obtained somehow, use it
            return result;
        }

        protected virtual void OnPrepare(ImageBuffer image)
        {
            uniqueColorIndex = -1;
            paletteFound = false;
            UniqueColors.Clear();
        }

        protected virtual void OnAddColor(Color color, Int32 key, Int32 x, Int32 y)
        {
            UniqueColors.AddOrUpdate(key,
                colorKey => (Byte) Interlocked.Increment(ref uniqueColorIndex), 
                (colorKey, colorIndex) => colorIndex);
        }

        protected virtual IPathProvider OnCreateDefaultPathProvider()
        {
            pathProvider = new StandardPathProvider();
            return new StandardPathProvider();
        }

        protected virtual List<Color> OnGetPalette(Int32 colorCount)
        {
            if (UniqueColors.Count > 0 && colorCount >= UniqueColors.Count)
            {
                // palette was found
                paletteFound = true;

                // generates the palette from unique numbers
                return UniqueColors.
                    OrderBy(pair => pair.Value).
                    Select(pair => Color.FromArgb(pair.Key)).
                    Select(color => Color.FromArgb(255, color.R, color.G, color.B)).
                    ToList();
            }
            return null;
        }

        protected virtual void OnGetPaletteIndex(Color color, Int32 key, Int32 x, Int32 y, out Int32 paletteIndex)
        {
            paletteIndex = InvalidIndex;
            Int16 foundIndex;

            if (paletteFound && UniqueColors.TryGetValue(key, out foundIndex))
            {
                paletteIndex = foundIndex;
            }
        }

        protected virtual Int32 OnGetColorCount()
        {
            return UniqueColors.Count;
        }

        protected virtual void OnFinish()
        {
        }

        public IList<Point> GetPointPath(Int32 width, Int32 heigth)
        {
            return GetPathProvider().GetPointPath(width, heigth);
        }

        public abstract Boolean AllowParallel { get; }

        public void Prepare(ImageBuffer image)
        {
            OnPrepare(image);
        }

        public void AddColor(Color color, Int32 x, Int32 y)
        {
            Int32 key;
            color = QuantizationHelper.ConvertAlpha(color, out key);
            OnAddColor(color, key, x, y);
        }

        public Int32 GetColorCount()
        {
            return OnGetColorCount();
        }

        public List<Color> GetPalette(Int32 colorCount)
        {
            return OnGetPalette(colorCount);
        }

        public Int32 GetPaletteIndex(Color color, Int32 x, Int32 y)
        {
            Int32 result, key;
            color = QuantizationHelper.ConvertAlpha(color, out key);
            OnGetPaletteIndex(color, key, x, y, out result);
            return result;
        }

        public void Finish()
        {
            OnFinish();
        }

    }
}
