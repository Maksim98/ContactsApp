namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoContact = new NoteAppUI.ContactControl();
            this.MenuStrip.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(664, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContactMenuItem,
            this.EditContactMenuItem,
            this.RemoveContactMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "Edit";
            // 
            // AddContactMenuItem
            // 
            this.AddContactMenuItem.Name = "AddContactMenuItem";
            this.AddContactMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddContactMenuItem.Size = new System.Drawing.Size(203, 22);
            this.AddContactMenuItem.Text = "Add Contact";
            this.AddContactMenuItem.Click += new System.EventHandler(this.AddContact);
            // 
            // EditContactMenuItem
            // 
            this.EditContactMenuItem.Name = "EditContactMenuItem";
            this.EditContactMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditContactMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EditContactMenuItem.Text = "Edit Contact";
            this.EditContactMenuItem.Click += new System.EventHandler(this.EditContact);
            // 
            // RemoveContactMenuItem
            // 
            this.RemoveContactMenuItem.Name = "RemoveContactMenuItem";
            this.RemoveContactMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RemoveContactMenuItem.Size = new System.Drawing.Size(203, 22);
            this.RemoveContactMenuItem.Text = "Remove Contact";
            this.RemoveContactMenuItem.Click += new System.EventHandler(this.RemoveContact);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TableLayoutPanel.Controls.Add(this.ContentPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.InfoPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(664, 377);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.EditContactButton);
            this.ContentPanel.Controls.Add(this.RemoveContactButton);
            this.ContentPanel.Controls.Add(this.AddContactButton);
            this.ContentPanel.Controls.Add(this.ContactsListBox);
            this.ContentPanel.Controls.Add(this.FindTextBox);
            this.ContentPanel.Controls.Add(this.FindLabel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(3, 3);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(226, 371);
            this.ContentPanel.TabIndex = 1;
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = ((System.Drawing.Image)(resources.GetObject("EditContactButton.Image")));
            this.EditContactButton.Location = new System.Drawing.Point(39, 338);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(30, 30);
            this.EditContactButton.TabIndex = 4;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContact);
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveContactButton.Image")));
            this.RemoveContactButton.Location = new System.Drawing.Point(75, 338);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(30, 30);
            this.RemoveContactButton.TabIndex = 5;
            this.RemoveContactButton.UseVisualStyleBackColor = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContact);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Image = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Image")));
            this.AddContactButton.Location = new System.Drawing.Point(3, 338);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(30, 30);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContact);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 32);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(220, 290);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            this.ContactsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContactsListBox_MouseDoubleClick);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(45, 6);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(178, 20);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindTextBox_KeyPress);
            this.FindTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FindTextBox_KeyUp);
            // 
            // FindLabel
            // 
            this.FindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 9);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.InfoContact);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(235, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(426, 371);
            this.InfoPanel.TabIndex = 2;
            // 
            // InfoContact
            // 
            this.InfoContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoContact.CurrentContact = null;
            this.InfoContact.Location = new System.Drawing.Point(3, 3);
            this.InfoContact.MaximumSize = new System.Drawing.Size(500, 154);
            this.InfoContact.MinimumSize = new System.Drawing.Size(360, 154);
            this.InfoContact.Name = "InfoContact";
            this.InfoContact.Size = new System.Drawing.Size(414, 154);
            this.InfoContact.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(680, 440);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TableLayoutPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Button EditContactButton;
        private ContactControl InfoContact;
    }
}