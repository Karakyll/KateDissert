namespace KatLab
{
    partial class FormBlock2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlock2));
            this.buttonBlock2Back = new System.Windows.Forms.Button();
            this.labelBlock2Task = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.labelCounterIndex = new System.Windows.Forms.Label();
            this.buttonNextTask = new System.Windows.Forms.Button();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBlock2Back
            // 
            this.buttonBlock2Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlock2Back.Location = new System.Drawing.Point(1067, 12);
            this.buttonBlock2Back.Name = "buttonBlock2Back";
            this.buttonBlock2Back.Size = new System.Drawing.Size(108, 34);
            this.buttonBlock2Back.TabIndex = 1;
            this.buttonBlock2Back.Text = "Назад";
            this.buttonBlock2Back.UseVisualStyleBackColor = true;
            this.buttonBlock2Back.Click += new System.EventHandler(this.buttonBlock2Back_Click);
            // 
            // labelBlock2Task
            // 
            this.labelBlock2Task.AutoSize = true;
            this.labelBlock2Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlock2Task.Location = new System.Drawing.Point(12, 24);
            this.labelBlock2Task.Name = "labelBlock2Task";
            this.labelBlock2Task.Size = new System.Drawing.Size(369, 37);
            this.labelBlock2Task.TabIndex = 5;
            this.labelBlock2Task.Text = "Выбери лишний предмет:";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(921, 503);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(153, 24);
            this.labelCounter.TabIndex = 6;
            this.labelCounter.Text = "Номер задания:";
            // 
            // labelCounterIndex
            // 
            this.labelCounterIndex.AutoSize = true;
            this.labelCounterIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounterIndex.Location = new System.Drawing.Point(1080, 503);
            this.labelCounterIndex.Name = "labelCounterIndex";
            this.labelCounterIndex.Size = new System.Drawing.Size(20, 24);
            this.labelCounterIndex.TabIndex = 7;
            this.labelCounterIndex.Text = "1";
            // 
            // buttonNextTask
            // 
            this.buttonNextTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextTask.ForeColor = System.Drawing.Color.Blue;
            this.buttonNextTask.Location = new System.Drawing.Point(902, 341);
            this.buttonNextTask.Name = "buttonNextTask";
            this.buttonNextTask.Size = new System.Drawing.Size(205, 72);
            this.buttonNextTask.TabIndex = 9;
            this.buttonNextTask.Text = "Следующее задание";
            this.buttonNextTask.UseVisualStyleBackColor = true;
            this.buttonNextTask.Visible = false;
            this.buttonNextTask.Click += new System.EventHandler(this.buttonNextTask_Click);
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Image = global::KatLab.Properties.Resources.ok;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(846, 78);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(317, 220);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnswer.TabIndex = 8;
            this.pictureBoxAnswer.TabStop = false;
            this.pictureBoxAnswer.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::KatLab.Properties.Resources.b2t1p4True;
            this.pictureBox14.Location = new System.Drawing.Point(408, 301);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(390, 217);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 3;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            this.pictureBox14.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox14_Paint);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::KatLab.Properties.Resources.b2t1p3;
            this.pictureBox13.Location = new System.Drawing.Point(12, 301);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(390, 217);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            this.pictureBox13.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox13_Paint);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::KatLab.Properties.Resources.b2t1p2;
            this.pictureBox12.Location = new System.Drawing.Point(408, 78);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(390, 217);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            this.pictureBox12.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox12_Paint);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::KatLab.Properties.Resources.b2t1p1;
            this.pictureBox11.Location = new System.Drawing.Point(12, 78);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(390, 217);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            this.pictureBox11.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox11_Paint);
            // 
            // FormBlock2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.buttonNextTask);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBoxAnswer);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.labelCounterIndex);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelBlock2Task);
            this.Controls.Add(this.buttonBlock2Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 580);
            this.MinimumSize = new System.Drawing.Size(1203, 580);
            this.Name = "FormBlock2";
            this.Text = "Дидактическая игра \"Четвертый лишний\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBlock2_FormClosing);
            this.Load += new System.EventHandler(this.FormBlock2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlock2Back;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label labelBlock2Task;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label labelCounterIndex;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.Button buttonNextTask;
    }
}