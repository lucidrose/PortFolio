namespace Study_while_doWhile
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
            this.lblwhileResult = new System.Windows.Forms.Label();
            this.lbxwhileResult = new System.Windows.Forms.ListBox();
            this.btnWhileResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnDoWhileResult = new System.Windows.Forms.Button();
            this.lblDoWhileResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwhileResult
            // 
            this.lblwhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblwhileResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblwhileResult.Location = new System.Drawing.Point(16, 13);
            this.lblwhileResult.Name = "lblwhileResult";
            this.lblwhileResult.Size = new System.Drawing.Size(260, 27);
            this.lblwhileResult.TabIndex = 0;
            this.lblwhileResult.Text = "0. 0. 0. 0. 0. 0.";
            this.lblwhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxwhileResult
            // 
            this.lbxwhileResult.FormattingEnabled = true;
            this.lbxwhileResult.ItemHeight = 12;
            this.lbxwhileResult.Location = new System.Drawing.Point(16, 48);
            this.lbxwhileResult.Name = "lbxwhileResult";
            this.lbxwhileResult.Size = new System.Drawing.Size(260, 196);
            this.lbxwhileResult.TabIndex = 1;
            // 
            // btnWhileResult
            // 
            this.btnWhileResult.Location = new System.Drawing.Point(289, 15);
            this.btnWhileResult.Name = "btnWhileResult";
            this.btnWhileResult.Size = new System.Drawing.Size(106, 23);
            this.btnWhileResult.TabIndex = 2;
            this.btnWhileResult.Text = "로또 번호";
            this.btnWhileResult.UseVisualStyleBackColor = true;
            this.btnWhileResult.Click += new System.EventHandler(this.btnWhileResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(16, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 3);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1~100 안의 숫자를 선택 하세요";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(16, 290);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(63, 21);
            this.tbxNumber.TabIndex = 1;
            this.tbxNumber.Text = "1";
            // 
            // btnDoWhileResult
            // 
            this.btnDoWhileResult.Location = new System.Drawing.Point(98, 290);
            this.btnDoWhileResult.Name = "btnDoWhileResult";
            this.btnDoWhileResult.Size = new System.Drawing.Size(134, 23);
            this.btnDoWhileResult.TabIndex = 2;
            this.btnDoWhileResult.Text = "선택 번호 뽑기문";
            this.btnDoWhileResult.UseVisualStyleBackColor = true;
            this.btnDoWhileResult.Click += new System.EventHandler(this.btnDoWhileResult_Click);
            // 
            // lblDoWhileResult
            // 
            this.lblDoWhileResult.AutoSize = true;
            this.lblDoWhileResult.Location = new System.Drawing.Point(16, 323);
            this.lblDoWhileResult.Name = "lblDoWhileResult";
            this.lblDoWhileResult.Size = new System.Drawing.Size(11, 12);
            this.lblDoWhileResult.TabIndex = 3;
            this.lblDoWhileResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 347);
            this.Controls.Add(this.lblDoWhileResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.btnDoWhileResult);
            this.Controls.Add(this.btnWhileResult);
            this.Controls.Add(this.lbxwhileResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblwhileResult);
            this.Name = "Form1";
            this.Text = "로또번호생성기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwhileResult;
        private System.Windows.Forms.ListBox lbxwhileResult;
        private System.Windows.Forms.Button btnWhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDoWhileResult;
        private System.Windows.Forms.Button btnDoWhileResult;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label1;
    }
}

