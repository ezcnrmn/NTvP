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
            
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(NoteApp.NoteCategory)));
            _notesList = _project.Notes;
            _notesList = _project.SortingNotes(_notesList);
        }

        /// <summary>
        /// Список всех заметок
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список отображаемых в NoteListBox заметок
        /// </summary>
        private List<Note> _notesList = new List<Note>();

        /// <summary>
        /// Метод обновления списка заметок
        /// </summary>
        private void ListBoxUpdater()
        {
            if (CategoryComboBox.SelectedIndex > 0)
            {
                _notesList = _project.SortingNotes(_project.Notes, (NoteCategory)CategoryComboBox.SelectedIndex-1);
            }
            else
            {
                _notesList = _project.SortingNotes(_project.Notes);
            }

            NotesListBox.Items.Clear();

            foreach (var note in _notesList)
            {
                NotesListBox.Items.Add(note.Name);
            }
        }

        /// <summary>
        /// Метод присваивания CurrentIndex в Project
        /// При отсутствии аргументов присваивается индекс текущей выбранной заметки
        /// </summary>
        private void AssignCurrentIndex()
        {
            _project.CurrentIndex = NotesListBox.SelectedIndex;
        }

        /// <summary>
        /// Метод присваивания CurrentIndex в Project
        /// При передаче аргумента в метод пристваивается именно он
        /// </summary>
        private void AssignCurrentIndex(int index)
        {
            _project.CurrentIndex = index;
        }

        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        private void AddNote()
        {
            ShowFormContent();
            var newNote = new NoteForm();
            var dialogResult = newNote.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _project.Notes.Add(newNote.Note);
                _notesList.Add(newNote.Note);
                NotesListBox.Items.Add(newNote.Note.Name);

                if (CategoryComboBox.SelectedIndex > 0)
                {
                    int categoryIndex = newNote.Note.Category.GetHashCode() + 1;
                    CategoryComboBox.SelectedIndex = categoryIndex;
                }

                ListBoxUpdater();
                NotesListBox.SelectedIndex = 0;
                ProjectManager.SaveToFile(_project, ProjectManager.filePath, ProjectManager.folderPath);
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (NotesListBox.SelectedIndex != -1)
            {
                int selectedIndex = NotesListBox.SelectedIndex;
                var selectedNote = _notesList[selectedIndex];
                var editedNote = new NoteForm { Note = selectedNote };
                var dialogResult = editedNote.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    int projectSelectedIndex = _project.Notes.IndexOf(selectedNote);
                    _project.Notes.RemoveAt(projectSelectedIndex);
                    _project.Notes.Insert(projectSelectedIndex, editedNote.Note);

                    if (CategoryComboBox.SelectedIndex > 0)
                    {
                        int categoryIndex = editedNote.Note.Category.GetHashCode() + 1;
                        CategoryComboBox.SelectedIndex = categoryIndex;
                    }

                    ListBoxUpdater();
                    NotesListBox.SelectedIndex = 0;
                    ProjectManager.SaveToFile(_project, ProjectManager.filePath, ProjectManager.folderPath);
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
                var resultMessage = MessageBox.Show("Do you really want to delete «" + _notesList[NotesListBox.SelectedIndex].Name + "» note?",
                    "Delete?", MessageBoxButtons.OKCancel);
                if (resultMessage == DialogResult.OK)
                {
                    var selectedNote = _notesList[NotesListBox.SelectedIndex];
                    int projectSelectedIndex = _project.Notes.IndexOf(selectedNote);
                    _project.Notes.RemoveAt(projectSelectedIndex);

                    ListBoxUpdater();

                    if (NotesListBox.Items.Count > 0)
                    {
                        NotesListBox.SelectedIndex = 0;
                    }
                    else
                    {
                        CategoryComboBox.SelectedIndex = 0;
                        if (NotesListBox.Items.Count > 0)
                        {
                            NotesListBox.SelectedIndex = 0;
                        }
                        else
                        {
                            HideFormContent();
                        }
                    }

                    ProjectManager.SaveToFile(_project, ProjectManager.filePath, ProjectManager.folderPath);
                }
            }
        }

        /// <summary>
        /// Функция, скрывающая TimePicker и Label, меняющая значение на "заметка не выбрана"
        /// </summary>
        private void HideFormContent()
        {
            NameLabel.Text = "There are no notes :(";
            ContentTextBox.Text = "";
            CreatedTimePicker.Hide();
            EditedTimePicker.Hide();
            CategoryLabel.Text = "let's create one";
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
            _project = ProjectManager.LoadFromFile(ProjectManager.filePath);

            CategoryComboBox.SelectedIndex = 0;
            ListBoxUpdater();
            
            if (_project.Notes.Count == 0)
            {
                HideFormContent();
            }
            else
            {
                NotesListBox.SelectedIndex = _project.CurrentIndex;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CategoryComboBox.SelectedIndex > 0 && NotesListBox.SelectedIndex >= 0)
            {
                var selectedNote = _notesList[NotesListBox.SelectedIndex];
                _notesList = _project.SortingNotes(_project.Notes);
                int projectSelectedIndex = _notesList.IndexOf(selectedNote);
                AssignCurrentIndex(projectSelectedIndex);
            }
            
            ProjectManager.SaveToFile(_project, ProjectManager.filePath, ProjectManager.folderPath);
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex >= 0)
            {
                NameLabel.Text = _notesList[NotesListBox.SelectedIndex].Name;
                ContentTextBox.Text = _notesList[NotesListBox.SelectedIndex].Content;
                CreatedTimePicker.Value = _notesList[NotesListBox.SelectedIndex].CreationTime;
                EditedTimePicker.Value = _notesList[NotesListBox.SelectedIndex].EditingTime;
                CategoryLabel.Text = "Category: " + _notesList[NotesListBox.SelectedIndex].Category;

                AssignCurrentIndex();
            }
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ShowAboutForm();
        }

        private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxUpdater();
        }
    }
}