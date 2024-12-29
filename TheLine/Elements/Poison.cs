using System.Drawing;

namespace TheLine.Elements
{

    public class Poison : Element
    {
        public Poison() : base(ElementType.Poison, "Poison") { }

        public override Color GetColor()
        {
            return Color.Green;
        }
    }
}
