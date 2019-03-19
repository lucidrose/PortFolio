namespace CardGame
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
            this.lbxNow = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxResult2 = new System.Windows.Forms.ListBox();
            this.lbxResult1 = new System.Windows.Forms.ListBox();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.pbxNone = new System.Windows.Forms.PictureBox();
            this.pbxStar = new System.Windows.Forms.PictureBox();
            this.pbxMoon = new System.Windows.Forms.PictureBox();
            this.pbxSun = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSun)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxNow
            // 
            this.lbxNow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbxNow.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbxNow.FormattingEnabled = true;
            this.lbxNow.ItemHeight = 12;
            this.lbxNow.Location = new System.Drawing.Point(13, 464);
            this.lbxNow.Name = "lbxNow";
            this.lbxNow.Size = new System.Drawing.Size(714, 172);
            this.lbxNow.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "- 상황판";
            // 
            // lbxResult2
            // 
            this.lbxResult2.FormattingEnabled = true;
            this.lbxResult2.ItemHeight = 12;
            this.lbxResult2.Location = new System.Drawing.Point(375, 237);
            this.lbxResult2.Name = "lbxResult2";
            this.lbxResult2.Size = new System.Drawing.Size(352, 184);
            this.lbxResult2.TabIndex = 34;
            // 
            // lbxResult1
            // 
            this.lbxResult1.FormattingEnabled = true;
            this.lbxResult1.ItemHeight = 12;
            this.lbxResult1.Location = new System.Drawing.Point(13, 237);
            this.lbxResult1.Name = "lbxResult1";
            this.lbxResult1.Size = new System.Drawing.Size(352, 184);
            this.lbxResult1.TabIndex = 33;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(375, 208);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(65, 16);
            this.rdoPlayer2.TabIndex = 32;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(13, 208);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(65, 16);
            this.rdoPlayer1.TabIndex = 31;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // pbxNone
            // 
            this.pbxNone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxNone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNone.Location = new System.Drawing.Point(407, 63);
            this.pbxNone.Name = "pbxNone";
            this.pbxNone.Size = new System.Drawing.Size(128, 128);
            this.pbxNone.TabIndex = 30;
            this.pbxNone.TabStop = false;
            this.pbxNone.Click += new System.EventHandler(this.pbxNone_Click);
            // 
            // pbxStar
            // 
            this.pbxStar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxStar.Image = global::CardGame.Properties.Resources.star;
            this.pbxStar.Location = new System.Drawing.Point(275, 63);
            this.pbxStar.Name = "pbxStar";
            this.pbxStar.Size = new System.Drawing.Size(128, 128);
            this.pbxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStar.TabIndex = 29;
            this.pbxStar.TabStop = false;
            this.pbxStar.Click += new System.EventHandler(this.pbxStar_Click);
            // 
            // pbxMoon
            // 
            this.pbxMoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMoon.Image = global::CardGame.Properties.Resources.moon;
            this.pbxMoon.Location = new System.Drawing.Point(144, 63);
            this.pbxMoon.Name = "pbxMoon";
            this.pbxMoon.Size = new System.Drawing.Size(128, 128);
            this.pbxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMoon.TabIndex = 28;
            this.pbxMoon.TabStop = false;
            this.pbxMoon.Click += new System.EventHandler(this.pbxMoon_Click);
            // 
            // pbxSun
            // 
            this.pbxSun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSun.Image = global::CardGame.Properties.Resources.sun;
            this.pbxSun.Location = new System.Drawing.Point(13, 63);
            this.pbxSun.Name = "pbxSun";
            this.pbxSun.Size = new System.Drawing.Size(128, 128);
            this.pbxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSun.TabIndex = 27;
            this.pbxSun.TabStop = false;
            this.pbxSun.Click += new System.EventHandler(this.pbxSun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "- 각 10회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리입니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "- Player는 한번 씩 돌아가면서 그림을 선택 합니다.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 646);
            this.Controls.Add(this.lbxNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxResult2);
            this.Controls.Add(this.lbxResult1);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pbxNone);
            this.Controls.Add(this.pbxStar);
            this.Controls.Add(this.pbxMoon);
            this.Controls.Add(this.pbxSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "CardGame";
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxResult2;
        private System.Windows.Forms.ListBox lbxResult1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.PictureBox pbxNone;
        private System.Windows.Forms.PictureBox pbxStar;
        private System.Windows.Forms.PictureBox pbxMoon;
        private System.Windows.Forms.PictureBox pbxSun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

