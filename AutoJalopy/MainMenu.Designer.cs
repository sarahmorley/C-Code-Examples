namespace AutoJalopy
{
    partial class MainMenu
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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnMyJobs = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(182, 117);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 42);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(182, 180);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(75, 42);
            this.btnAdministration.TabIndex = 1;
            this.btnAdministration.Text = "View Bookings";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnMyJobs
            // 
            this.btnMyJobs.Location = new System.Drawing.Point(182, 241);
            this.btnMyJobs.Name = "btnMyJobs";
            this.btnMyJobs.Size = new System.Drawing.Size(75, 39);
            this.btnMyJobs.TabIndex = 2;
            this.btnMyJobs.Text = "View Your Workload";
            this.btnMyJobs.UseVisualStyleBackColor = true;
            this.btnMyJobs.Click += new System.EventHandler(this.btnMyJobs_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(113, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 76);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "   AutoJalopy Motors    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motors";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(182, 306);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(75, 39);
            this.btnCloseApp.TabIndex = 5;
            this.btnCloseApp.Text = "Logout";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 387);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMyJobs);
            this.Controls.Add(this.btnAdministration);
            this.Controls.Add(this.btnReports);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Button btnMyJobs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseApp;
    }
}