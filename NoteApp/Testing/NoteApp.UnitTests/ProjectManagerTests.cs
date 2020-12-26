using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        private Project PrepareProject()
        {
            var sourceProject = new Project();
            sourceProject.Notes.Add(new Note()
            {
                Name = "Shrek movies",
                Content = "Shrek (2001), Shrek 2(2004), Shrek the Third(2007), Shrek Forever After(2010)",
                Category = NoteCategory.Documents,
                CreationTime = new DateTime(2020, 12, 22),
                EditingTime = new DateTime(2020, 12, 23)
            });
            sourceProject.Notes.Add(new Note()
            {
                Name = "Shrek 5 is real?",
                Content = "",
                Category = NoteCategory.Documents,
                CreationTime = new DateTime(2020, 12, 22),
                EditingTime = new DateTime(2020, 12, 23)
            });
            return sourceProject;
        }

        private string TestDataFolderPath()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            return testDataFolder;
        }

        private void NotesAreEqual(Note note1, Note note2)
        {
            Assert.AreEqual(note1.Name, note2.Name);
            Assert.AreEqual(note1.Content, note2.Content);
            Assert.AreEqual(note1.CreationTime, note2.CreationTime);
            Assert.AreEqual(note1.EditingTime, note2.EditingTime);
            Assert.AreEqual(note1.Category, note2.Category);
        }

        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();

            var testDataFolder = TestDataFolderPath();
            var actualFileName = testDataFolder + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            if (File.Exists(actualFileName))
            {
                File.Delete(actualFileName);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject, actualFileName, testDataFolder);

            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void SaveToFile_NonexistentFolder_FileSavedCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();

            var testDataFolder = TestDataFolderPath();
            var actualFilePath = testDataFolder + @"\OutputTestFolder";
            var actualFileName = actualFilePath + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            if (Directory.Exists(actualFilePath))
            {
                Directory.Delete(actualFilePath, true);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject, actualFileName, actualFilePath);

            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void LoadFromFile_CorrectProject_FileLoadedCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();

            var testDataFolder = TestDataFolderPath();
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(expectedFileName);

            //Assert
            if (sourceProject.Notes.Count == actualProject.Notes.Count)
            {
                for (int i = 0; i < sourceProject.Notes.Count; i++)
                {
                    NotesAreEqual(sourceProject.Notes[i], actualProject.Notes[i]);
                }
            }
            else
            {
                Assert.Fail("Amount of sourceProject notes is not equal to actualProject notes");
            }
        }

        [Test]
        public void LoadFromFile_NonexistentProject_EmptyProjectLoaded()
        {
            //Setup
            var sourceProject = new Project();

            var testDataFolder = TestDataFolderPath();
            var nonexistentFileName = testDataFolder + @"\NonexistentProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(nonexistentFileName);

            //Assert
            if (sourceProject.Notes.Count == actualProject.Notes.Count)
            {
                for (int i = 0; i < sourceProject.Notes.Count; i++)
                {
                    NotesAreEqual(sourceProject.Notes[i], actualProject.Notes[i]);
                }
            }
            else
            {
                Assert.Fail("Amount of sourceProject notes is not equal to actualProject notes");
            }
        }

        [Test]
        public void LoadFromFile_IncorrectFile_EmptyProjectLoaded()
        {
            //Setup
            var sourceProject = new Project();

            var testDataFolder = TestDataFolderPath();
            var incorrectFileName = testDataFolder + @"\incorrectProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(incorrectFileName);

            //Assert
            if (sourceProject.Notes.Count == actualProject.Notes.Count)
            {
                for (int i = 0; i < sourceProject.Notes.Count; i++)
                {
                    NotesAreEqual(sourceProject.Notes[i], actualProject.Notes[i]);
                }
            }
            else
            {
                Assert.Fail("Amount of sourceProject notes is not equal to actualProject notes");
            }
        }
    }
}
