using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTests
    {
        public Project PrepareProject()
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

        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();

            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
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

            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var actualFilePath = testDataFolder + @"\CreationFolderTest";
            var actualFileName = actualFilePath + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            if (Directory.Exists(actualFilePath))
            {
                if (File.Exists(actualFileName))
                {
                    File.Delete(actualFileName);
                }
                Directory.Delete(actualFilePath);
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

            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(expectedFileName);

            //Assert
            var expectedData = JsonConvert.SerializeObject(sourceProject);
            var actualData = JsonConvert.SerializeObject(actualProject);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void LoadFromFile_NonexistentProject_EmptyProjectLoaded()
        {
            //Setup
            var sourceProject = new Project();

            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var nonexistentFileName = testDataFolder + @"\NonexistentProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(nonexistentFileName);

            //Assert
            var expectedData = JsonConvert.SerializeObject(sourceProject);
            var actualData = JsonConvert.SerializeObject(actualProject);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void LoadFromFile_IncorrectFile_EmptyProjectLoaded()
        {
            //Setup
            var sourceProject = new Project();

            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var incorrectFileName = testDataFolder + @"\incorrectProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(incorrectFileName);

            //Assert
            var expectedData = JsonConvert.SerializeObject(sourceProject);
            var actualData = JsonConvert.SerializeObject(actualProject);
            Assert.AreEqual(expectedData, actualData);
        }
    }
}
