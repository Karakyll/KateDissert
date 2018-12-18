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
    public partial class FormBlock1 : Form
    {
        private FormTasks tasksForm;
        private int taskIndex = 1;
        private int errorsCount = 0;
        private String[] tasks =
        {
            "Выбери картинки с изображением одежды, которая нуждается в стирке:",
            "Выбери картинки с изображением одежды, где она правильно сложена:",
            "Выбери одежду, в которой есть молния:",
            "Выбери одежду, где есть пуговицы:",
            "Выбери всю верхнюю одежду:",
            "Выбери картинки с изображением обуви:",
            "Выбери женскую одежду:",
            "Выбери мужскую одежду:",
            "Выбери детскую одежду:",
            "Выбери картинки с изображением шерстяной одежды:",
            "Покажи картинки, на которых ты видишь платья:",
            "Покажи картинки, на которых ты видишь сапоги:",
            "Выбери женскую обувь:",
            "Выбери мужскую обувь:",
            "Выбери одежду, которую мы носим летом:",
            "Выбери одежду, которую мы носим зимой:",
            "Выбери одежду, которую мы носим весной:",
            "Выбери одежду, которую мы носим осенью:",
            "Выбери картинки тех изображений, которые можно обуть:",
            "Выбери то, что можно надеть:"
        };

        public FormBlock1(FormTasks tasksForm)
        {
            this.tasksForm = tasksForm;
            InitializeComponent();
        }

        private void FormBlock1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tasksForm.Show();
        }

        private void buttonBlock1Back_Click(object sender, EventArgs e)
        {
            tasksForm.Show();
            Close();
        }

        private void FormBlock1_Load(object sender, EventArgs e)
        {
            pictureBox1.Tag = Color.Transparent;
            pictureBox2.Tag = Color.Transparent;
            pictureBox3.Tag = Color.Transparent;
            pictureBox4.Tag = Color.Transparent;
            labelCounterIndex.Text = taskIndex.ToString() + " / 20";
            labelBlock1Task.Text = tasks[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (taskIndex == 1 ||
                taskIndex == 4 ||
                taskIndex == 6 ||
                taskIndex == 8 ||
                taskIndex == 12 ||
                taskIndex == 13 ||
                taskIndex == 17 ||
                taskIndex == 16 ||
                taskIndex == 19)
            {
                pictureBox1.Tag = Color.Lime;
                pictureBox1.Refresh();
            }
            else
            {
                pictureBox1.Tag = Color.Red;
                pictureBox1.Refresh();
                errorsCount++;
            }
            checkAnswers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (taskIndex == 2 ||
                taskIndex == 3 ||
                taskIndex == 4 ||
                taskIndex == 5 ||
                taskIndex == 7 ||
                taskIndex == 8 ||
                taskIndex == 10 ||
                taskIndex == 14 ||
                taskIndex == 15 ||
                taskIndex == 17 ||
                taskIndex == 18)
            {
                pictureBox2.Tag = Color.Lime;
                pictureBox2.Refresh();
            }
            else
            {
                pictureBox2.Tag = Color.Red;
                pictureBox2.Refresh();
                errorsCount++;
            }
            checkAnswers();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (taskIndex == 1 ||
                taskIndex == 2 ||
                taskIndex == 3 ||
                taskIndex == 7 ||
                taskIndex == 9 ||
                taskIndex == 10 ||
                taskIndex == 11 ||
                taskIndex == 12 ||
                taskIndex == 14 ||
                taskIndex == 15 ||
                taskIndex == 16 ||
                taskIndex == 18 ||
                taskIndex == 20)
            {
                pictureBox3.Tag = Color.Lime;
                pictureBox3.Refresh();
            }
            else
            {
                pictureBox3.Tag = Color.Red;
                pictureBox3.Refresh();
                errorsCount++;
            }
            checkAnswers();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (taskIndex == 3 ||
                taskIndex == 5 ||
                taskIndex == 6 ||
                taskIndex == 9 ||
                taskIndex == 11 ||
                taskIndex == 12 ||
                taskIndex == 13 ||
                taskIndex == 15 ||
                taskIndex == 16 ||
                taskIndex == 17 ||
                taskIndex == 18 ||
                taskIndex == 19 ||
                taskIndex == 20)
            {
                pictureBox4.Tag = Color.Lime;
                pictureBox4.Refresh();
            }
            else
            {
                pictureBox4.Tag = Color.Red;
                pictureBox4.Refresh();
                errorsCount++;
            }
            checkAnswers();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, (Color)pictureBox1.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox2.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox2.ClientRectangle, (Color)pictureBox2.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox3.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox3.ClientRectangle, (Color)pictureBox3.Tag, ButtonBorderStyle.Solid);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox4.Tag == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, pictureBox4.ClientRectangle, (Color)pictureBox4.Tag, ButtonBorderStyle.Solid);
        }

        private void checkAnswers()
        {
            switch (taskIndex)
            {
                case 1:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 2:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 3:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 4:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox2.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 5:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 6:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 7:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 8:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox2.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 9:
                    if ((Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 10:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 11:
                    if ((Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 12:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 13:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 14:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 15:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 16:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 17:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 18:
                    if ((Color)pictureBox2.Tag == Color.Lime && (Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 19:
                    if ((Color)pictureBox1.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
                case 20:
                    if ((Color)pictureBox3.Tag == Color.Lime && (Color)pictureBox4.Tag == Color.Lime)
                    {
                        buttonNextTask.Text = "Закончить упражнение";
                        pictureBoxAnswer.Visible = true;
                        buttonNextTask.Visible = true;
                    }
                    break;
            }
        }

        private void buttonNextTask_Click(object sender, EventArgs e)
        {
            if (taskIndex == 20)
            {
                bool good = true;
                if (errorsCount > 4)
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
            pictureBoxAnswer.Visible = false;
            buttonNextTask.Visible = false;
            taskIndex++;
            labelCounterIndex.Text = taskIndex.ToString() + " / 20";
            labelBlock1Task.Text = tasks[taskIndex - 1];
            rerenderBlock();
        }

        private void rerenderBlock()
        {
            if (taskIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.b1t1p1True;
                pictureBox2.Image = Properties.Resources.b1t1p2;
                pictureBox3.Image = Properties.Resources.b1t1p3True;
                pictureBox4.Image = Properties.Resources.b1t1p4;
            }
            if (taskIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.b1t2p1;
                pictureBox2.Image = Properties.Resources.b1t2p2True;
                pictureBox3.Image = Properties.Resources.b1t2p3True;
                pictureBox4.Image = Properties.Resources.b1t2p4;
            }
            if (taskIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.b1t3p1;
                pictureBox2.Image = Properties.Resources.b1t3p2True;
                pictureBox3.Image = Properties.Resources.b1t3p3True;
                pictureBox4.Image = Properties.Resources.b1t3p4True;
            }
            if (taskIndex == 4)
            {
                pictureBox1.Image = Properties.Resources.b1t4p1True;
                pictureBox2.Image = Properties.Resources.b1t4p2True;
                pictureBox3.Image = Properties.Resources.b1t4p3;
                pictureBox4.Image = Properties.Resources.b1t4p4;
            }
            if (taskIndex == 5)
            {
                pictureBox1.Image = Properties.Resources.b1t5p1;
                pictureBox2.Image = Properties.Resources.b1t5p2True;
                pictureBox3.Image = Properties.Resources.b1t5p3;
                pictureBox4.Image = Properties.Resources.b1t5p4True;
            }
            if (taskIndex == 6)
            {
                pictureBox1.Image = Properties.Resources.b1t6p1True;
                pictureBox2.Image = Properties.Resources.b1t6p2;
                pictureBox3.Image = Properties.Resources.b1t6p3;
                pictureBox4.Image = Properties.Resources.b1t6p4True;
            }
            if (taskIndex == 7)
            {
                pictureBox1.Image = Properties.Resources.b1t7p1;
                pictureBox2.Image = Properties.Resources.b1t7p2True;
                pictureBox3.Image = Properties.Resources.b1t7p3True;
                pictureBox4.Image = Properties.Resources.b1t7p4;
            }
            if (taskIndex == 8)
            {
                pictureBox1.Image = Properties.Resources.b1t8p1True;
                pictureBox2.Image = Properties.Resources.b1t8p2True;
                pictureBox3.Image = Properties.Resources.b1t8p3;
                pictureBox4.Image = Properties.Resources.b1t8p4;
            }
            if (taskIndex == 9)
            {
                pictureBox1.Image = Properties.Resources.b1t9p1;
                pictureBox2.Image = Properties.Resources.b1t9p2;
                pictureBox3.Image = Properties.Resources.b1t9p3True;
                pictureBox4.Image = Properties.Resources.b1t9p4True;
            }
            if (taskIndex == 10)
            {
                pictureBox1.Image = Properties.Resources.b1t10p1;
                pictureBox2.Image = Properties.Resources.b1t10p2True;
                pictureBox3.Image = Properties.Resources.b1t10p3True;
                pictureBox4.Image = Properties.Resources.b1t10p4;
            }
            if (taskIndex == 11)
            {
                pictureBox1.Image = Properties.Resources.b1t11p1;
                pictureBox2.Image = Properties.Resources.b1t11p2;
                pictureBox3.Image = Properties.Resources.b1t11p3True;
                pictureBox4.Image = Properties.Resources.b1t11p4True;
            }
            if (taskIndex == 12)
            {
                pictureBox1.Image = Properties.Resources.b1t12p1True;
                pictureBox2.Image = Properties.Resources.b1t12p2;
                pictureBox3.Image = Properties.Resources.b1t12p3True;
                pictureBox4.Image = Properties.Resources.b1t12p4True;
            }
            if (taskIndex == 13)
            {
                pictureBox1.Image = Properties.Resources.b1t13p1True;
                pictureBox2.Image = Properties.Resources.b1t13p2;
                pictureBox3.Image = Properties.Resources.b1t13p3;
                pictureBox4.Image = Properties.Resources.b1t13p4True;
            }
            if (taskIndex == 14)
            {
                pictureBox1.Image = Properties.Resources.b1t14p1;
                pictureBox2.Image = Properties.Resources.b1t14p2True;
                pictureBox3.Image = Properties.Resources.b1t14p3True;
                pictureBox4.Image = Properties.Resources.b1t14p4;
            }
            if (taskIndex == 15)
            {
                pictureBox1.Image = Properties.Resources.b1t15p1;
                pictureBox2.Image = Properties.Resources.b1t15p2True;
                pictureBox3.Image = Properties.Resources.b1t15p3True;
                pictureBox4.Image = Properties.Resources.b1t15p4True;
            }
            if (taskIndex == 16)
            {
                pictureBox1.Image = Properties.Resources.b1t16p1True;
                pictureBox2.Image = Properties.Resources.b1t16p2;
                pictureBox3.Image = Properties.Resources.b1t16p3True;
                pictureBox4.Image = Properties.Resources.b1t16p4True;
            }
            if (taskIndex == 17)
            {
                pictureBox1.Image = Properties.Resources.b1t17p1True;
                pictureBox2.Image = Properties.Resources.b1t17p2True;
                pictureBox3.Image = Properties.Resources.b1t17p3;
                pictureBox4.Image = Properties.Resources.b1t17p4True;
            }
            if (taskIndex == 18)
            {
                pictureBox1.Image = Properties.Resources.b1t18p1;
                pictureBox2.Image = Properties.Resources.b1t18p2True;
                pictureBox3.Image = Properties.Resources.b1t18p3True;
                pictureBox4.Image = Properties.Resources.b1t18p4True;
            }
            if (taskIndex == 19)
            {
                pictureBox1.Image = Properties.Resources.b1t19p1True;
                pictureBox2.Image = Properties.Resources.b1t19p2;
                pictureBox3.Image = Properties.Resources.b1t19p3;
                pictureBox4.Image = Properties.Resources.b1t19p4True;
            }
            if (taskIndex == 20)
            {
                pictureBox1.Image = Properties.Resources.b1t20p1;
                pictureBox2.Image = Properties.Resources.b1t20p2;
                pictureBox3.Image = Properties.Resources.b1t20p3True;
                pictureBox4.Image = Properties.Resources.b1t20p4True;
            }
            pictureBox1.Tag = Color.Transparent;
            pictureBox2.Tag = Color.Transparent;
            pictureBox3.Tag = Color.Transparent;
            pictureBox4.Tag = Color.Transparent;
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
        }
    }
}
