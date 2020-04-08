using System;
using System.Windows.Forms;

namespace NapominalkaUI
{
    public partial class Form2 : Form
    {
        public Note ResultNote { get; set; }
        public Form2()
        {
            InitializeComponent();
            comboBoxNotePriority.DataSource = Enum.GetNames(typeof(Note.Priorities));

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
            //Note.Priorities priority;
            Enum.TryParse<Note.Priorities>(comboBoxNotePriority.SelectedItem.ToString(), out var priority);

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
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Заметка пуста!");
                return;
            }

            note.Date = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0);
            note.Priority = priority;
            note.TextNote = text;
            ResultNote = note;
            this.Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void comboBoxNotePriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
