using System.Drawing;
namespace TheLine.Elements
{
    public class Fire : Element
    {
        public Fire() : base(ElementType.Fire, "Fire") { }

        public override Color GetColor()
        {
            return Color.Red;
        }
    }
}
