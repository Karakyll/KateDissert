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
    public partial class FormHelp : Form
    {
        private FormMain mainForm;
        public FormHelp(FormMain mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonBlockHelpBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}
