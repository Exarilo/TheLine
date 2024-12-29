using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLine.Drawing;

namespace TheLine
{
    public partial class ElemCounter : UserControl
    {
        public ElemCounter(Element element)
        {
            InitializeComponent();
            lbNumberElem.Parent = pbElemCount;
            pbElemCount.BackColor= element.GetColor();
        }
    }
}
