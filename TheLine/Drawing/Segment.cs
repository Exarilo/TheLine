using System.Drawing;
using System.Windows.Forms;
using TheLine.Elements;

namespace TheLine.Drawing
{
    public partial class Segment : UserControl
    {
        public Element CurrentElement { get; private set; }

        public Segment(ElementType elementType)
        {
            InitializeComponent();
            SetElement(elementType);
        }

        public void SetElement(ElementType elementType)
        {
            CurrentElement = ElementFactory.CreateElement(elementType);
            this.BackColor = CurrentElement.GetColor();
        }
    }
}
