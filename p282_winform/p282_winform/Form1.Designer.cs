﻿namespace p282_winform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.comFont = new System.Windows.Forms.ComboBox();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoTkd = new System.Windows.Forms.RadioButton();
            this.lblSports = new System.Windows.Forms.Label();
            this.rdoBasketball = new System.Windows.Forms.RadioButton();
            this.rdoBaseball = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comFont);
            this.groupBox1.Location = new System.Drawing.Point(69, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "폰트 설정";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(85, 85);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(308, 21);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "txtMessage";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(393, 38);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(72, 16);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "이탈릭체";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(307, 40);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // comFont
            // 
            this.comFont.FormattingEnabled = true;
            this.comFont.Location = new System.Drawing.Point(85, 36);
            this.comFont.Name = "comFont";
            this.comFont.Size = new System.Drawing.Size(124, 20);
            this.comFont.TabIndex = 0;
            this.comFont.Text = "폰트";
            this.comFont.SelectedIndexChanged += new System.EventHandler(this.comFont_SelectedIndexChanged);
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(51, 37);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(47, 16);
            this.rdoSoccer.TabIndex = 2;
            this.rdoSoccer.TabStop = true;
            this.rdoSoccer.Text = "축구";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            this.rdoSoccer.CheckedChanged += new System.EventHandler(this.rdoSoccer_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoTkd);
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.rdoBasketball);
            this.groupBox2.Controls.Add(this.rdoBaseball);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(76, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좋아하는 스포츠 하나만";
            // 
            // rdoTkd
            // 
            this.rdoTkd.AutoSize = true;
            this.rdoTkd.Location = new System.Drawing.Point(402, 37);
            this.rdoTkd.Name = "rdoTkd";
            this.rdoTkd.Size = new System.Drawing.Size(47, 16);
            this.rdoTkd.TabIndex = 6;
            this.rdoTkd.TabStop = true;
            this.rdoTkd.Text = "볼링";
            this.rdoTkd.UseVisualStyleBackColor = true;
            this.rdoTkd.CheckedChanged += new System.EventHandler(this.rdoTkd_CheckedChanged);
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(63, 79);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(149, 12);
            this.lblSports.TabIndex = 5;
            this.lblSports.Text = "선택한 스포츠가 없습니다.";
            // 
            // rdoBasketball
            // 
            this.rdoBasketball.AutoSize = true;
            this.rdoBasketball.Location = new System.Drawing.Point(323, 37);
            this.rdoBasketball.Name = "rdoBasketball";
            this.rdoBasketball.Size = new System.Drawing.Size(47, 16);
            this.rdoBasketball.TabIndex = 4;
            this.rdoBasketball.TabStop = true;
            this.rdoBasketball.Text = "보드";
            this.rdoBasketball.UseVisualStyleBackColor = true;
            this.rdoBasketball.CheckedChanged += new System.EventHandler(this.rdoBasketball_CheckedChanged);
            // 
            // rdoBaseball
            // 
            this.rdoBaseball.AutoSize = true;
            this.rdoBaseball.Location = new System.Drawing.Point(195, 37);
            this.rdoBaseball.Name = "rdoBaseball";
            this.rdoBaseball.Size = new System.Drawing.Size(47, 16);
            this.rdoBaseball.TabIndex = 3;
            this.rdoBaseball.TabStop = true;
            this.rdoBaseball.Text = "당구";
            this.rdoBaseball.UseVisualStyleBackColor = true;
            this.rdoBaseball.CheckedChanged += new System.EventHandler(this.rdoBaseball_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox comFont;
        private System.Windows.Forms.RadioButton rdoSoccer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton rdoBasketball;
        private System.Windows.Forms.RadioButton rdoBaseball;
        private System.Windows.Forms.RadioButton rdoTkd;
    }
}

