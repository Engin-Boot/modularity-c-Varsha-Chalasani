using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorLists;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the testinf and debugging
    /// </summary>
    class Test
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main()
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = PairNumber.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = PairNumber.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);

            CodeManual  codeManual = new CodeManual();
            Console.WriteLine(codeManual.ToString());

            string testString1 = codeManual.ToString(20);
            Console.WriteLine(testString1);
            Debug.Assert(testString1.Equals("Pair Number : 20   Colors : MajorColor:Yellow, MinorColor:SlateGray\n"));

            string testString2 = codeManual.ToString(2,3);
            Console.WriteLine(testString2);
            Debug.Assert(testString2.Equals("Pair Number : 2   Colors : MajorColor:White, MinorColor:Orange\nPair Number : 3   Colors : MajorColor:White, MinorColor:Green\n"));
        }
    }
}
