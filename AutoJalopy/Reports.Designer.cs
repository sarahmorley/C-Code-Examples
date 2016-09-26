namespace AutoJalopy
{
    partial class Reports
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
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            this.cmbChooseMechanic = new System.Windows.Forms.ComboBox();
            this.lblMechanics = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateReport1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport1
            // 
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Location = new System.Drawing.Point(23, 12);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.Size = new System.Drawing.Size(549, 240);
            this.dgvReport1.TabIndex = 0;
            // 
            // cmbChooseMechanic
            // 
            this.cmbChooseMechanic.FormattingEnabled = true;
            this.cmbChooseMechanic.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbChooseMechanic.Location = new System.Drawing.Point(258, 287);
            this.cmbChooseMechanic.Name = "cmbChooseMechanic";
            this.cmbChooseMechanic.Size = new System.Drawing.Size(121, 21);
            this.cmbChooseMechanic.TabIndex = 36;
            // 
            // lblMechanics
            // 
            this.lblMechanics.AutoSize = true;
            this.lblMechanics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMechanics.Location = new System.Drawing.Point(151, 285);
            this.lblMechanics.Name = "lblMechanics";
            this.lblMechanics.Size = new System.Drawing.Size(85, 20);
            this.lblMechanics.TabIndex = 37;
            this.lblMechanics.Text = "Mechanics";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateReport1
            // 
            this.btnGenerateReport1.Location = new System.Drawing.Point(413, 279);
            this.btnGenerateReport1.Name = "btnGenerateReport1";
            this.btnGenerateReport1.Size = new System.Drawing.Size(75, 34);
            this.btnGenerateReport1.TabIndex = 39;
            this.btnGenerateReport1.Text = "Generate Report";
            this.btnGenerateReport1.UseVisualStyleBackColor = true;
            this.btnGenerateReport1.Click += new System.EventHandler(this.btnGenerateReport1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 352);
            this.Controls.Add(this.btnGenerateReport1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMechanics);
            this.Controls.Add(this.cmbChooseMechanic);
            this.Controls.Add(this.dgvReport1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport1;
        private System.Windows.Forms.ComboBox cmbChooseMechanic;
        private System.Windows.Forms.Label lblMechanics;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateReport1;
    }
}