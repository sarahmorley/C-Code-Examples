namespace AutoJalopy
{
    partial class MyJobs
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
            this.dgvMyJobs = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnBacktoMM = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewJobs = new System.Windows.Forms.Button();
            this.lblMyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyJobs
            // 
            this.dgvMyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyJobs.Location = new System.Drawing.Point(26, 168);
            this.dgvMyJobs.Name = "dgvMyJobs";
            this.dgvMyJobs.Size = new System.Drawing.Size(439, 150);
            this.dgvMyJobs.TabIndex = 0;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(365, 337);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(100, 42);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Job Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnBacktoMM
            // 
            this.btnBacktoMM.Location = new System.Drawing.Point(24, 337);
            this.btnBacktoMM.Name = "btnBacktoMM";
            this.btnBacktoMM.Size = new System.Drawing.Size(87, 44);
            this.btnBacktoMM.TabIndex = 2;
            this.btnBacktoMM.Text = "Back to Main Menu";
            this.btnBacktoMM.UseVisualStyleBackColor = true;
            this.btnBacktoMM.Click += new System.EventHandler(this.btnBacktoMM_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(125, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 76);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "   AutoJalopy Motors    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motors";
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.Location = new System.Drawing.Point(255, 337);
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(100, 42);
            this.btnViewJobs.TabIndex = 5;
            this.btnViewJobs.Text = "View all my Jobs";
            this.btnViewJobs.UseVisualStyleBackColor = true;
            this.btnViewJobs.Click += new System.EventHandler(this.btnViewJobs_Click);
            // 
            // lblMyName
            // 
            this.lblMyName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyName.Location = new System.Drawing.Point(145, 105);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(172, 49);
            this.lblMyName.TabIndex = 6;
            // 
            // MyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 393);
            this.Controls.Add(this.lblMyName);
            this.Controls.Add(this.btnViewJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBacktoMM);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dgvMyJobs);
            this.Name = "MyJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyJobs";
            this.Load += new System.EventHandler(this.MyJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyJobs;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnBacktoMM;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewJobs;
        private System.Windows.Forms.Label lblMyName;
    }
}