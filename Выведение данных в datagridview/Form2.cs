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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)// надо найти куда записываются значения переменных
        {
            this.Close();

        }
              
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            MessageBox.Show(s);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            string b =  a.ToString();
            MessageBox.Show(b);
        }
    }       
}
