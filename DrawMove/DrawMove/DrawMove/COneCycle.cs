using System.Drawing;

namespace DrawMove
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtSquare1; // 몸통
        public COneCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }
        public Pen fPeninfo()
        {
            return _pen;
        }
        /// <summary>
        /// 외부에서 호출 가능 하도록
        /// </summary>
        /// <param name="move"></param>
        public void fMove(int move)
        {
            fCircleMove(move);
            fSquareMove(move);
        }
        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        /// <param name="move"></param>
        protected void fCircleMove(int move)
        {
            Point point = _rtCircle1.Location;
            point.X = point.X + move;
            _rtCircle1.Location = point;
        }
        protected void fSquareMove(int move)
        {
            Point point = _rtSquare1.Location;
            point.X = point.X + move;
            _rtSquare1.Location = point;
        }
    }
}
