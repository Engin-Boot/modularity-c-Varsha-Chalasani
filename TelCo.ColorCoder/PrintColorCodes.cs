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
        public override void ToString()
        {
            for(int pairNumber = 1; pairNumber < 26; pairNumber++)
            {
                ColorPair pair = Program.GetColorFromPairNumber(pairNumber);
                Console.WriteLine("Pair Number : {0}   Colors : {1}\n", pairNumber, pair);
            }
        }
    }
}
