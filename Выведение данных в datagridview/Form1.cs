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
            List<Note> notes = new List<Note>(); // загружаем в клон
            notes = SerializeExtension.LoadFromXml<List<Note>>("Notes.xml");

            foreach (var note in notes)
                listView1.Items.Add(note.Date.ToShortDateString() + " : " + note.TextNote);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            if (newForm != null) 
            {
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Окно уже запущено");
            }
            
        }
        
        
    }
}
