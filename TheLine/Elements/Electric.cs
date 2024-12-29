using System.Drawing;

namespace TheLine.Elements
{
    public class Electric : Element
    {
        public Electric() : base(ElementType.Electric, "Electric") { }

        public override Color GetColor()
        {
            return Color.Yellow;
        }
    }
}
