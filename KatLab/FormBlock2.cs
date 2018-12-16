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
    public partial class FormBlock2 : Form
    {
        private FormTasks tasksForm;
        private int taskIndex = 1;
        private int errorsCount = 0;
        public FormBlock2(FormTasks tasksForm)
        {
            this.tasksForm = tasksForm;
            InitializeComponent();
        }

        private void FormBlock2_Load(object sender, EventArgs e)
        {
            labelCounterIndex.Text = taskIndex.ToString() + " / 10";
        }

        private void FormBlock2_FormClosing(object sender, FormClosingEventArgs e)
        {
            tasksForm.Show();
        }

        private void buttonBlock2Back_Click(object sender, EventArgs e)
        {
            tasksForm.Show();
            Close();
        }

        private void pictureBox11_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox11.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox11.ClientRectangle, (Color)pictureBox11.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox12_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox12.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox12.ClientRectangle, (Color)pictureBox12.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox13_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox13.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox13.ClientRectangle, (Color)pictureBox13.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox14_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox14.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox14.ClientRectangle, (Color)pictureBox14.Tag, ButtonBorderStyle.Solid);
        }

        // ------------------------- Click handlers ----------------------------

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (taskIndex == 2 || taskIndex == 7 || taskIndex == 9)
            {
                pictureBox11.Tag = Color.Lime;
                pictureBox11.Refresh();
                pictureBoxAnswer.Visible = true;
                buttonNextTask.Visible = true;
            } else
            {
                pictureBox11.Tag = Color.Red;
                pictureBox11.Refresh();
                errorsCount++;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (taskIndex == 3 || taskIndex == 4 || taskIndex == 5)
            {
                pictureBox12.Tag = Color.Lime;
                pictureBox12.Refresh();
                pictureBoxAnswer.Visible = true;
                buttonNextTask.Visible = true;
            }
            else
            {
                pictureBox12.Tag = Color.Red;
                pictureBox12.Refresh();
                errorsCount++;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (taskIndex == 8)
            {
                pictureBox13.Tag = Color.Lime;
                pictureBox13.Refresh();
                pictureBoxAnswer.Visible = true;
                buttonNextTask.Visible = true;
            } else
            {
                pictureBox13.Tag = Color.Red;
                pictureBox13.Refresh();
                errorsCount++;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (taskIndex == 1 || taskIndex == 6 || taskIndex == 10)
            {
                pictureBox14.Tag = Color.Lime;
                pictureBox14.Refresh();
                pictureBoxAnswer.Visible = true;
                buttonNextTask.Visible = true;
            } else
            {
                pictureBox14.Tag = Color.Red;
                pictureBox14.Refresh();
                errorsCount++;
            }
        }

        private void buttonNextTask_Click(object sender, EventArgs e)
        {
            if (taskIndex == 10)
            {
                bool good = true;
                if (errorsCount > 2)
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
            taskIndex++;
            labelCounterIndex.Text = taskIndex.ToString() + " / 10";
            if (taskIndex == 10)
            {
                buttonNextTask.Text = "Закончить упражнение";
            }
            pictureBoxAnswer.Visible = false;
            buttonNextTask.Visible = false;
            rerenderBlock();
        }

        private void rerenderBlock()
        {
            if (taskIndex == 1)
            {
                pictureBox11.Image = Properties.Resources.b2t1p1;
                pictureBox12.Image = Properties.Resources.b2t1p2;
                pictureBox13.Image = Properties.Resources.b2t1p3;
                pictureBox14.Image = Properties.Resources.b2t1p4True;
            }
            if (taskIndex == 2)
            {
                pictureBox11.Image = Properties.Resources.b2t2p1True;
                pictureBox12.Image = Properties.Resources.b2t2p2;
                pictureBox13.Image = Properties.Resources.b2t2p3;
                pictureBox14.Image = Properties.Resources.b2t2p4;
            }
            if (taskIndex == 3)
            {
                pictureBox11.Image = Properties.Resources.b2t3p1;
                pictureBox12.Image = Properties.Resources.b2t3p2True;
                pictureBox13.Image = Properties.Resources.b2t3p3;
                pictureBox14.Image = Properties.Resources.b2t3p4;
            }
            if (taskIndex == 4)
            {
                pictureBox11.Image = Properties.Resources.b2t4p1;
                pictureBox12.Image = Properties.Resources.b2t4p2True;
                pictureBox13.Image = Properties.Resources.b2t4p3;
                pictureBox14.Image = Properties.Resources.b2t4p4;
            }
            if (taskIndex == 5)
            {
                pictureBox11.Image = Properties.Resources.b2t5p1;
                pictureBox12.Image = Properties.Resources.b2t5p2True;
                pictureBox13.Image = Properties.Resources.b2t5p3;
                pictureBox14.Image = Properties.Resources.b2t5p4;
            }
            if (taskIndex == 6)
            {
                pictureBox11.Image = Properties.Resources.b2t6p1;
                pictureBox12.Image = Properties.Resources.b2t6p2;
                pictureBox13.Image = Properties.Resources.b2t6p3;
                pictureBox14.Image = Properties.Resources.b2t6p4True;
            }
            if (taskIndex == 7)
            {
                pictureBox11.Image = Properties.Resources.b2t7p1True;
                pictureBox12.Image = Properties.Resources.b2t7p2;
                pictureBox13.Image = Properties.Resources.b2t7p3;
                pictureBox14.Image = Properties.Resources.b2t7p4;
            }
            if (taskIndex == 8)
            {
                pictureBox11.Image = Properties.Resources.b2t8p1;
                pictureBox12.Image = Properties.Resources.b2t8p2;
                pictureBox13.Image = Properties.Resources.b2t8p3True;
                pictureBox14.Image = Properties.Resources.b2t8p4;
            }
            if (taskIndex == 9)
            {
                pictureBox11.Image = Properties.Resources.b2t9p1True;
                pictureBox12.Image = Properties.Resources.b2t9p2;
                pictureBox13.Image = Properties.Resources.b2t9p3;
                pictureBox14.Image = Properties.Resources.b2t9p4;
            }
            if (taskIndex == 10)
            {
                pictureBox11.Image = Properties.Resources.b2t10p1;
                pictureBox12.Image = Properties.Resources.b2t10p2;
                pictureBox13.Image = Properties.Resources.b2t10p3;
                pictureBox14.Image = Properties.Resources.b2t10p4True;
            }
            pictureBox11.Tag = Color.Transparent;
            pictureBox12.Tag = Color.Transparent;
            pictureBox13.Tag = Color.Transparent;
            pictureBox14.Tag = Color.Transparent;
            pictureBox11.Refresh();
            pictureBox12.Refresh();
            pictureBox13.Refresh();
            pictureBox14.Refresh();
        }
    }
}
