namespace NapominalkaUI
{
    partial class FormNotification
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
            System.Windows.Forms.Button buttonOk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotification));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonLate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNextYear = new System.Windows.Forms.Button();
            buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.AutoSize = true;
            buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            buttonOk.Location = new System.Drawing.Point(11, 218);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(400, 53);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonLate
            // 
            this.buttonLate.AutoSize = true;
            this.buttonLate.Location = new System.Drawing.Point(11, 156);
            this.buttonLate.Name = "buttonLate";
            this.buttonLate.Size = new System.Drawing.Size(82, 23);
            this.buttonLate.TabIndex = 2;
            this.buttonLate.Text = "Отложить на";
            this.buttonLate.UseVisualStyleBackColor = true;
            this.buttonLate.Click += new System.EventHandler(this.buttonLate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonNextYear
            // 
            this.buttonNextYear.Location = new System.Drawing.Point(11, 184);
            this.buttonNextYear.Name = "buttonNextYear";
            this.buttonNextYear.Size = new System.Drawing.Size(401, 28);
            this.buttonNextYear.TabIndex = 4;
            this.buttonNextYear.Text = "Отложить на следующий год\r\n";
            this.buttonNextYear.UseVisualStyleBackColor = true;
            this.buttonNextYear.Click += new System.EventHandler(this.buttonNextYear_Click);
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 283);
            this.Controls.Add(this.buttonNextYear);
            this.Controls.Add(buttonOk);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonLate);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotification";
            this.Text = "FormNotification";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonLate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonNextYear;
    }
}