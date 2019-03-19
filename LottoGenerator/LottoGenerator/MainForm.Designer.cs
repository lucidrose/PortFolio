namespace LottoGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectNumberResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnSelectNumber = new System.Windows.Forms.Button();
            this.btnLottoNumber = new System.Windows.Forms.Button();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLottoResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectNumberResult
            // 
            this.lblSelectNumberResult.AutoSize = true;
            this.lblSelectNumberResult.Location = new System.Drawing.Point(12, 323);
            this.lblSelectNumberResult.Name = "lblSelectNumberResult";
            this.lblSelectNumberResult.Size = new System.Drawing.Size(11, 12);
            this.lblSelectNumberResult.TabIndex = 10;
            this.lblSelectNumberResult.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 3);
            this.panel1.TabIndex = 11;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(12, 290);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(63, 21);
            this.tbxNumber.TabIndex = 6;
            this.tbxNumber.Text = "1";
            // 
            // btnSelectNumber
            // 
            this.btnSelectNumber.Location = new System.Drawing.Point(94, 290);
            this.btnSelectNumber.Name = "btnSelectNumber";
            this.btnSelectNumber.Size = new System.Drawing.Size(134, 23);
            this.btnSelectNumber.TabIndex = 8;
            this.btnSelectNumber.Text = "선택 번호 뽑기문";
            this.btnSelectNumber.UseVisualStyleBackColor = true;
            this.btnSelectNumber.Click += new System.EventHandler(this.btnSelectNumber_Click);
            // 
            // btnLottoNumber
            // 
            this.btnLottoNumber.Location = new System.Drawing.Point(285, 15);
            this.btnLottoNumber.Name = "btnLottoNumber";
            this.btnLottoNumber.Size = new System.Drawing.Size(106, 23);
            this.btnLottoNumber.TabIndex = 9;
            this.btnLottoNumber.Text = "로또 번호";
            this.btnLottoNumber.UseVisualStyleBackColor = true;
            this.btnLottoNumber.Click += new System.EventHandler(this.btnLottoNumber_Click);
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.ItemHeight = 12;
            this.lbxResult.Location = new System.Drawing.Point(12, 48);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(260, 196);
            this.lbxResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "1~100 안의 숫자를 선택 하세요";
            // 
            // lblLottoResult
            // 
            this.lblLottoResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLottoResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLottoResult.Location = new System.Drawing.Point(12, 13);
            this.lblLottoResult.Name = "lblLottoResult";
            this.lblLottoResult.Size = new System.Drawing.Size(260, 27);
            this.lblLottoResult.TabIndex = 5;
            this.lblLottoResult.Text = "0. 0. 0. 0. 0. 0.";
            this.lblLottoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(407, 349);
            this.Controls.Add(this.lblSelectNumberResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.btnSelectNumber);
            this.Controls.Add(this.btnLottoNumber);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLottoResult);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblSelectNumberResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnSelectNumber;
        private System.Windows.Forms.Button btnLottoNumber;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLottoResult;
    }
}

