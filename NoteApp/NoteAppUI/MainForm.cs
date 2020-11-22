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
            categoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            attantionLabel.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Note Note = new Note();
            Note.Name = nameTextBox.Text;
            Note.Content = contentTextBox.Text;
            NoteCategory selectedNoteCategory;
            selectedNoteCategory = (NoteCategory)categoryComboBox.SelectedItem;
            Note.Category = selectedNoteCategory;
            Note.EditingTime = DateTime.Now;
            
            //Сериализация
            Project serializatedProject = new Project { Notes = { Note } };
            ProjectManager.SaveToFile(serializatedProject, ProjectManager.folderPath);
            
            //Десериализация
            Project deserializatedProject = ProjectManager.LoadFromFile(ProjectManager.folderPath);
            attantionLabel.Text = "Saved!";
        }
    }
}
