using System.Drawing;

namespace TheLine.Extensions
{
    public static class ElementExtensions
    {
        public static Color GetColor(this ElementType element)
        {
            switch (element)
            {
                case ElementType.Fire:
                    return Color.Red;
                case ElementType.Water:
                    return Color.DeepSkyBlue;
                case ElementType.Earth:
                    return Color.Brown;
                case ElementType.Electric:
                    return Color.Yellow;
                case ElementType.Poison:
                    return Color.Green;
                default:
                    return Color.White;
            }
        }
    }
}
