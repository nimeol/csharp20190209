namespace p287_trackbar
{
    partial class Form1
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
            this.binStart = new System.Windows.Forms.Button();
            this.txtLoopCount = new System.Windows.Forms.TextBox();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // binStart
            // 
            this.binStart.Location = new System.Drawing.Point(306, 69);
            this.binStart.Name = "binStart";
            this.binStart.Size = new System.Drawing.Size(75, 23);
            this.binStart.TabIndex = 0;
            this.binStart.Text = "button1";
            this.binStart.UseVisualStyleBackColor = true;
            this.binStart.Click += new System.EventHandler(this.binStart_Click);
            // 
            // txtLoopCount
            // 
            this.txtLoopCount.Location = new System.Drawing.Point(167, 69);
            this.txtLoopCount.Name = "txtLoopCount";
            this.txtLoopCount.Size = new System.Drawing.Size(100, 21);
            this.txtLoopCount.TabIndex = 1;
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(88, 166);
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(462, 45);
            this.trb1.TabIndex = 2;
            this.trb1.Scroll += new System.EventHandler(this.trb1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(98, 262);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.txtLoopCount);
            this.Controls.Add(this.binStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button binStart;
        private System.Windows.Forms.TextBox txtLoopCount;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

