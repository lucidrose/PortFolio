using System.Drawing;

namespace DrawMove
{
    class CCar : CCycle
    {
        public Rectangle _rtSquare2; // 몸통
        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _pen = new Pen(Color.Yellow, 3);

            _rtCircle1 = new Rectangle(60, 180, 90, 90);
            _rtCircle2 = new Rectangle(210, 180, 90, 90);
            _rtSquare1 = new Rectangle(90, 30, 180, 90);
            _rtSquare2 = new Rectangle(30, 120, 300, 60);
        }

        public new void fMove(int move)
        {
            fCircle1Move(move);
            fCircle2Move(move);
            fSquare1Move(move);
            fSquare2Move(move);
        }

        protected void fSquare2Move(int move)
        {
            Point point = _rtSquare2.Location;
            point.X = point.X + move;
            _rtSquare2.Location = point;
        }
    }
}
