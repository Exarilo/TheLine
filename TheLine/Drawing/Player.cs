using TheLine.Drawing;

namespace TheLine
{
    public partial class Player : Shape
    {
        private int HP;

        public Player(int segmentWidth, int segmentHeight, int hp)
            : base(segmentWidth, segmentHeight, hp)
        {
            this.HP = hp; 
        }
    }

}
