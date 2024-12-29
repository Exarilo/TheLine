using System.Windows.Forms;
using TheLine.Extensions;

namespace TheLine
{
    public partial class Main : Form
    {
        private Player player { get; set; } = new Player(segmentWidth: 5, segmentHeight: 10, segmentSpacing: 1, hp: 100);
        public Main()
        {
            InitializeComponent();
            player.AddTo(panel1);
            player.segments.WhereElementTypeIs(ElementType.None).SelectNumberOfSegments(5).ReplaceByType(ElementType.Fire);
    


        }
    }
}
