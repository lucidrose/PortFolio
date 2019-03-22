using System.Drawing;

namespace DrawMove
{
    class CCycle : CBase
    {
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtCircle2; // 바퀴
        public Rectangle _rtSquare1; // 몸통
        public CCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(30, 150, 120, 120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);
        }
        public Pen fPeninfo()
        {
            return _pen;
        }
        /// 외부에서 호출 가능 하도록
        /// </summary>
        /// <param name="move"></param>
        public void fMove(int move)
        {
            fCircle1Move(move);
            fCircle2Move(move);
            fSquare1Move(move);
        }
        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        /// <param name="move"></param>
        protected void fCircle1Move(int move)
        {
            Point point = _rtCircle1.Location;
            point.X = point.X + move;
            _rtCircle1.Location = point;
        }
        protected void fCircle2Move(int move)
        {
            Point point = _rtCircle2.Location;
            point.X = point.X + move;
            _rtCircle2.Location = point;
        }
        protected void fSquare1Move(int move)
        {
            Point point = _rtSquare1.Location;
            point.X = point.X + move;
            _rtSquare1.Location = point;
        }
    }
}
