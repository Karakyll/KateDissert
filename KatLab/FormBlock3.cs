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
    public partial class FormBlock3 : Form
    {
        private FormTasks tasksForm;
        private int taskIndex = 1;
        private int errorCounter = 0;
        public FormBlock3(FormTasks tasksForm)
        {
            this.tasksForm = tasksForm;
            InitializeComponent();
        }

        private void FormBlock3_Load(object sender, EventArgs e)
        {
            labelCounterIndex.Text = taskIndex.ToString() + " / 7";
        }

        private void FormBlock3_FormClosing(object sender, FormClosingEventArgs e)
        {
            tasksForm.Show();
        }

        private void buttonBlock3Back_Click(object sender, EventArgs e)
        {
            tasksForm.Show();
            Close();
        }

        private void pictureBoxHead_Click(object sender, EventArgs e)
        {
            if (taskIndex == 3 || taskIndex == 7)
            {
                taskIndex++;
                rerenderBlock();
            }
            else
            {
                errorCounter++;
            }
        }

        private void pictureBoxNeck_Click(object sender, EventArgs e)
        {
            if (taskIndex == 2)
            {
                taskIndex++;
                rerenderBlock();
            }
            else
            {
                errorCounter++;
            }
        }

        private void pictureBoxLeftHand_Click(object sender, EventArgs e)
        {
            if (taskIndex == 1 || taskIndex == 5)
            {
                taskIndex++;
                rerenderBlock();
            } else
            {
                errorCounter++;
            }
        }

        private void pictureBoxRightHand_Click(object sender, EventArgs e)
        {
            if (taskIndex == 1 || taskIndex == 5)
            {
                taskIndex++;
                rerenderBlock();
            }
            else
            {
                errorCounter++;
            }
        }

        private void pictureBoxFoot_Click(object sender, EventArgs e)
        {
            if (taskIndex == 4 || taskIndex == 6)
            {
                taskIndex++;
                rerenderBlock();
            }
            else
            {
                errorCounter++;
            }
        }

        private void rerenderBlock()
        {
            if (taskIndex == 1)
            {
                pictureBox2.Image = Properties.Resources.b3t1;
            }
            if (taskIndex == 2)
            {
                pictureBox2.Image = Properties.Resources.b3t2;
            }
            if (taskIndex == 3)
            {
                pictureBox2.Image = Properties.Resources.b3t3;
            }
            if (taskIndex == 4)
            {
                pictureBox2.Image = Properties.Resources.b3t4;
            }
            if (taskIndex == 5)
            {
                pictureBox2.Image = Properties.Resources.b3t5;
            }
            if (taskIndex == 6)
            {
                pictureBox2.Image = Properties.Resources.b3t6;
            }
            if (taskIndex == 7)
            {
                pictureBox2.Image = Properties.Resources.b3t7;
            }
            pictureBox2.Refresh();
            labelCounterIndex.Text = taskIndex.ToString() + " / 7";
            if (taskIndex == 8)
            {
                labelCounterIndex.Text = "7 / 7";
                bool good = true;
                if (errorCounter > 1)
                {
                    good = false;
                }
                FormAnswer fa = new FormAnswer(good);
                fa.StartPosition = FormStartPosition.CenterScreen;
                fa.ShowDialog();
                tasksForm.Show();
                Close();
                return;
            }
        }
    }
}
