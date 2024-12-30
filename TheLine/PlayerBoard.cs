using System;
using System.Windows.Forms;

namespace TheLine
{
    public partial class PlayerBoard : UserControl
    {
        private const int nbRows = 3;
        private int nbColumns = 0; 

        public PlayerBoard()
        {
            InitializeComponent();
        }

        public PlayerBoard(Character character)
        {
            InitializeComponent();
            selectedCharacter.BackgroundImage = character.GetImage();
            this.Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );
            panelBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            panelBoard.RowCount = nbRows;

            panelBoard.RowStyles.Clear();
            panelBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 30)); 
            panelBoard.RowStyles.Add(new RowStyle(SizeType.Absolute,10));  
            panelBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 70)); 


            AddElementsInfo(character);
            AddProgressBarsInSecondRow();
            SetColumnStyles();
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
        public void AddElementsInfo(Character player)
        {
            foreach (ElementType elementType in Enum.GetValues(typeof(ElementType)))
            {
                ElemCounter elemCounter = new ElemCounter(player, elementType);
                elemCounter.Anchor = AnchorStyles.None;
                panelBoard.Controls.Add(elemCounter, nbColumns, 0);
                nbColumns++;
            }
        }

        private void SetColumnStyles()
        {
            panelBoard.ColumnCount = nbColumns;
            panelBoard.ColumnStyles.Clear();
            float percentPerColumn = 100f / nbColumns;
            for (int i = 0; i < nbColumns; i++)
            {
                panelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentPerColumn));
            }
        }

        private void AddProgressBarsInSecondRow()
        {
            for (int i = 0; i < nbColumns; i++)
            {
                ProgressBar progressBar = new ProgressBar
                {
                    Minimum = 0,
                    Maximum = 100,
                    Value = 50,
                };
                progressBar.Dock = DockStyle.Fill;  
                panelBoard.Controls.Add(progressBar, i, 1);
            }
        }
    }
}