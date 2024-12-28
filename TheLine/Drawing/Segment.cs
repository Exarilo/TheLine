using System.Drawing;
using System.Windows.Forms;

namespace TheLine.Drawing
{
    public partial class Segment : UserControl
    {
        public Element CurrentElement { get; private set; }

        public Segment(Element element)
        {
            InitializeComponent();
            SetElement(element);
        }

        public void SetElement(Element element)
        {
            CurrentElement = element;
            this.BackColor = element.GetColor();
        }


    }
}
