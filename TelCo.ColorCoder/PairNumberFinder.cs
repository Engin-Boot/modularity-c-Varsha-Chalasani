using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorLists;
using static TelCo.ColorCoder.ColorPair;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color to pair number.
    /// </summary>
    public class PairNumber
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = GetColorIndex(colorMapMajor,pair.majorColor);
            int minorIndex = GetColorIndex(colorMapMinor,pair.minorColor);
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

        // Find indices of colors
        static int GetColorIndex(Color[] colorList, Color color)
        {
            int colorIndex = -1;
            for (int i = 0; i < colorList.Length; i++)
            {
                if (colorList[i] == color)
                {
                    colorIndex = i;
                    break;
                }
            }
            return colorIndex;
        }    
    }   
}
