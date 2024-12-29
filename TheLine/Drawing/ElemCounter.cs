using System.Windows.Forms;
using TheLine.Drawing;
using TheLine.Extensions;

namespace TheLine
{
    public partial class ElemCounter : UserControl
    {
        public ElemCounter(Shape shape, ElementType elementType)
        {
            InitializeComponent();
            lbNumberElem.Parent = pbElemCount;
            pbElemCount.BackColor = elementType.GetColor();
            lbNumberElem.Text = shape.segments.GetNumberOfElement(elementType).ToString();

            shape.OnSegmentsChanged += (oldElementType, newElementType) =>
            {
                if (elementType == oldElementType)
                {
                    lbNumberElem.Text = (int.Parse(lbNumberElem.Text) - 1).ToString();
                }
                if (elementType == newElementType)
                {
                    lbNumberElem.Text = (int.Parse(lbNumberElem.Text) + 1).ToString();
                }
                return;
            };
        }
    }
}
