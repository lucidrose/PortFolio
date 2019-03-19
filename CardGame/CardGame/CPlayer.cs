using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class CPlayer
    {
        //public int count = 0;
        //public int sun = 0;
        //public int moon = 0;
        //public int star = 0;

        public int cardSum = 0;

        public int CardSum(int sun, int moon, int star)
        {
            return sun + moon + star;
        }
        public string ResutlText(int count, int sun, int moon, int star, int cardSum)
        {
            return string.Format("{0}회) 해 : {1}, 달 : {2}, 별 : {3} => 합계 : {4} 입니다.", count, sun, moon, star, cardSum);
        }
        public string PlayerPair(int count, int p1CardSum, int p2CardSum)
        {
            int check = p1CardSum - p2CardSum;

            if (check > 0)
            {
                return string.Format("{0}회차 : Player1이 {1} 만큼 더 큽니다.", count, check);
            }
            else if (check < 0)
            {
                return string.Format("{0}회차 : Player2가 {1} 만큼 더 큽니다.", count, Math.Abs(check));
            }
            else
            {
                return string.Format("{0}회차 : 같습니다.", count);
            }
        }
        public string PlayerResult(int p1CardSum, int p2CardSum)
        {
            string strReturn = string.Empty;
            if (p1CardSum > p2CardSum)
            {
                strReturn = "Player1이 이겼습니다.";
            }
            else if (p1CardSum < p2CardSum)
            {
                strReturn = "Player2가 이겼습니다.";
            }
            else
            {
                strReturn = "비겼습니다.";
            }

            return strReturn;
        }
    }
}
