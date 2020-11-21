using System;
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
        private const string FileName = "NoteApp.notes";

        /// <summary>
        /// Путь до папки сохранения
        /// </summary>
        public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NoteApp/";

        /// <summary>
        /// Полный путь до файла
        /// </summary>
        private static string pathToFile = folderPath + FileName;

        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <param name="folderPath">Путь до папки сохранения</param>
        public static void SaveToFile(Project project, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(pathToFile))
            using (JsonTextWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Десериализация данных
        /// </summary>
        public static Project LoadFromFile(string folderPath)
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();

            try
            {
                using (StreamReader sr = new StreamReader(folderPath))
                using (JsonTextReader reader = new JsonTextReader(sr))
                    project = (Project)serializer.Deserialize<Project>(reader);
            }
            catch
            {
                project = new Project();
            }
            return project;
        }
    }
}
