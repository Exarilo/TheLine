using System.Windows.Forms;

namespace TheLine
{
    public partial class IntroMenu : Form
    {
        public IntroMenu()
        {
            InitializeComponent();
            btNewRun.Click += (sender, e) =>
            {
                this.Hide();
                using (CharacterSelection game = new CharacterSelection())
                {
                    game.ShowDialog();
                }
            };
            btQuit.Click += (sender, e) =>
            {
                Application.Exit();
            };
        }
    }
}
