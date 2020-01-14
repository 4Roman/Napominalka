using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace Выведение_данных_в_datagridview
{
    public partial class Form1 : Form
    {

        BindingList<Note> Notes { get; set; } = new BindingList<Note>();
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

            // создать новый файл с заметками ( в случае поломок)
            //InitializeDefaultNotesFile();

            // пытаемся считать файл
            try
            {
                Notes = new BindingList<Note>(Note.DerializeNotesFromFile().ToList());
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось считать файл!\n"+ e.ToString());
                InitializeDefaultNotesFile();
            }
            
            // TODO: DataBinding
            dataGridViewNotes.AutoGenerateColumns = true;
            dataGridViewNotes.DataSource = Notes;

            ShowNotifications();
        }

        public void InitializeDefaultNotesFile()
        {
            //соханение в xml строку
            Notes.Add(new Note());
            string xml = Notes.SerializeToXmlString();
            //сохранение xml строки в файл
            //SerializeExtension.SaveToXmlFile(xml, "Notes.xml");
            Note.SerializeNotesToFile(Notes);

        }


        static object locker = new object();
        public List<Note> CheckNotesOnCurrentDate(IEnumerable<Note> notes, DateTime date)
        {
            lock (locker)
            {
                List<Note> notesOnCurrentDate = new List<Note>();
                foreach (var note in notes)
                {

                    if (note.Date.Date == date.Date)
                    {
                        notesOnCurrentDate.Add(note);
                    }
                }
                //foreach (Note noteForRemove in notesForRemove)
                //{
                //    var temp = noteForRemove;
                //    Notes.TryTake(result: out temp);
                //}
                return notesOnCurrentDate;
            }
        }

        public void buttonCreateNote_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();

            if (newForm.ResultNote == null)
                return;

            Notes.Add(newForm.ResultNote);
        }

        private void buttonSaveNotes_Click(object sender, EventArgs e)
        {
            //соханение в xml строку
            //string xml = Notes.SerializeToXmlString();
            //notes.Add(new Note());
            //сохранение xml строки в файл
            //SerializeExtension.SaveToXmlFile(xml, "Notes.xml");
            Note.SerializeNotesToFile(Notes);
            MessageBox.Show("Успешно сохранено");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                // Вывести уведомление, когда наступила дата заметки
                ShowNotifications();
            }
        }

        private void ShowNotifications()
        {
            List<Note> notesOnCurrentDay = CheckNotesOnCurrentDate(Notes, DateTime.Now);
            foreach (var note in notesOnCurrentDay)
                Notes.Remove(note);

            foreach (var note in notesOnCurrentDay)
                MessageBox.Show(note.TextNote);
            Refresh();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Note.SerializeNotesToFile(Notes);
        }
        //public void Refresh()
        //{
        //    listView1.Clear();
        //    foreach (var note in Notes)
        //        listView1.Items.Add(note.Date.ToShortDateString() + " : " + note.TextNote);
        //}

    }


}

