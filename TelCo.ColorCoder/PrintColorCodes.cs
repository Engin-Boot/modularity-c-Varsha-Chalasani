using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    partial class Program
    {
        public override string ToString(int pairNumber)
        {
             ColorPair pair = Program.GetColorFromPairNumber(pairNumber);
             string colorCodeWithColors = "Pair Number : {pairNumber}    Colors : {pair}\n";
             return colorCodeWithColors;
        }
    }
}
