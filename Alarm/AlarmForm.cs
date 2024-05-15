using System;
using System.Windows.Forms;

namespace Alarm
{
    public partial class AlarmForm : Form
    {
        private Alarm alarm;

        public AlarmForm()
        {
            InitializeComponent();
            alarm = new Alarm();
        }

        public AlarmForm(Alarm alarm)
        {
            InitializeComponent();
            this.alarm = alarm;
            FillForm();
        }

        private void FillForm()
        {
            timePicker.Value = alarm.Time;
            nameTextBox.Text = alarm.Name;
            recurringCheckBox.Checked = alarm.Recurring;
            activeCheckBox.Checked = alarm.Active;
        }

        public Alarm GetAlarm()
        {
            alarm.Time = timePicker.Value;
            alarm.Name = nameTextBox.Text;
            alarm.Recurring = recurringCheckBox.Checked;
            alarm.Active = activeCheckBox.Checked;
            return alarm;
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите название будильника.");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
