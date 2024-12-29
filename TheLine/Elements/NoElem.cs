using System.Drawing;

namespace TheLine.Elements
{
    public class NoElem : Element
    {
        public NoElem() : base(ElementType.None, "Base") { }

        public override Color GetColor()
        {
            return Color.White;
        }
    }
}
