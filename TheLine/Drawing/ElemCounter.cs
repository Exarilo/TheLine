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
            lbNumberElem.Text = player.Elements.TryGetValue(elementType, out int value) ? value.ToString() : "0";
            player.OnElementChanged += Player_OnElementChanged;
        }


        private void Player_OnElementChanged(ElementType oldElement, ElementType newElement)
        {
            if (newElement == elementType || oldElement == elementType)
            {
                if (player.Elements.TryGetValue(elementType, out int value))
                {
                    lbNumberElem.Text = value.ToString();
                }
                else
                {
                    lbNumberElem.Text = "0";
                }
            }
        }
    }
}
