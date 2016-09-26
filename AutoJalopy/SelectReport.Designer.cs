namespace AutoJalopy
{
    partial class SelectReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBacktoMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReport2
            // 
            this.btnReport2.Location = new System.Drawing.Point(179, 187);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(75, 42);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.Text = "Report Two";
            this.btnReport2.UseVisualStyleBackColor = true;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Location = new System.Drawing.Point(179, 252);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(75, 42);
            this.btnReport3.TabIndex = 2;
            this.btnReport3.Text = "Report Three";
            this.btnReport3.UseVisualStyleBackColor = true;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // btnReport1
            // 
            this.btnReport1.Location = new System.Drawing.Point(179, 124);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(75, 42);
            this.btnReport1.TabIndex = 3;
            this.btnReport1.Text = "Report One";
            this.btnReport1.UseVisualStyleBackColor = true;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(112, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 76);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "   AutoJalopy Motors    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motors";
            // 
            // btnBacktoMM
            // 
            this.btnBacktoMM.Location = new System.Drawing.Point(179, 314);
            this.btnBacktoMM.Name = "btnBacktoMM";
            this.btnBacktoMM.Size = new System.Drawing.Size(75, 42);
            this.btnBacktoMM.TabIndex = 6;
            this.btnBacktoMM.Text = "Back to Main Menu";
            this.btnBacktoMM.UseVisualStyleBackColor = true;
            this.btnBacktoMM.Click += new System.EventHandler(this.btnBacktoMM_Click);
            // 
            // SelectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 378);
            this.Controls.Add(this.btnBacktoMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReport1);
            this.Controls.Add(this.btnReport3);
            this.Controls.Add(this.btnReport2);
            this.Name = "SelectReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBacktoMM;
    }
}