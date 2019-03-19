using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class MainForm : Form
    {
        struct structPlayer
        {
            public int count;
            public int sun;
            public int moon;
            public int star;

            public int cardSum;

        }
        public MainForm()
        {
            InitializeComponent();
        }

        Random _rd = new Random();
        structPlayer _stPlayer1;
        structPlayer _stPlayer2;
        CPlayer cPlayer = new CPlayer();

        /// <summary>
        /// 화면에서 "해" 그림을 클릭 했을 때 이벤트를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSun_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.sun = number;
            }
            else
            {
                _stPlayer2.sun = number;
            }
            Result();

        }

        /// <summary>
        /// 화면에서 "달" 그림을 클릭 했을 때 이벤트를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxMoon_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.moon = number;
            }
            else
            {
                _stPlayer2.moon = number;
            }
            Result();
        }

        /// <summary>
        /// 화면에서 "별" 그림을 클릭 했을 때 이벤트를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxStar_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.star = number;
            }
            else
            {
                _stPlayer2.star = number;
            }
            Result();

        }

        private void pbxNone_Click(object sender, EventArgs e)
        {
            Result();
        }
        private void CheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult1 = string.Empty;
            string strResult2 = string.Empty;
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.count++;
                _stPlayer1.cardSum = cPlayer.CardSum(_stPlayer1.sun, _stPlayer1.moon, _stPlayer1.star);
                strResult1 = cPlayer.ResutlText(_stPlayer1.count, _stPlayer1.sun, _stPlayer1.moon, _stPlayer1.star, _stPlayer1.cardSum);
                lbxResult1.Items.Add(strResult1);
            }
            else
            {
                _stPlayer2.count++;
                _stPlayer2.cardSum = cPlayer.CardSum(_stPlayer2.sun, _stPlayer2.moon, _stPlayer2.star);
                strResult2 = cPlayer.ResutlText(_stPlayer2.count, _stPlayer2.sun, _stPlayer2.moon, _stPlayer2.star, _stPlayer2.cardSum);
                lbxResult2.Items.Add(strResult2);
            }


            if (_stPlayer1.count == _stPlayer2.count)
            {
                lbxNow.Items.Add(cPlayer.PlayerPair(_stPlayer2.count, _stPlayer1.cardSum, _stPlayer2.cardSum));

                if (_stPlayer2.count >= 5)
                {
                    lbxNow.Items.Add(cPlayer.PlayerResult(_stPlayer1.cardSum, _stPlayer2.cardSum));
                }
            }

            if (_stPlayer1.count >= 5 && _stPlayer2.count >= 5)
            {
                MessageBox.Show("게임이 종료되었습니다.");
                return;
            }
            CheckedChange();
        }
    }
}
