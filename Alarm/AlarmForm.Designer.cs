namespace Alarm
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.recurringCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(38, 54);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(100, 20);
            this.timePicker.TabIndex = 0;
            this.timePicker.Value = new System.DateTime(2024, 5, 15, 15, 43, 0, 0);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(22, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // recurringCheckBox
            // 
            this.recurringCheckBox.AutoSize = true;
            this.recurringCheckBox.Location = new System.Drawing.Point(46, 106);
            this.recurringCheckBox.Name = "recurringCheckBox";
            this.recurringCheckBox.Size = new System.Drawing.Size(92, 17);
            this.recurringCheckBox.TabIndex = 2;
            this.recurringCheckBox.Text = "Повторяется";
            this.recurringCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(57, 129);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(68, 17);
            this.activeCheckBox.TabIndex = 3;
            this.activeCheckBox.Text = "Активен";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(57, 152);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 4;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(142, 6);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Закрыть";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.OKbtn);
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.activeCheckBox);
            this.panel1.Controls.Add(this.recurringCheckBox);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 252);
            this.panel1.TabIndex = 6;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 260);
            this.Controls.Add(this.panel1);
            this.Name = "AlarmForm";
            this.Text = "Alarmform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox recurringCheckBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel panel1;
    }
}