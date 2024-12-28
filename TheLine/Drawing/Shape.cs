using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheLine.Drawing
{
    public partial class Shape : Control
    {
        public List<Segment> segments;
        private int segmentWidth;
        private int segmentHeight;
        private int segmentSpacing;
        private int lineLength;

        public Shape(int segmentWidth, int segmentHeight, int segmentSpacing, int lineLength)
        {
            this.DoubleBuffered = true;
            this.segmentWidth = segmentWidth;
            this.segmentHeight = segmentHeight;
            this.segmentSpacing = segmentSpacing;
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
                Segment segment = new Segment(Element.None);

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
