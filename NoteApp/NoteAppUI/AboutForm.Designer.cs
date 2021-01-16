namespace NoteAppUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel1 = new System.Windows.Forms.Label();
            this.AuthorLabel2 = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppNameLabel.Location = new System.Drawing.Point(12, 11);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(92, 24);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "NoteApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(15, 39);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel1
            // 
            this.AuthorLabel1.AutoSize = true;
            this.AuthorLabel1.Location = new System.Drawing.Point(15, 75);
            this.AuthorLabel1.Name = "AuthorLabel1";
            this.AuthorLabel1.Size = new System.Drawing.Size(112, 13);
            this.AuthorLabel1.TabIndex = 2;
            this.AuthorLabel1.Text = "Author: Leonid Volkov";
            // 
            // AuthorLabel2
            // 
            this.AuthorLabel2.AutoSize = true;
            this.AuthorLabel2.Location = new System.Drawing.Point(15, 201);
            this.AuthorLabel2.Name = "AuthorLabel2";
            this.AuthorLabel2.Size = new System.Drawing.Size(114, 13);
            this.AuthorLabel2.TabIndex = 5;
            this.AuthorLabel2.Text = "2020 Leonid Volkov ©";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(21, 25);
            this.EmailLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.EmailLinkLabel.Location = new System.Drawing.Point(15, 114);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(320, 17);
            this.EmailLinkLabel.TabIndex = 8;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "e-mail for feedback: leonid.volkov99@gmail.com (click to copy)";
            this.EmailLinkLabel.UseCompatibleTextRendering = true;
            this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(8, 12);
            this.GitHubLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(15, 131);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(274, 17);
            this.GitHubLinkLabel.TabIndex = 9;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "GitHub: ezcnrmn/NTvP (click to open in your browser)";
            this.GitHubLinkLabel.UseCompatibleTextRendering = true;
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 223);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.AuthorLabel2);
            this.Controls.Add(this.AuthorLabel1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AppNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 262);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AboutForm_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel1;
        private System.Windows.Forms.Label AuthorLabel2;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
    }
}