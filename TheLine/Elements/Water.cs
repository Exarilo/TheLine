using System.Drawing;
namespace TheLine.Elements
{
    public class Water : Element
    {
        public Water() : base(ElementType.Water, "Water") { }

        public override Color GetColor()
        {
            return Color.Blue;
        }
    }
}
