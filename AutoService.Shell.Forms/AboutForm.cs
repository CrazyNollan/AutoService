using System;
using System.Windows.Forms;

namespace AutoService.Shell.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // Кнопка закрытия формы
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainForm"]?.Show();
            this.Hide();
        }

        // При закрытии формы принудительно
        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Application.OpenForms["MainForm"]?.Show();
            this.Hide();
        }
    }
}