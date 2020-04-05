using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapominalkaUI
{
    public class Note
    {
        public Note()
        {
        }

        public DateTime Date { get; set; } = new DateTime();
        public string TextNote { get; set; } = string.Empty;
        public Priorities Priority { get; set; } = Priorities.Low;
        public enum Priorities
        {
            Low,
            Medium,
            High
        }

        public static void SerializeNotesToFile(IEnumerable<Note> notes, string filepath = @"C:\Napominalka\Notes.xml")
        {
            List<Note> list = notes.ToList();
            //соханение в xml строку
            string xml = list.SerializeToXmlString();
            //сохранение xml строки в файл
            SerializeExtension.SaveToXmlFile(xml, filepath);
        }

        public static IEnumerable<Note> DerializeNotesFromFile(string filepath = @"C:\Napominalka\Notes.xml")
        {
            return SerializeExtension.LoadFromXml<List<Note>>(filepath);
        }

    }
}
