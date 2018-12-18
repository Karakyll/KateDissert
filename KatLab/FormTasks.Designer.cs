namespace KatLab
{
    partial class FormTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTasks));
            this.buttonBlock1 = new System.Windows.Forms.Button();
            this.buttonBlock3 = new System.Windows.Forms.Button();
            this.buttonBlock2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.mainLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBlock1
            // 
            this.buttonBlock1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlock1.Location = new System.Drawing.Point(96, 183);
            this.buttonBlock1.Name = "buttonBlock1";
            this.buttonBlock1.Size = new System.Drawing.Size(330, 100);
            this.buttonBlock1.TabIndex = 0;
            this.buttonBlock1.Text = "Блок 1";
            this.buttonBlock1.UseVisualStyleBackColor = false;
            this.buttonBlock1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBlock3
            // 
            this.buttonBlock3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBlock3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonBlock3.Location = new System.Drawing.Point(768, 183);
            this.buttonBlock3.Name = "buttonBlock3";
            this.buttonBlock3.Size = new System.Drawing.Size(330, 100);
            this.buttonBlock3.TabIndex = 1;
            this.buttonBlock3.Text = "Блок 3";
            this.buttonBlock3.UseVisualStyleBackColor = false;
            this.buttonBlock3.Click += new System.EventHandler(this.buttonBlock3_Click);
            // 
            // buttonBlock2
            // 
            this.buttonBlock2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBlock2.Location = new System.Drawing.Point(432, 183);
            this.buttonBlock2.Name = "buttonBlock2";
            this.buttonBlock2.Size = new System.Drawing.Size(330, 100);
            this.buttonBlock2.TabIndex = 2;
            this.buttonBlock2.Text = "Блок 2";
            this.buttonBlock2.UseVisualStyleBackColor = false;
            this.buttonBlock2.Click += new System.EventHandler(this.buttonBlock2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(910, 453);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(188, 49);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "В главное меню";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // mainLabelText
            // 
            this.mainLabelText.AutoSize = true;
            this.mainLabelText.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelText.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabelText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mainLabelText.Location = new System.Drawing.Point(87, 76);
            this.mainLabelText.Name = "mainLabelText";
            this.mainLabelText.Size = new System.Drawing.Size(515, 49);
            this.mainLabelText.TabIndex = 6;
            this.mainLabelText.Text = "Выберите блок заданий:";
            // 
            // FormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::KatLab.Properties.Resources.powerpoint_background_for_school_cortezcolorado_with_regard_to_powerpoint_backgrounds_school;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.mainLabelText);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonBlock1);
            this.Controls.Add(this.buttonBlock3);
            this.Controls.Add(this.buttonBlock2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 580);
            this.MinimumSize = new System.Drawing.Size(1203, 580);
            this.Name = "FormTasks";
            this.Text = "Электронный тренажер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTasks_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlock1;
        private System.Windows.Forms.Button buttonBlock3;
        private System.Windows.Forms.Button buttonBlock2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label mainLabelText;
    }
}

