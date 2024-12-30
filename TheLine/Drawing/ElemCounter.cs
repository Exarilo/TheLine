using System;
using System.Windows.Forms;
using TheLine.Extensions;

namespace TheLine
{
    public partial class ElemCounter : UserControl
    {
        private Character player;
        private ElementType elementType;

        public ElemCounter()
        {
            InitializeComponent();
        }

        public ElemCounter(Character player, ElementType elementType)
        {
            InitializeComponent();
            this.player = player;
            this.elementType = elementType;

            lbNumberElem.Parent = pbElemCount;
            pbElemCount.BackColor = elementType.GetColor();
            lbNumberElem.Text = "0";

            player.OnElementChanged += Player_OnElementChanged;
        }

        private void Player_OnElementChanged(ElementType oldElement, ElementType newElement)
        {
            if (newElement == elementType)
            {
                lbNumberElem.Text = player.Elements[elementType].ToString();
            }
        }
    }
}
