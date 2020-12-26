using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
       [Test]
        public void Project_CreateProject_ReturnsNotNullResult()
        {
            //Setup
            var sourceProject = new Project();

            //Act
            sourceProject.Notes.Add(new Note());

            //Assert
            Assert.IsNotNull(sourceProject);
        }
    }
}
