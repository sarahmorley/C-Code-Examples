namespace AutoJalopy
{
    partial class Report2
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
            this.dgvReport2 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateReport2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport2
            // 
            this.dgvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport2.Location = new System.Drawing.Point(21, 12);
            this.dgvReport2.Name = "dgvReport2";
            this.dgvReport2.Size = new System.Drawing.Size(549, 240);
            this.dgvReport2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(108, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateReport2
            // 
            this.btnGenerateReport2.Location = new System.Drawing.Point(382, 275);
            this.btnGenerateReport2.Name = "btnGenerateReport2";
            this.btnGenerateReport2.Size = new System.Drawing.Size(75, 34);
            this.btnGenerateReport2.TabIndex = 40;
            this.btnGenerateReport2.Text = "Generate Report";
            this.btnGenerateReport2.UseVisualStyleBackColor = true;
            this.btnGenerateReport2.Click += new System.EventHandler(this.btnGenerateReport2_Click);
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 344);
            this.Controls.Add(this.btnGenerateReport2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReport2);
            this.Name = "Report2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateReport2;
    }
}