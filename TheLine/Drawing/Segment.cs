using System;
using System.Windows.Forms;
using TheLine.Elements;
using TheLine.Extensions;

namespace TheLine.Drawing
{
    public partial class Segment : UserControl
    {
        public Element CurrentElement { get; private set; }

        public event Action<ElementType, ElementType> SegmentChanged;
        public Segment(ElementType elementType)
        {
            InitializeComponent();
            SetElement(elementType);
        }

        public void SetElement(ElementType elementType)
        {
            ElementType oldElementType = CurrentElement?.Type ?? ElementType.None;
            CurrentElement = ElementFactory.CreateElement(elementType);
            this.BackColor = elementType.GetColor();
            SegmentChanged?.Invoke(oldElementType, elementType);
        }
    }
}
