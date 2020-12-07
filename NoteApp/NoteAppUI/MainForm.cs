using System;
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
    /// Класс MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CreatedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
            EditedTimePicker.CustomFormat = "HH:mm  dd.MM.yyyy";
            HideFormContent();
        }

        /// <summary>
        /// Список всех заметок
        /// </summary>
        private Project _project;

        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        private void AddNote()
        {
            var newNote = new AddAndEditForm();
            var dialogResult = newNote.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _project.Notes.Add(newNote.tempNote);
                NotesListBox.Items.Add(newNote.tempNote.Name);
                ProjectManager.SaveToFile(_project, ProjectManager.folderPath);
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (NotesListBox.SelectedIndex != -1)
            {
                var selectedIndex = NotesListBox.SelectedIndex;
                var selectedNote = _project.Notes[selectedIndex];
                var editedNote = new AddAndEditForm {tempNote = selectedNote};
                var dialogResult = editedNote.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _project.Notes.RemoveAt(selectedIndex);
                    NotesListBox.Items.RemoveAt(selectedIndex);
                    _project.Notes.Insert(selectedIndex, editedNote.tempNote);
                    NotesListBox.Items.Insert(selectedIndex, editedNote.tempNote.Name);
                    NotesListBox.SelectedIndex = selectedIndex;
                    ProjectManager.SaveToFile(_project, ProjectManager.folderPath);
                }
            }
        }

        /// <summary>
        /// Метод удаления заметок
        /// </summary>
        private void DeleteNote()
        {
            if (NotesListBox.SelectedIndex != -1)
            {
                var resultMessage = MessageBox.Show("«Do you really want to remove " + _project.Notes[NotesListBox.SelectedIndex].Name + " note?",
                    "Delete?", MessageBoxButtons.OKCancel);
                if (resultMessage == DialogResult.OK)
                {
                    _project.Notes.RemoveAt(NotesListBox.SelectedIndex);
                    NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);
                    ProjectManager.SaveToFile(_project, ProjectManager.folderPath);

                    HideFormContent();
                }
            }
        }

        /// <summary>
        /// Функция, скрывающая TimePicker и Label, меняющая значение на "заметка не выбрана"
        /// </summary>
        private void HideFormContent()
        {
            NameLabel.Text = "Note is not selected";
            ContentTextBox.Text = "";
            CreatedTimePicker.Hide();
            EditedTimePicker.Hide();
            CategoryLabel.Text = "";
            EditedLabel.Hide();
            CreatedLabel.Hide();
        }

        /// <summary>
        /// Функция, возвращающая скрытые TimePicker и Label
        /// </summary>
        private void ShowFormContent()
        {
            CreatedTimePicker.Show();
            EditedTimePicker.Show();
            EditedLabel.Show();
            CreatedLabel.Show();
        }

        /// <summary>
        /// Открывает форму About
        /// </summary>
        private void ShowAboutForm()
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadFromFile(ProjectManager.folderPath);
            foreach (var notes in _project.Notes)
            {
                NotesListBox.Items.Add(notes.Name);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.folderPath);
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex >= 0)
            {
                ShowFormContent();

                NameLabel.Text = _project.Notes[NotesListBox.SelectedIndex].Name;
                ContentTextBox.Text = _project.Notes[NotesListBox.SelectedIndex].Content;
                CreatedTimePicker.Value = _project.Notes[NotesListBox.SelectedIndex].CreationTime;
                EditedTimePicker.Value = _project.Notes[NotesListBox.SelectedIndex].EditingTime;
                CategoryLabel.Text = "Category: " + _project.Notes[NotesListBox.SelectedIndex].Category;
            }
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ShowAboutForm();
        }
    }
}
