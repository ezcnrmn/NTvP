﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    // <summary>
    /// Класс менеджера проекта.
    /// Содержит 
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Имя файла для сериализации и десериализации
        /// Закрытая константа
        /// </summary>
        private const string fileName = @"\NoteApp.notes";

        /// <summary>
        /// Путь до папки сохранения
        /// </summary>
        public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NoteApp";

        /// <summary>
        /// Полный путь до файла сохранения
        /// </summary>
        public static string filePath = folderPath + fileName;

        /// <summary>
        /// Сериализация данных
        /// </summary>
        public static void SaveToFile(Project project, string filePath, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Десериализация данных
        /// </summary>
        public static Project LoadFromFile(string filePath)
        {
            Project project;
            if(!File.Exists(filePath))
            {
                return new Project();
            }
            JsonSerializer serializer = new JsonSerializer();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    using (JsonTextReader reader = new JsonTextReader(sr))
                    {
                        project = (Project) serializer.Deserialize<Project>(reader);
                    }
                }
            }
            catch
            {
                project = new Project();
            }
            return project;
        }
    }
}
