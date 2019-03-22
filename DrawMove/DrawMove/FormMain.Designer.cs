namespace DrawMove
{
    partial class FormMain
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnOneCycle = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(481, 427);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(116, 34);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "-->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(282, 427);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(116, 34);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "<--";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(562, 398);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(194, 23);
            this.btnCar.TabIndex = 11;
            this.btnCar.Text = "3단계 : 자동차";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(352, 398);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(194, 23);
            this.btnCycle.TabIndex = 10;
            this.btnCycle.Text = "2단계 : 자전거";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnOneCycle
            // 
            this.btnOneCycle.Location = new System.Drawing.Point(142, 398);
            this.btnOneCycle.Name = "btnOneCycle";
            this.btnOneCycle.Size = new System.Drawing.Size(194, 24);
            this.btnOneCycle.TabIndex = 9;
            this.btnOneCycle.Text = "1단계 : 외발자전거";
            this.btnOneCycle.UseVisualStyleBackColor = true;
            this.btnOneCycle.Click += new System.EventHandler(this.btnOneCycle_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(11, 400);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 22);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "자동차";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pMain.Location = new System.Drawing.Point(10, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(758, 378);
            this.pMain.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 467);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnOneCycle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pMain);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnOneCycle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pMain;
    }
}

