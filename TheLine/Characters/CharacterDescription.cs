using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TheLine
{
    public partial class CharacterDescription : UserControl
    {
        public event EventHandler OnSelection;

        public CharacterDescription(Character character)
        {
            InitializeComponent();
            pbCharImg.BackgroundImage = character.GetImage();
            lbDescription.Text = "character.Description";

            foreach (Control control in this.Controls)
            {
                control.Click += Control_Click;
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            OnSelection?.Invoke(this, EventArgs.Empty);
        }
    }
}
