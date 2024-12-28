using System.Drawing;

namespace TheLine
{
    public static class ElementExtensions
    {
        public static Color GetColor(this Element element)
        {
           switch(element)
            {
                case Element.Fire:
                    return Color.Red;
                case Element.Water:
                    return Color.Blue;
                case Element.Earth:
                    return Color.Brown;
                case Element.Electric:
                    return Color.Yellow;
                case Element.Poison:
                    return Color.Green;
                default:
                    return Color.White;
            }
        }
    }
}
