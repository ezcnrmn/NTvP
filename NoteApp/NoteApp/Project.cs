using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта.
    /// Содержит список всех заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Индекс текущей заметки
        /// </summary>
        public int CurrentIndex { get; set; }
        
        /// <summary>
        /// Все заметки, созданные в приложении
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /// <summary>
        /// Сортировка по дате изменения и категории заметок
        /// </summary>
        public List<Note> SortingNotes(List<Note> notes, NoteCategory category)
        {
            return notes.Where(item => item.Category == category).OrderByDescending(item => item.EditingTime).ToList();
        }
        
        /// <summary>
        /// Сортировка по дате изменения
        /// </summary>
        public List<Note> SortingNotes(List<Note> notes)
        {
            return notes.OrderByDescending(item => item.EditingTime).ToList();
        }
    }
}
