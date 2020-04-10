using ContactsApp;
using NUnit.Framework;
using System;

namespace СontactsAppUnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
            ;
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void NameTestGet_CorrectValue()
        {
            var Name = "Иван";
            _contact.Name = Name;
            var actual = _contact.Name;
            Assert.AreEqual(Name, actual, "Геттер Name возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void NameTestSet_CorrectValue()
        {
            var Name = "Иван";
            _contact.Name = Name;
            var actual = _contact.Name;
            Assert.AreEqual(Name, actual, "Cеттер Name задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод имени, длиной более 50 символов")]
        public void NameTestSet_Longer50()
        {
            var wrongName = "ИванИванИванИванИванИванИванИванИванИванИванИванИван";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongName; }, "Должно возникать исключения, если имя содержит более 50 символов");
        }

        [Test(Description = "Проверка на имени, длиной 0 символов")]
        public void NameTestSet_Equal0()
        {
            var wrongName = "";
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongName; }, "Должно возникать исключения, если имя не содержит символов");
        }

        /// <summary>
        /// Тесты Surname.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Surname")]
        public void SurnameTestGet_CorrectValue()
        {
            var Surname = "Смирнов";
            _contact.Name = Surname;
            var actual = _contact.Name;
            Assert.AreEqual(Surname, actual, "Геттер Surname возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Surname")]
        public void SurnameTestSet_CorrectValue()
        {
            var Surname = "Смирнов";
            _contact.Surname = Surname;
            var actual = _contact.Surname;
            Assert.AreEqual(Surname, actual, "Cеттер Surname задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод фамилии, длинной более 50 символов")]
        public void SurnameTestSet_Longer50()
        {
            var wrongSurname = "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов";
            Assert.Throws<ArgumentException>(() => { _contact.Surname = wrongSurname; }, "Должно возникать исключения, если фамилия содержит более 50 символов");
        }

        [Test(Description = "Проверка на ввод фамилии, длиной 0 символов")]
        public void SurnameTestSet_Equal0()
        {
            var wrongSurname = "";
            Assert.Throws<ArgumentException>(() => { _contact.Surname = wrongSurname; }, "Должно возникать исключения, если фамилия не содержит символов");
        }

        /// <summary>
        /// Тесты BirthDay.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday")]
        public void BirthDayTestGet_CorrectValue()
        {
            var BirthDay = DateTime.Now;
            _contact.BirthDay = BirthDay;
            var actual = _contact.BirthDay;
            Assert.AreEqual(BirthDay, actual, "Геттер BirthDay возвращает неправильное значение");
        }

        [Test(Description = "Проверка на ввод года рождения, меньше 1900")]
        public void BirthDayTestSet_IncorrectMinValue()
        {
            Assert.Throws<ArgumentException>(() => { _contact.BirthDay = new DateTime(1000, 1, 1); }, "Должно возникать исключение, если год рождения меньше 1900 года");
        }

        [Test(Description = "Проверка на ввод года рождения, больше текущего")]
        public void BirthDayTestSet_IncorrectBigValue()
        {
            Assert.Throws<ArgumentException>(() => { _contact.BirthDay = new DateTime(3000, 1, 1); }, "Должно возникать исключение, если год рождения больше текущего");
        }

        /// <summary>
        /// Тесты Email.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email")]
        public void EmailTestGet_CorrectValue()
        {
            var Email = "ivan@mail.ru";
            _contact.Email = Email;
            var actual = _contact.Email;
            Assert.AreEqual(Email, actual, "Геттер Email возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void EmailTestSet_CorrectValue()
        {
            var Email = "ivan@mail.ru";
            _contact.Email = Email;
            var actual = _contact.Email;
            Assert.AreEqual(Email, actual, "Cеттер Email задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод адреса почты, длиной более 50 символов")]
        public void EmailTestSet_Longer50()
        {
            var wrongEmail = "ivan@mail.ruivan@mail.ruivan@mail.ruivan@mail.ruivan@mail.ru";
            Assert.Throws<ArgumentException>(() => { _contact.Email = wrongEmail; }, "Должно возникать исключения, если Email содержит более 50 символов");
        }

        [Test(Description = "Проверка адреса почты с длиной 0")]
        public void EmailTestSet_Equal0()
        {
            var wrongEmail = string.Empty;
            Assert.Throws<ArgumentException>(() => { _contact.Email = wrongEmail; }, "Должно возникать исключения, если Email не содержит символов");
        }

        /// <summary>
        /// Тесты VkId.
        /// </summary>
        [Test(Description = "Позитивный тест геттера VkId")]
        public void VkIdTestGet_CorrectValue()
        {
            var VkId = "id75359087";
            _contact.VkId = VkId;
            var actual = _contact.VkId;
            Assert.AreEqual(VkId, actual, "Геттер VkId возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера VkId")]
        public void VkIdTestSet_CorrectValue()
        {
            var VkId = "id75359087";
            _contact.VkId = VkId;
            var actual = _contact.VkId;
            Assert.AreEqual(VkId, actual, "Cеттер VkId задает неправильное значение");
        }

        [Test(Description = "Проверка на ввод ID Вконтакте, длиной более 15 символов")]
        public void VkIdTestSet_Longer15()
        {
            var wrongVkId = "id75359087id75359087";
            Assert.Throws<ArgumentException>(() => { _contact.VkId = wrongVkId; }, "Должно возникать исключения, если VkId содержит более 15 символов");
        }

        [Test(Description = "Проверка id-вконтакте с длиной 0")]
        public void VkIdTestSet_Equal0()
        {
            var VkId = "";
            _contact.VkId = VkId;
            var actual = _contact.VkId;
            Assert.AreEqual(VkId, actual, "Сеттер VkId задает неправильное значение");
        }
    }
}
