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
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.EditedLabel = new System.Windows.Forms.Label();
            this.EditedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(10, 8);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 2;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(98, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(141, 21);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Location = new System.Drawing.Point(3, 82);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ReadOnly = true;
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(562, 409);
            this.ContentTextBox.TabIndex = 5;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(823, 24);
            this.MenuStrip.TabIndex = 11;
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            this.FileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 27);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.DeleteButton);
            this.SplitContainer.Panel1.Controls.Add(this.EditButton);
            this.SplitContainer.Panel1.Controls.Add(this.AddButton);
            this.SplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.SplitContainer.Panel1.Controls.Add(this.NotesListBox);
            this.SplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.SplitContainer.Panel1MinSize = 230;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.SplitContainer.Panel2.Controls.Add(this.ContentTextBox);
            this.SplitContainer.Panel2.Controls.Add(this.EditedLabel);
            this.SplitContainer.Panel2.Controls.Add(this.EditedTimePicker);
            this.SplitContainer.Panel2.Controls.Add(this.CreatedLabel);
            this.SplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.CreatedTimePicker);
            this.SplitContainer.Panel2MinSize = 400;
            this.SplitContainer.Size = new System.Drawing.Size(823, 503);
            this.SplitContainer.SplitterDistance = 242;
            this.SplitContainer.TabIndex = 12;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(84, 461);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(48, 461);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 13;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(12, 461);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.TabIndex = 12;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(12, 32);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(227, 420);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 33);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryLabel.TabIndex = 11;
            this.CategoryLabel.Text = "Category: ";
            // 
            // EditedLabel
            // 
            this.EditedLabel.AutoSize = true;
            this.EditedLabel.Location = new System.Drawing.Point(202, 59);
            this.EditedLabel.Name = "EditedLabel";
            this.EditedLabel.Size = new System.Drawing.Size(40, 13);
            this.EditedLabel.TabIndex = 10;
            this.EditedLabel.Text = "Edited:";
            // 
            // EditedTimePicker
            // 
            this.EditedTimePicker.Enabled = false;
            this.EditedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditedTimePicker.Location = new System.Drawing.Point(248, 56);
            this.EditedTimePicker.Name = "EditedTimePicker";
            this.EditedTimePicker.Size = new System.Drawing.Size(127, 20);
            this.EditedTimePicker.TabIndex = 8;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(3, 59);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 9;
            this.CreatedLabel.Text = "Created:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(1, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(564, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Untitled";
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreatedTimePicker.Location = new System.Drawing.Point(56, 56);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(127, 20);
            this.CreatedTimePicker.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 530);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Label EditedLabel;
        private System.Windows.Forms.DateTimePicker EditedTimePicker;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}

