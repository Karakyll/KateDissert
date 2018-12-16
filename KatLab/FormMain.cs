using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatLab
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBlock1_Click(object sender, EventArgs e)
        {
            Hide();
            FormHelp helpForm = new FormHelp(this);
            helpForm.StartPosition = FormStartPosition.CenterScreen;
            helpForm.ShowDialog();
        }

        private void buttonBlock2_Click(object sender, EventArgs e)
        {
            Hide();
            FormTasks tasksForm = new FormTasks(this);
            tasksForm.StartPosition = FormStartPosition.CenterScreen;
            tasksForm.ShowDialog();
        }

        private void buttonBlock3_Click(object sender, EventArgs e)
        {

        }
    }
}
