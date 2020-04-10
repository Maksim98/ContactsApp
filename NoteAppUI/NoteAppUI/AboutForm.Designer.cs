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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NameAuthorLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NameProjectLabel = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            resources.ApplyResources(this.InfoPanel, "InfoPanel");
            this.InfoPanel.Controls.Add(this.GitHubLinkLabel);
            this.InfoPanel.Controls.Add(this.EmailLinkLabel);
            this.InfoPanel.Controls.Add(this.NameAuthorLabel);
            this.InfoPanel.Controls.Add(this.InfoLabel);
            this.InfoPanel.Controls.Add(this.EmailLabel);
            this.InfoPanel.Controls.Add(this.GitHubLabel);
            this.InfoPanel.Controls.Add(this.AuthorLabel);
            this.InfoPanel.Controls.Add(this.VersionLabel);
            this.InfoPanel.Controls.Add(this.NameProjectLabel);
            this.InfoPanel.Name = "InfoPanel";
            // 
            // GitHubLinkLabel
            // 
            resources.ApplyResources(this.GitHubLinkLabel, "GitHubLinkLabel");
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Click += new System.EventHandler(this.GitHubLinkLabel_Click);
            // 
            // EmailLinkLabel
            // 
            resources.ApplyResources(this.EmailLinkLabel, "EmailLinkLabel");
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Click += new System.EventHandler(this.EmailLinkLabel_Click);
            // 
            // NameAuthorLabel
            // 
            resources.ApplyResources(this.NameAuthorLabel, "NameAuthorLabel");
            this.NameAuthorLabel.Name = "NameAuthorLabel";
            // 
            // InfoLabel
            // 
            resources.ApplyResources(this.InfoLabel, "InfoLabel");
            this.InfoLabel.Name = "InfoLabel";
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.Name = "EmailLabel";
            // 
            // GitHubLabel
            // 
            resources.ApplyResources(this.GitHubLabel, "GitHubLabel");
            this.GitHubLabel.Name = "GitHubLabel";
            // 
            // AuthorLabel
            // 
            resources.ApplyResources(this.AuthorLabel, "AuthorLabel");
            this.AuthorLabel.Name = "AuthorLabel";
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.Name = "VersionLabel";
            // 
            // NameProjectLabel
            // 
            resources.ApplyResources(this.NameProjectLabel, "NameProjectLabel");
            this.NameProjectLabel.Name = "NameProjectLabel";
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.Label NameAuthorLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label NameProjectLabel;
    }
}