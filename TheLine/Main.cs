using System.Windows.Forms;
using TheLine.Extensions;

namespace TheLine
{
    public partial class Main : Form
    {
        private Player player { get; set; } = new Player(segmentWidth: 5, segmentHeight: 10,hp: 100);
        public Main()
        {
            InitializeComponent();
            player.AddTo(panel1);
            infoBar.AddInfo(player);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            player.segments.WhereElementTypeIs(ElementType.None).SelectNumberOfSegments(5).ReplaceByType(ElementType.Fire);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            player.segments.WhereElementTypeIs(ElementType.None).SelectNumberOfSegments(5).ReplaceByType(ElementType.Water);
        }
    }
}
