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
    public partial class FormTasks : Form
    {
        private FormMain formMain;
        public FormTasks(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
        }

        private void FormTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormBlock1 block1 = new FormBlock1(this);
            block1.StartPosition = FormStartPosition.CenterScreen;
            block1.ShowDialog();
        }

        private void buttonBlock2_Click(object sender, EventArgs e)
        {
            Hide();
            FormBlock2 block2 = new FormBlock2(this);
            block2.StartPosition = FormStartPosition.CenterScreen;
            block2.ShowDialog();
        }

        private void buttonBlock3_Click(object sender, EventArgs e)
        {
            Hide();
            FormBlock3 block3 = new FormBlock3(this);
            block3.StartPosition = FormStartPosition.CenterScreen;
            block3.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMain.Show();
            Close();
        }
    }
}
