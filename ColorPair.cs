using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorPair
    {
        internal Color majorColor { get; }
        internal Color minorColor { get; }

        public ColorPair(Color MajorColor, Color MinorColor)
        {
            majorColor = MajorColor;
            minorColor = MinorColor;
        }
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
