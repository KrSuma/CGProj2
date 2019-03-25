using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimplePaletteQuantizer.Ditherers
{
    class AverageDither
    {
        //calculates the average intensity of the colors in the image.
        public int averageIntensity(Image orgBitmap)
        {
            int intensity = 0;
            int totalR = 0, totalG = 0, totalB = 0;
            Bitmap temp = (Bitmap)orgBitmap.Clone();
            Color c;

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    c = temp.GetPixel(i, j);
                    totalR += c.R;
                    totalG += c.G;
                    totalB += c.B;
                }
            }

            totalR = totalR / (temp.Width * temp.Height);
            totalG = totalG / (temp.Width * temp.Height);
            totalB = totalB / (temp.Width * temp.Height);

            intensity = (totalR + totalG + totalB) / 3;

            return intensity;
        }

        //sets the average dithering based on the level of the grey selected.
        public Image averageDithering(Image orgBitmap, int level)
        {
            Bitmap tempBitmap = (Bitmap)orgBitmap;
            Bitmap bitmap = (Bitmap)tempBitmap.Clone();

            int average = averageIntensity(orgBitmap);
            byte gray;
            Color c;

            if (level == 2)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        c = bitmap.GetPixel(i, j);
                        gray = (byte)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);

                        if (gray >= average)
                        {
                            bitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
            }
            else
            {
                int[] levels = new int[level + 1];
                levels[0] = 0;

                for (int i = 1; i < level; i++)
                {
                    levels[i] = (average * i) / (level / 2);
                }

                levels[level] = 255;

                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        c = bitmap.GetPixel(i, j);
                        gray = (byte)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);

                        for (int k = 0; k < level; k++)
                        {
                            if (gray >= levels[k] && gray <= levels[k + 1])
                            {
                                bitmap.SetPixel(i, j, Color.FromArgb(levels[k + 1], levels[k + 1], levels[k + 1]));
                            }
                        }
                    }
                }
            } 
            return (Bitmap)bitmap.Clone();
        }

    }
}
