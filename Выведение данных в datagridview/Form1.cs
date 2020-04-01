using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using Microsoft.Win32;
using System.IO;



namespace Выведение_данных_в_datagridview
{
    public partial class Form1 : Form
    {
        const string applicationName = "Napominalka";
        BindingList<Note> Notes { get; set; } = new BindingList<Note>();
        List<Note> OldNotes { get; set; } = new List<Note>();

        public Form1()
        {        
            
            InitializeComponent();
            if (Directory.Exists(@"C:\Napominalka") == false) Directory.CreateDirectory(@"C:\Napominalka");


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
                MessageBox.Show("Не удалось считать файл!\n" + e.ToString());
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
        public double DeltaTimeForNotifications { get; set; } = 5.0;
        public List<Note> CheckNotesOnCurrentDate(IEnumerable<Note> notes, DateTime date)
        {
            lock (locker)
            {
                List<Note> notesOnCurrentDate = new List<Note>();
                foreach (var note in notes)
                {
                    if (note.Date.Date == date.Date)
                    {
                        TimeSpan span = date - note.Date;
                        double result = Math.Abs(span.TotalMinutes);

                        if (result <= DeltaTimeForNotifications)
                        {
                            notesOnCurrentDate.Add(note);
                        }
                    }
                    else if (note.Date.Date <= date.Date)
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

        private static readonly Object notificationLocker = new Object();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Вывести уведомление, когда наступила дата заметки
            ShowNotifications();
        }

        private bool busyNotifications = false;
        private void ShowNotifications()
        {
            lock (notificationLocker)
            {
                if (busyNotifications)
                    return;

                busyNotifications = true;
                List<Note> notesOnCurrentDay = CheckNotesOnCurrentDate(Notes, DateTime.Now);
                //foreach (var note in notesOnCurrentDay)
                //    Notes.Remove(note);

                foreach (var note in notesOnCurrentDay)
                {
                    var formNotification = new FormNotification(note);

                    formNotification.ShowDialog();
                    if (formNotification.Note == null)
                        Notes.Remove(note);

                    //MessageBox.Show(note.TextNote); // TODO заменить на форму с переносом уведомления
                    //Refresh();
                }
                busyNotifications = false;
            }
            dataGridViewNotes.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Note.SerializeNotesToFile(Notes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Some Title";
            notifyIcon1.Text = "Напоминалка";

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon1.Visible = false; }
        }

        private static bool CheckAutorun()
        {
            bool isEnableAutorun = false;
            RegistryKey reg;
            reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            var autoRun = reg.GetValue(applicationName); // проверяем наличие записи в реестре
            if (autoRun == null)
                isEnableAutorun = false;
            else isEnableAutorun = true;
            return isEnableAutorun;//если CheckAutorun true - то автозапук есть
        }
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// true если удалось задать значение
        /// false если задать значение не удалось
        /// </summary>
        /// <param name="autorun"></param>
        /// <returns></returns>
        public bool SetAutorunValue(bool autorun)
        {
            //const string name = "MyTestApplication"; // как запустить этот участок?
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            //reg.GetValue(name) Всё работает

            try
            {
                if (autorun)
                    reg.SetValue(applicationName, ExePath);
                else
                    reg.DeleteValue(applicationName);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void toolStripMenuItemAutorun_Click(object sender, EventArgs e)
        {
            var autorun = CheckAutorun();
            if (autorun == true)
            {
                var result = SetAutorunValue(false);
                if (result == true)
                    toolStripMenuItemAutorun.CheckState = CheckState.Unchecked;
            }
            else
            {
                var result = SetAutorunValue(true);
                if (result == true)
                    toolStripMenuItemAutorun.CheckState = CheckState.Checked;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var autorun = CheckAutorun();
            if (autorun == true)
                toolStripMenuItemAutorun.CheckState = CheckState.Checked;
            else toolStripMenuItemAutorun.CheckState = CheckState.Unchecked;
        }

        //public void Refresh()
        //{
        //    listView1.Clear();
        //    foreach (var note in Notes)
        //        listView1.Items.Add(note.Date.ToShortDateString() + " : " + note.TextNote);
        //}

    }


}
