namespace AutoJalopy
{
    partial class Report3
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
            this.dgvReport3 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateReport3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport3
            // 
            this.dgvReport3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport3.Location = new System.Drawing.Point(22, 12);
            this.dgvReport3.Name = "dgvReport3";
            this.dgvReport3.Size = new System.Drawing.Size(509, 240);
            this.dgvReport3.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(117, 272);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateReport3
            // 
            this.btnGenerateReport3.Location = new System.Drawing.Point(313, 272);
            this.btnGenerateReport3.Name = "btnGenerateReport3";
            this.btnGenerateReport3.Size = new System.Drawing.Size(75, 34);
            this.btnGenerateReport3.TabIndex = 41;
            this.btnGenerateReport3.Text = "Generate Report";
            this.btnGenerateReport3.UseVisualStyleBackColor = true;
            this.btnGenerateReport3.Click += new System.EventHandler(this.btnGenerateReport3_Click);
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 342);
            this.Controls.Add(this.btnGenerateReport3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReport3);
            this.Name = "Report3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report3";
            this.Load += new System.EventHandler(this.Report3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateReport3;
    }
}