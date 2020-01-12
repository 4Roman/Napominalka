using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Выведение_данных_в_datagridview
{
    public partial class Form1 : Form
    {

        List<Note> Notes { get; set; } = new List<Note>();
        List<Note> OldNotes { get; set; } = new List<Note>();
        public Form1()
        {
            InitializeComponent();

        //listView1.

        //List<Note> notes = new List<Note>();
        // подожди минутку
        // у меня нет микрофона и наушники только Type-c
        //соханение в xml строку
        //string xml = notes.SerializeToXmlString();
        ////notes.Add(new Note());
        //сохранение xml строки в файл
        //SerializeExtension.SaveToXmlFile(xml, "Notes.xml");

        //загружаем из файла
        //List<Note> notes = new List<Note>(); // загружаем в клон
        
            Notes = SerializeExtension.LoadFromXml<List<Note>>("Notes.xml");

            foreach (var note in Notes)
                listView1.Items.Add(note.Date.ToShortDateString() + " : " + note.TextNote);

            // Вывести уведомление, когда наступила дата заметки и удаление если уже высвечивалось
        CheckNotesOnCurrentDate(Notes, DateTime.Now);
           
        }

        public void CheckNotesOnCurrentDate(List<Note> notes, DateTime date)
        {
            foreach (var note in notes)
            {
                if (note.Date.Date == date.Date)
                {
                    MessageBox.Show(note.TextNote);
                    Notes.Remove(note);
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();

            if (newForm.ResultNote == null)
                return;

            Notes.Add(newForm.ResultNote);
            listView1.Clear();
            foreach (var note in Notes)
                listView1.Items.Add(note.Date.ToShortDateString() + " : " + note.TextNote);
        }

        private void buttonSaveNotes_Click(object sender, EventArgs e)
        {
            //соханение в xml строку
            string xml = Notes.SerializeToXmlString();
            //notes.Add(new Note());
            //сохранение xml строки в файл
            SerializeExtension.SaveToXmlFile(xml, "Notes.xml");
            MessageBox.Show("Успешно сохранено");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Вывести уведомление, когда наступила дата заметки
            CheckNotesOnCurrentDate(Notes, DateTime.Now);
        }
    }


}

