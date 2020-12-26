using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        private void NotesAreEqual(Note note1, Note note2)
        {
            Assert.AreEqual(note1.Name, note2.Name);
            Assert.AreEqual(note1.Content, note2.Content);
            Assert.AreEqual(note1.CreationTime, note2.CreationTime);
            Assert.AreEqual(note1.EditingTime, note2.EditingTime);
            Assert.AreEqual(note1.Category, note2.Category);
        }
        
        [Test]
        public void Name_EmptyName_ReturnsDefaultName()
        {
            //Setup
            var note = new Note();
            var sourceName = "";
            var expectedName = "Untitled";

            //Act
            note.Name = sourceName;
            var actualName = note.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_CorrectName_ReturnsSameName()
        {
            //Setup
            var note = new Note();
            var sourceName = "Shopping List";
            var expectedName = sourceName;

            //Act
            note.Name = sourceName;
            var actualName = note.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_IncorrectName_ThrowsException()
        {
            //Setup
            var note = new Note();
            var sourceName = "This string contains exactly more than 50 characters";

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    note.Name = sourceName;
                }
            );
        }

        [Test]
        public void Category_CorrectCategory_ReturnsSameCategory()
        {
            //Setup
            var note = new Note();
            var sourceCategory = NoteCategory.HealthAndSport;
            var expectedCategory = sourceCategory;

            //Act
            note.Category = sourceCategory;
            var actualCategory = note.Category;

            //Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }

        [Test]
        public void Content_CorrectContent_ReturnsSameContent()
        {
            //Setup
            var note = new Note();
            var sourceContent = "6 Apples, 3 Tomatoes, 2 Cucumbers, 2 Carrots, 1 liters of Milk, Bread";
            var expectedContent = sourceContent;

            //Act
            note.Content = sourceContent;
            var actualContent = note.Content;

            //Assert
            Assert.AreEqual(expectedContent, actualContent);
        }

        [Test]
        public void EditingTime_CorrectEditingTime_ReturnsSameEditingTime()
        {
            //Setup
            var note = new Note();
            var sourceEditingTime = new DateTime(2020, 12, 23);
            var expectedEditingTime = sourceEditingTime;

            //Act
            note.EditingTime = sourceEditingTime;
            var actualEditingTime = note.EditingTime;

            //Assert
            Assert.AreEqual(expectedEditingTime, actualEditingTime);
        }

        [Test]
        public void CreationTime_CorrectCreationTime_ReturnsSameCreationTime()
        {
            //Setup
            var note = new Note();
            var sourceCreationTime = new DateTime(2020, 12, 23);
            var expectedCreationTime = sourceCreationTime;

            //Act
            note.CreationTime = sourceCreationTime;
            var actualCreationTime = note.CreationTime;

            //Assert
            Assert.AreEqual(expectedCreationTime, actualCreationTime);
        }
        
        [Test]
        public void Clone_CorrectNote_ReturnsSameNote()
        {
            //Setup
            var expectedNote = new Note
            {
                Name = "password for work computer",
                Content = "qwerty1234",
                Category = NoteCategory.Job,
                CreationTime = new DateTime(2020, 12, 22),
                EditingTime = new DateTime(2020, 12, 23)
            };

            //Act
            var actualNote = expectedNote.Clone() as Note;

            //Assert
            NotesAreEqual(expectedNote, expectedNote);
        }
    }
}
