using TheLine.Drawing;

namespace TheLine
{
    public partial class Player : Shape
    {
        private int HP;

        public Player(int segmentWidth, int segmentHeight, int segmentSpacing, int hp)
            : base(segmentWidth, segmentHeight, segmentSpacing, hp)
        {
            this.HP = hp; 
        }
    }

}
