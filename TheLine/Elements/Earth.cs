using System.Drawing;

namespace TheLine.Elements
{
    public class Earth : Element
    {
        public Earth() : base(ElementType.Earth, "Earth") { }

        public override Color GetColor()
        {
            return Color.Brown;
        }
    }
}
