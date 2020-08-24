using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    partial class Program
    {
        public override string ToString()
        {
            StringBuilder colorCodeWithColors = new StringBuilder("");
            for(int pairNumber = 1; pairNumber < 26; pairNumber++)
            {
                ColorPair pair = Program.GetColorFromPairNumber(pairNumber);
                colorCodeWithColors.Append("Pair Number : {pairNumber}    Colors : {pair}\n"); 
            }
            
             return colorCodeWithColors;
        }
    }
}
