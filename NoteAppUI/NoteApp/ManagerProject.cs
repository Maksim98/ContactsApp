using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    // TODO: неправильное именование класса
    // TODO: xml-комментарии
    public static class ManagerProject //класс для сохранения проекта в файл и выгрузки его обратно
    {
        // TODO: пустые строки между членами класса + xml-комментарии
        private const string _name = @"\ContactsApp.notes";
        private static readonly string _path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static readonly string _file = _path + _name;
        // TODO: метод должен принимать имя файла, иначе логику нельзя протестировать
        public static void SaveToFile(Project data)
        {
            var serializer = new JsonSerializer { Formatting = Formatting.Indented };
            using (var sw = new StreamWriter(_file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }
        // TODO: метод должен принимать имя файла
        public static Project LoadFromFile()
        {
            // TODO: отсутствует обработка ситуации, когда файл не существует
            Project project = null;
            var serializer = new JsonSerializer { Formatting = Formatting.Indented };
            using (var sr = new StreamReader(_file))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
