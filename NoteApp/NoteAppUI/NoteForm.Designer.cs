namespace NoteAppUI
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.EditedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.EditedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditedLabel
            // 
            this.EditedLabel.AutoSize = true;
            this.EditedLabel.Location = new System.Drawing.Point(211, 62);
            this.EditedLabel.Name = "EditedLabel";
            this.EditedLabel.Size = new System.Drawing.Size(40, 13);
            this.EditedLabel.TabIndex = 21;
            this.EditedLabel.Text = "Edited:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(11, 62);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 20;
            this.CreatedLabel.Text = "Created:";
            // 
            // EditedTimePicker
            // 
            this.EditedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
            this.EditedTimePicker.Enabled = false;
            this.EditedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditedTimePicker.Location = new System.Drawing.Point(260, 59);
            this.EditedTimePicker.Name = "EditedTimePicker";
            this.EditedTimePicker.Size = new System.Drawing.Size(127, 20);
            this.EditedTimePicker.TabIndex = 19;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.Location = new System.Drawing.Point(444, 429);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(70, 25);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Location = new System.Drawing.Point(12, 85);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(578, 338);
            this.ContentTextBox.TabIndex = 16;
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreatedTimePicker.Location = new System.Drawing.Point(67, 59);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(127, 20);
            this.CreatedTimePicker.TabIndex = 15;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(67, 32);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(127, 21);
            this.CategoryComboBox.TabIndex = 14;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(11, 35);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 13;
            this.CategoryLabel.Text = "Category:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(67, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(523, 20);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name:";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton1.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton1.Location = new System.Drawing.Point(520, 429);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(70, 25);
            this.CancelButton1.TabIndex = 22;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = false;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 466);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.EditedLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.EditedTimePicker);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.CreatedTimePicker);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.DateTimePicker EditedTimePicker;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button CancelButton1;
    }
}