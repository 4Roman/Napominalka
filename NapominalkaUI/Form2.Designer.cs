namespace NapominalkaUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(578, 274);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 44);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAccept.Location = new System.Drawing.Point(12, 271);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(145, 47);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Готово";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(688, 136);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.CustomFormat = "hh:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.dateTimePicker1);
            this.groupBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBoxDate.Location = new System.Drawing.Point(12, 15);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(207, 59);
            this.groupBoxDate.TabIndex = 8;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Дата";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.dateTimePicker2);
            this.groupBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBoxTime.Location = new System.Drawing.Point(500, 15);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(207, 59);
            this.groupBoxTime.TabIndex = 9;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Время";
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.Controls.Add(this.richTextBox1);
            this.groupBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBoxNote.Location = new System.Drawing.Point(2, 91);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(694, 166);
            this.groupBoxNote.TabIndex = 10;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Заметка";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 330);
            this.Controls.Add(this.groupBoxNote);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Napominalka";
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxNote;
    }
}