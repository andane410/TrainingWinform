namespace ButtonTest
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
            this.btnFlat = new System.Windows.Forms.Button();
            this.btnPopup = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlat
            // 
            this.btnFlat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFlat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFlat.Location = new System.Drawing.Point(131, 87);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(216, 111);
            this.btnFlat.TabIndex = 0;
            this.btnFlat.Text = "Flat";
            this.btnFlat.UseVisualStyleBackColor = false;
            this.btnFlat.Click += new System.EventHandler(this.btnFlat_Click);
            // 
            // btnPopup
            // 
            this.btnPopup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopup.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPopup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPopup.Location = new System.Drawing.Point(417, 87);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(216, 111);
            this.btnPopup.TabIndex = 1;
            this.btnPopup.Text = "POPUP";
            this.btnPopup.UseVisualStyleBackColor = false;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStandard.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStandard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStandard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStandard.Location = new System.Drawing.Point(131, 239);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(216, 111);
            this.btnStandard.TabIndex = 2;
            this.btnStandard.Text = "STANDARD";
            this.btnStandard.UseVisualStyleBackColor = false;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSystem.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSystem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSystem.Location = new System.Drawing.Point(417, 239);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(216, 111);
            this.btnSystem.TabIndex = 3;
            this.btnSystem.Text = "SYSTEM";
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(49, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.btnFlat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Label label1;
    }
}

