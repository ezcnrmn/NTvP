﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс добавления и редактирования заметки.
    /// </summary>
    public partial class AddAndEditForm : Form
    {
        public AddAndEditForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CreatedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
            EditedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
        }

        private Note _note = new Note();

        /// <summary>
        /// Временная заметка
        /// </summary>
        public Note tempNote
        {
            get
            {
                return _note;
            }
            set
            {
                _note = (Note)value.Clone();
                NameTextBox.Text = _note.Name;
                EditedTimePicker.Value = _note.EditingTime;
                CreatedTimePicker.Value = value.CreationTime;
                ContentTextBox.Text = _note.Content;
                CategoryComboBox.Text = _note.Category.ToString();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.BackColor = Color.White;
            if (NameTextBox.Text.Length > 50)
            {
                NameTextBox.Text = NameTextBox.Text.Substring(0, 50);
                NameTextBox.SelectionStart = NameTextBox.Text.Length;
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            NewNote();
        }

        /// <summary>
        /// Создание новой заметки
        /// </summary>
        private void NewNote()
        {
            try
            {
                tempNote.Name = NameTextBox.Text;
                tempNote.Content = ContentTextBox.Text;
                tempNote.Category = (NoteCategory)CategoryComboBox.SelectedItem;
                tempNote.EditingTime = DateTime.Now;
                tempNote.CreationTime = CreatedTimePicker.Value;
                DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameTextBox.BackColor = Color.White;
        }
    }
}
