using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки.
    /// Содержит поля Название, Категория заметки, Содержание заметки, Время создания, Время последнего изменения.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _name;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Содержание заметки
        /// </summary>
        private string _content;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private readonly DateTime _creationTime = DateTime.Now;

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _editingTime = DateTime.Now;

        /// <summary>
        /// Свойство названия заметки
        /// Проверятеся длина названия не более 50 символов и устанавливается значение при пустом названии
        /// Меняется время последнего изменения
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Название ограничено 50 символами");
                }
                else
                {
                    if (value != string.Empty)
                    {
                        _name = value;
                    }
                    else
                    {
                        _name = "Untitled";
                    }
                    EditingTime = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Свойство категории заметки
        /// При изменении категории меняется время последнего изменения
        /// </summary>
        public NoteCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
                EditingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство содержания заметки
        /// При изменении содержания меняется время последнего изменения
        /// </summary>
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                EditingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство времени создания заметки
        /// Время создания не модифицируется
        /// </summary>
        public DateTime CreationTime
        {
            get { return _creationTime; }
        }

        /// <summary>
        /// Свойство времени последнего изменения заметки
        /// </summary>
        public DateTime EditingTime
        {
            get { return _editingTime; }
            set
            {
                _editingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Метод клонирования
        /// </summary>
        public object Clone()
        {
            return new Note
            {
                Name = Name,
                Content = Content,
                EditingTime = EditingTime,
                Category = Category
            };
        }
    }
}
