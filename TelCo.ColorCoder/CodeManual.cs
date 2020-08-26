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
        public override string ToString() //overrides the ToString() in ColorLists
        {
            string colorCodeWithColors = "";
            for(int pairNumber = 1; pairNumber <= colorMapMinor.Length*colorMapMajor.Length; pairNumber++)
            {
                ColorPair pair = ColorPair.GetColorFromPairNumber(pairNumber);
                colorCodeWithColors += "Pair Number : " + pairNumber +  "   Colors : " + pair + "\n"; 
            }
            
             return colorCodeWithColors;
        }
    }
}
