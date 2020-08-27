using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using static TelCo.ColorCoder.ColorLists;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    class CodeManual
    {
        //prints the manual for the given range of codes
        public string ToString(int fromCode, int toCode) 
        {
            string colorCodeWithColors = "";
            for(int pairNumber = fromCode; pairNumber <= toCode; pairNumber++)
            {
                ColorPair pair = ColorPair.GetColorFromPairNumber(pairNumber);
                colorCodeWithColors += "Pair Number : " + pairNumber +  "   Colors : " + pair + "\n"; 
            }
            
             return colorCodeWithColors;
        }

        //prints the whole list
        public string ToString() 
        {
            string colorCodeWithColors = "";
            for (int pairNumber = 1; pairNumber <= colorMapMinor.Length * colorMapMajor.Length; pairNumber++)
            {
                ColorPair pair = ColorPair.GetColorFromPairNumber(pairNumber);
                colorCodeWithColors += "Pair Number : " + pairNumber + "   Colors : " + pair + "\n";
            }

            return colorCodeWithColors;
        }

        //prints the manual for asked Pair Number
        public string ToString(int pairCode) 
        {
            string colorCodeWithColors = "";
            ColorPair pair = ColorPair.GetColorFromPairNumber(pairCode);
            colorCodeWithColors += "Pair Number : " + pairCode + "   Colors : " + pair + "\n";
            return colorCodeWithColors;
        }

    }
}
