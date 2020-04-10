using ContactsApp;
using NUnit.Framework;
using System.Linq;

namespace СontactsAppUnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Позитивный тест добавления элемента в список")]
        public void TestProjectListAdd_CorrectValue()
        {
            Contact contact = new Contact();
            contact.Surname = "Смирнов";
            var project = new Project();
            project.ContactList.Add(contact);
            var actual = project.ContactList.First();
            Assert.AreEqual(contact, actual, "Project возвращает неправильное значение");
        }
    }
}