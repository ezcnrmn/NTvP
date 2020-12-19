﻿using System;
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
        private DateTime _creationTime = DateTime.Now;

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _editingTime = DateTime.Now;

        /// <summary>
        /// Свойство названия заметки
        /// Проверяется длина названия не более 50 символов и устанавливается значение при пустом названии
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name is limited to 50 characters!");
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
                }
            }
        }

        /// <summary>
        /// Свойство категории заметки
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Свойство содержания заметки
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }

        /// <summary>
        /// Свойство времени создания заметки
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
            set
            {
                _creationTime = value;
            }
        }

        /// <summary>
        /// Свойство времени последнего изменения заметки
        /// </summary>
        public DateTime EditingTime
        {
            get
            {
                return _editingTime;
            }
            set
            {
                _editingTime = value;
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
                CreationTime = CreationTime,
                Category = Category
            };
        }
    }
}
