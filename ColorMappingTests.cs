using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorMappingTests
    {
        public static void RunTestCase()
        {
            ValidateColorMapping(4, Color.White, Color.Brown);
            ValidateColorMapping(5, Color.White, Color.SlateGray);
            ValidateColorMapping(23, Color.Violet, Color.Green);
            ValidatePairNumberMapping(Color.Yellow, Color.Green, 18);
            ValidatePairNumberMapping(Color.Red, Color.Blue, 6);
        }
        private static void ValidateColorMapping(int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            ColorPair colorPair = ColorCoderUtil.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
            Debug.Assert(colorPair.majorColor == expectedMajor);
            Debug.Assert(colorPair.minorColor == expectedMinor);
        }
        private static void ValidatePairNumberMapping(Color majorColor, Color minorColor, int expectedPairNumber)
        {
            ColorPair colorPair = new ColorPair(majorColor, minorColor);
            int pairNumber = ColorCoderUtil.GetPairNumberFromColor(colorPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", colorPair, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
