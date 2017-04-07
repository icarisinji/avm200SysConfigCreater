using System;

namespace createSysConf
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
            this.textModel = new System.Windows.Forms.TextBox();
            this.textPatch = new System.Windows.Forms.TextBox();
            this.textMinor = new System.Windows.Forms.TextBox();
            this.textMajor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.comboQuickView = new System.Windows.Forms.ComboBox();
            this.comboPGLD = new System.Windows.Forms.ComboBox();
            this.comboDefView = new System.Windows.Forms.ComboBox();
            this.comboCVBS = new System.Windows.Forms.ComboBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textModel
            // 
            this.textModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textModel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textModel.Location = new System.Drawing.Point(151, 56);
            this.textModel.MaxLength = 2;
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(30, 21);
            this.textModel.TabIndex = 0;
            this.textModel.Text = "0";
            this.textModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textModel.KeyPress += textModel_KeyPress;
            // 
            // textPatch
            // 
            this.textPatch.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textPatch.Location = new System.Drawing.Point(259, 56);
            this.textPatch.MaxLength = 2;
            this.textPatch.Name = "textPatch";
            this.textPatch.Size = new System.Drawing.Size(30, 21);
            this.textPatch.TabIndex = 5;
            this.textPatch.Text = "0";
            this.textPatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPatch.KeyPress += textModel_KeyPress;
            // 
            // textMinor
            // 
            this.textMinor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textMinor.Location = new System.Drawing.Point(223, 56);
            this.textMinor.MaxLength = 2;
            this.textMinor.Name = "textMinor";
            this.textMinor.Size = new System.Drawing.Size(30, 21);
            this.textMinor.TabIndex = 6;
            this.textMinor.Text = "0";
            this.textMinor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textMinor.KeyPress += textModel_KeyPress;
            // 
            // textMajor
            // 
            this.textMajor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textMajor.Location = new System.Drawing.Point(187, 56);
            this.textMajor.MaxLength = 2;
            this.textMajor.Name = "textMajor";
            this.textMajor.Size = new System.Drawing.Size(30, 21);
            this.textMajor.TabIndex = 7;
            this.textMajor.Text = "0";
            this.textMajor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textMajor.KeyPress += textModel_KeyPress;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Version";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // comboModel
            // 
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Items.AddRange(new object[] {
            "SVM-220S",
            "SVM-221C",
            "SVM-220C"});
            this.comboModel.Location = new System.Drawing.Point(151, 25);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 20);
            this.comboModel.TabIndex = 11;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "QuickView Off Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "PGLD On/Off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Default ViewMode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "CVBS Output";
            // 
            // comboLanguage
            // 
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Items.AddRange(new object[] {
            "ENGLISH",
            "CHINESE",
            "KOREAN"});
            this.comboLanguage.Location = new System.Drawing.Point(151, 86);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(121, 20);
            this.comboLanguage.TabIndex = 17;
            // 
            // comboQuickView
            // 
            this.comboQuickView.FormattingEnabled = true;
            this.comboQuickView.Items.AddRange(new object[] {
            "OFF",
            "1 Sec",
            "5 Sec",
            "10 Sec",
            "15 Sec",
            "30 Sec"});
            this.comboQuickView.Location = new System.Drawing.Point(151, 117);
            this.comboQuickView.Name = "comboQuickView";
            this.comboQuickView.Size = new System.Drawing.Size(121, 20);
            this.comboQuickView.TabIndex = 18;
            // 
            // comboPGLD
            // 
            this.comboPGLD.FormattingEnabled = true;
            this.comboPGLD.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboPGLD.Location = new System.Drawing.Point(151, 148);
            this.comboPGLD.Name = "comboPGLD";
            this.comboPGLD.Size = new System.Drawing.Size(121, 20);
            this.comboPGLD.TabIndex = 19;
            // 
            // comboDefView
            // 
            this.comboDefView.FormattingEnabled = true;
            this.comboDefView.Items.AddRange(new object[] {
            "TopView + FrontView",
            "TopView + RearView"});
            this.comboDefView.Location = new System.Drawing.Point(151, 179);
            this.comboDefView.Name = "comboDefView";
            this.comboDefView.Size = new System.Drawing.Size(224, 20);
            this.comboDefView.TabIndex = 20;
            this.comboDefView.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboCVBS
            // 
            this.comboCVBS.FormattingEnabled = true;
            this.comboCVBS.Items.AddRange(new object[] {
            "CVBS1 ON / CVBS2 ON",
            "CVBS1 ON / CVBS2 OFF",
            "CVBS1 OFF / CVBS2 ON",
            "CVBS1 OFF / CVBS2 OFF"});
            this.comboCVBS.Location = new System.Drawing.Point(151, 210);
            this.comboCVBS.Name = "comboCVBS";
            this.comboCVBS.Size = new System.Drawing.Size(224, 20);
            this.comboCVBS.TabIndex = 21;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(151, 278);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(96, 23);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Load Config";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(300, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.textModel_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 308);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboCVBS);
            this.Controls.Add(this.comboDefView);
            this.Controls.Add(this.comboPGLD);
            this.Controls.Add(this.comboQuickView);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMajor);
            this.Controls.Add(this.textMinor);
            this.Controls.Add(this.textPatch);
            this.Controls.Add(this.textModel);
            this.Name = "Form1";
            this.Text = "SVM200 System Config Creater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textPatch;
        private System.Windows.Forms.TextBox textMinor;
        private System.Windows.Forms.TextBox textMajor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.ComboBox comboQuickView;
        private System.Windows.Forms.ComboBox comboPGLD;
        private System.Windows.Forms.ComboBox comboDefView;
        private System.Windows.Forms.ComboBox comboCVBS;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
    }
}

