using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using u23.Properties;

namespace u23
{
    public partial class SettingsForm : Form
    {
        private List<string> itemList;
        public SettingsForm()
        {
            InitializeComponent();
            itemList = new List<string>
            {
                "Default contrast",
                "High contrast"
            };

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSettings()
        {

            string settingsFilePath = "settings.txt";
            string settingsData = $"Apply: {applyButton} | Cancel: {cancelButton}| Colour: {colour_comboBox}";
            try
            {
                File.WriteAllText(settingsFilePath, settingsData);

                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colour_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            colour_comboBox.DataSource = itemList;

            string selectedContrast = colour_comboBox.SelectedItem.ToString();

            if (selectedContrast == "Default contrast")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                applyButton.ForeColor = SystemColors.ControlText;
                cancelButton.ForeColor = SystemColors.ControlText;
            }
            else if (selectedContrast == "High contrast")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                applyButton.ForeColor = Color.Black;
                cancelButton.ForeColor = Color.Black;
            }
        }

        /*private void SaveSelectedColour(string selectedColour)
        {
            Properties.Settings.Default.SelectedColour = selectedColour;
            settings.Save();
        }*/
    }
}
