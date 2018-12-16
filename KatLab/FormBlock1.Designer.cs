namespace KatLab
{
    partial class FormBlock1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlock1));
            this.buttonBlock1Back = new System.Windows.Forms.Button();
            this.buttonNextTask = new System.Windows.Forms.Button();
            this.labelCounterIndex = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.labelBlock1Task = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBlock1Back
            // 
            this.buttonBlock1Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlock1Back.Location = new System.Drawing.Point(1067, 12);
            this.buttonBlock1Back.Name = "buttonBlock1Back";
            this.buttonBlock1Back.Size = new System.Drawing.Size(108, 34);
            this.buttonBlock1Back.TabIndex = 0;
            this.buttonBlock1Back.Text = "Назад";
            this.buttonBlock1Back.UseVisualStyleBackColor = true;
            this.buttonBlock1Back.Click += new System.EventHandler(this.buttonBlock1Back_Click);
            // 
            // buttonNextTask
            // 
            this.buttonNextTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextTask.ForeColor = System.Drawing.Color.Blue;
            this.buttonNextTask.Location = new System.Drawing.Point(902, 342);
            this.buttonNextTask.Name = "buttonNextTask";
            this.buttonNextTask.Size = new System.Drawing.Size(205, 72);
            this.buttonNextTask.TabIndex = 17;
            this.buttonNextTask.Text = "Следующее задание";
            this.buttonNextTask.UseVisualStyleBackColor = true;
            this.buttonNextTask.Visible = false;
            this.buttonNextTask.Click += new System.EventHandler(this.buttonNextTask_Click);
            // 
            // labelCounterIndex
            // 
            this.labelCounterIndex.AutoSize = true;
            this.labelCounterIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounterIndex.Location = new System.Drawing.Point(1080, 504);
            this.labelCounterIndex.Name = "labelCounterIndex";
            this.labelCounterIndex.Size = new System.Drawing.Size(20, 24);
            this.labelCounterIndex.TabIndex = 15;
            this.labelCounterIndex.Text = "1";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(921, 504);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(153, 24);
            this.labelCounter.TabIndex = 14;
            this.labelCounter.Text = "Номер задания:";
            // 
            // labelBlock1Task
            // 
            this.labelBlock1Task.AutoSize = true;
            this.labelBlock1Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlock1Task.Location = new System.Drawing.Point(12, 27);
            this.labelBlock1Task.Name = "labelBlock1Task";
            this.labelBlock1Task.Size = new System.Drawing.Size(1046, 37);
            this.labelBlock1Task.TabIndex = 18;
            this.labelBlock1Task.Text = "Отбери картинки с изображением одежды, которая нуждается в стирке";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KatLab.Properties.Resources.b1t1p4;
            this.pictureBox4.Location = new System.Drawing.Point(408, 302);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(390, 217);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KatLab.Properties.Resources.b1t1p3True;
            this.pictureBox3.Location = new System.Drawing.Point(12, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(390, 217);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Image = global::KatLab.Properties.Resources.ok;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(846, 79);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(317, 220);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnswer.TabIndex = 16;
            this.pictureBoxAnswer.TabStop = false;
            this.pictureBoxAnswer.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KatLab.Properties.Resources.b1t1p2;
            this.pictureBox2.Location = new System.Drawing.Point(408, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KatLab.Properties.Resources.b1t1p1True;
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // FormBlock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.labelBlock1Task);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonNextTask);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxAnswer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCounterIndex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.buttonBlock1Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 580);
            this.MinimumSize = new System.Drawing.Size(1203, 580);
            this.Name = "FormBlock1";
            this.Text = "Практикум";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBlock1_FormClosing);
            this.Load += new System.EventHandler(this.FormBlock1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlock1Back;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonNextTask;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxAnswer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCounterIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label labelBlock1Task;
    }
}