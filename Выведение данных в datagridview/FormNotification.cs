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
    public partial class FormNotification : Form
    {
        public Note Note { get; set; } = new Note();
        public DateTime NextTimeOfNotifications { get; set; } = new DateTime();
        public FormNotification(Note note)
        {
            InitializeComponent();
            richTextBox1.Text = note.TextNote;
            dateTimePicker1.Value = note.Date.AddMinutes(30);
            Note = note;
        }

        private void buttonLate_Click(object sender, EventArgs e)
        {
            NextTimeOfNotifications = dateTimePicker1.Value;
            Note.Date = NextTimeOfNotifications;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Note = null;
            this.Close();
        }

        private void buttonNextYear_Click(object sender, EventArgs e)            
        {           
            Note.Date = Note.Date.AddYears(1);
            this.Close();
        }
    }
}
