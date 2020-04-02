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
    public partial class Napominalka : Form
    {
        public Note ResultNote { get; set; }
        public Napominalka()
        {
            InitializeComponent();

            dateTimePicker2.ShowUpDown = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAccept_Click(object sender, EventArgs e)// надо найти куда записываются значения переменных
        {
            // create object Note
            Note note = new Note();
            DateTime date = dateTimePicker1.Value;
            DateTime time = dateTimePicker2.Value;

            if (date == null)
            {
                MessageBox.Show("Установите дату!");
                return;
            }
            if (date < DateTime.Now.Date)
            {
                MessageBox.Show("Заметка на прошедшую дату не возможна!");
                return;
            }
            string text = richTextBox1.Text;
            if (text == null || text == string.Empty)
            {
                MessageBox.Show("Заметка пуста!");
                return;
            }

            note.Date = new DateTime(date.Year,date.Month,date.Day, time.Hour,time.Minute, 0);
            note.TextNote = text;
            ResultNote = note;
            this.Close();

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            MessageBox.Show(text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string dateString = date.ToString();
            MessageBox.Show(dateString);
        }
    }
}
