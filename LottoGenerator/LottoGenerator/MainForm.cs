using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void btnLottoNumber_Click(object sender, EventArgs e)
        {
            int[] array = new int[6];
            int count = 0;


            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // Array가 다 안차면 계속 진행

            while (Array.IndexOf(array, 0) != -1) // 0인 값이 있으면 진행, 없으면 -1이니깐 while문 종료
            {
                int number = rd.Next(1, 46); // 1<= x < 46

                // 중복된 값
                if (Array.IndexOf(array, number) == -1)   // array에 number 값이 없으면
                {
                    array[count] = number;
                    //sb.Append(string.Format("{0}. ", number));
                    count++;
                }
            }

            // 숫자 정렬
            Array.Sort(array);

            foreach (var num in array)
            {
                sb.Append(string.Format("{0}. ", num));
            }


            lblLottoResult.Text = sb.ToString();
            lbxResult.Items.Add(sb.ToString());
        }

        private void btnSelectNumber_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int number = int.Parse(tbxNumber.Text);

            int checkNumber = 0;
            int count = 0;

            if (number < 1 || number > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 지정해 주세요");
                return;
            }

            do
            {
                checkNumber = rd.Next(1, 101);
                count++;

            } while (number != checkNumber);

            lblSelectNumberResult.Text = string.Format("- 뽑은 숫자 {0}을 {1}회 만에 찾았습니다.", number, count);
        }
    }
}
