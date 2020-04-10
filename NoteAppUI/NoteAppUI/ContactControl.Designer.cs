namespace NoteAppUI
{
    partial class ContactControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactControl));
            this.SurameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SurameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SurameLabel
            // 
            this.SurameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurameLabel.AutoSize = true;
            this.SurameLabel.Location = new System.Drawing.Point(3, 6);
            this.SurameLabel.Name = "SurameLabel";
            this.SurameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurameLabel.TabIndex = 0;
            this.SurameLabel.Text = "Surame:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(7, 55);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(48, 13);
            this.BirthdayLabel.TabIndex = 0;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(14, 84);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 110);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-mail:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(10, 134);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(45, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "vk.com:";
            // 
            // SurameTextBox
            // 
            this.SurameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SurameTextBox.Location = new System.Drawing.Point(61, 3);
            this.SurameTextBox.MaxLength = 50;
            this.SurameTextBox.MinimumSize = new System.Drawing.Size(296, 20);
            this.SurameTextBox.Name = "SurameTextBox";
            this.SurameTextBox.Size = new System.Drawing.Size(296, 20);
            this.SurameTextBox.TabIndex = 1;
            this.SurameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurameTextBox_KeyPress);
            this.SurameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameTextBox.Location = new System.Drawing.Point(61, 29);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.MinimumSize = new System.Drawing.Size(296, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(296, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            this.NameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EmailTextBox.Location = new System.Drawing.Point(61, 107);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(296, 20);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(296, 20);
            this.EmailTextBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.EmailTextBox, resources.GetString("EmailTextBox.ToolTip"));
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IdTextBox.Location = new System.Drawing.Point(61, 131);
            this.IdTextBox.MaxLength = 15;
            this.IdTextBox.MinimumSize = new System.Drawing.Size(296, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(296, 20);
            this.IdTextBox.TabIndex = 6;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            this.IdTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BirthdayDateTime
            // 
            this.BirthdayDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTime.Location = new System.Drawing.Point(61, 55);
            this.BirthdayDateTime.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.BirthdayDateTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDateTime.MinimumSize = new System.Drawing.Size(96, 20);
            this.BirthdayDateTime.Name = "BirthdayDateTime";
            this.BirthdayDateTime.Size = new System.Drawing.Size(96, 20);
            this.BirthdayDateTime.TabIndex = 3;
            this.BirthdayDateTime.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(61, 81);
            this.PhoneMaskedTextBox.Mask = "+7 (000) 000-0000";
            this.PhoneMaskedTextBox.MinimumSize = new System.Drawing.Size(296, 20);
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(296, 20);
            this.PhoneMaskedTextBox.TabIndex = 4;
            this.ToolTip.SetToolTip(this.PhoneMaskedTextBox, "Phone format: +7 (900) 000 - 0000");
            this.PhoneMaskedTextBox.Leave += new System.EventHandler(this.PhoneMaskedTextBox_Leave);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 5;
            this.ToolTip.ReshowDelay = 10;
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BirthdayDateTime);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.SurameTextBox);
            this.Controls.Add(this.SurameLabel);
            this.MaximumSize = new System.Drawing.Size(500, 154);
            this.MinimumSize = new System.Drawing.Size(360, 154);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(360, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker BirthdayDateTime;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurameLabel;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
