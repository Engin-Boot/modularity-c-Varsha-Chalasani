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
            int majorIndex = GetMajorIndex(pair);
            int minorIndex = GetMinorIndex(pair);
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

        // Find the major color in the array and get the index
        static int GetMajorIndex(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;
        }

        // Find the minor color in the array and get the index
        static int GetMinorIndex(ColorPair pair)
        {
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }
    }   
}
