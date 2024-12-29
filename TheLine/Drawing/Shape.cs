using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TheLine.Drawing
{
    public partial class Shape : Control
    {
        public List<Segment> segments;
        private int segmentWidth;
        private int segmentHeight;
        private int lineLength;
        public event Action<ElementType, ElementType> OnSegmentsChanged;

        public Shape(int segmentWidth, int segmentHeight, int lineLength)
        {
            this.DoubleBuffered = true;
            this.segmentWidth = segmentWidth;
            this.segmentHeight = segmentHeight;
            this.lineLength = lineLength;

            segments = new List<Segment>();
            InitializeShape();
        }

        private void InitializeShape()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoSize = true;
            for (int i = 0; i < lineLength; i++)
            {
                Segment segment = new Segment(ElementType.None);
                segment.SegmentChanged += (oldElementType, newElementType) =>{OnSegmentsChanged?.Invoke(oldElementType, newElementType);};
                segment.Width = segmentWidth;
                segment.Height = segmentHeight;

                flowLayoutPanel.Controls.Add(segment);
                segments.Add(segment);
            }
            this.Controls.Add(flowLayoutPanel);
        }

        public void AddTo(Control control)
        {
            control.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }
    }
}
