using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheLine.Extensions;

namespace TheLine.Drawing
{
    public partial class InfoBar : UserControl
    {
        public InfoBar()
        {
            InitializeComponent();
        }

        public void AddInfo(Shape shape)
        {
            foreach (ElementType elementType in Enum.GetValues(typeof(ElementType)))
            {
                ElemCounter elemCounter = new ElemCounter(shape, elementType);
                elemCounter.Dock = DockStyle.Left;
                this.Controls.Add(elemCounter);
            }
        }
    }
}




