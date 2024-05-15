using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Alarm
{
    public partial class Form1 : Form
    {
        private List<Alarm> alarms = new List<Alarm>();
        private const string FilePath = "alarms.json";

        public Form1()
        {
            InitializeComponent();
            LoadAlarms();
        }

        private void LoadAlarms()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var jsonString = File.ReadAllText(FilePath);
                    alarms = JsonSerializer.Deserialize<List<Alarm>>(jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке будильников из файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateAlarmList();
        }

        private void SaveAlarms()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(alarms);
                File.WriteAllText(FilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении будильников в файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAlarmList()
        {
            listView1.Items.Clear();
            foreach (Alarm alarm in alarms)
            {
                ListViewItem item = new ListViewItem(alarm.Time.ToString());
                item.SubItems.Add(alarm.Name);
                item.SubItems.Add(alarm.Recurring ? "Да" : "Нет");
                item.SubItems.Add(alarm.Active ? "Активен" : "Неактивен");
                listView1.Items.Add(item);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AlarmForm form = new AlarmForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Alarm alarm = form.GetAlarm();
                alarms.Add(alarm);
                UpdateAlarmList();
                SaveAlarms();
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                Alarm alarm = alarms[index];
                AlarmForm form = new AlarmForm(alarm);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    alarm = form.GetAlarm();
                    alarms[index] = alarm;
                    UpdateAlarmList();
                    SaveAlarms();
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {               
                List<int> indicesToRemove = listView1.SelectedIndices.Cast<int>().ToList();             
                indicesToRemove.Reverse();
                foreach (int index in indicesToRemove)
                {
                    alarms.RemoveAt(index);
                }

                UpdateAlarmList();
                SaveAlarms();
            }
        }
    }
}
