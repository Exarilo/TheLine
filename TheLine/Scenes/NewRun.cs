using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TheLine.Characters;

namespace TheLine
{
    public partial class NewRun : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private Character selectedCharacter;
        private const int WM_SETREDRAW = 0x000B;

        public NewRun(Character selectedCharacter)
        {
            InitializeComponent();
            this.selectedCharacter = selectedCharacter;
            this.DoubleBuffered = true;
            panel2.Controls.Add(new PlayerBoard(selectedCharacter));
            this.ResizeBegin += NewRun_ResizeBegin;
            this.ResizeEnd += NewRun_ResizeEnd;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    
                return cp;
            }
        }

        private void NewRun_ResizeBegin(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, 0, 0);
        }

        private void NewRun_ResizeEnd(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, 1, 0);
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedCharacter.ChangeElement(ElementType.Water, ElementType.Fire, 5);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            selectedCharacter.ChangeElement(ElementType.Fire, ElementType.Water, 5);
        }
    }
}
