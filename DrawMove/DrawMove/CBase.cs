using System.Drawing;

namespace DrawMove
{
    class CBase
    {
        //이름, 그림을 그릴 펜에 대한 껍데기
        public string strName;

        protected Pen _pen;

        public CBase()
        {
            _pen = new Pen(Color.Aqua);
        }
    }
}
