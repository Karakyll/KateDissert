namespace KatLab
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.mainLabelText = new System.Windows.Forms.Label();
            this.buttonBlock1 = new System.Windows.Forms.Button();
            this.buttonBlock3 = new System.Windows.Forms.Button();
            this.buttonBlock2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(189, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "об одежде и обуви для учащихся 4 классов";
            // 
            // mainLabelText
            // 
            this.mainLabelText.AutoSize = true;
            this.mainLabelText.Font = new System.Drawing.Font("Arial", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabelText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainLabelText.Location = new System.Drawing.Point(69, 91);
            this.mainLabelText.Name = "mainLabelText";
            this.mainLabelText.Size = new System.Drawing.Size(1044, 43);
            this.mainLabelText.TabIndex = 5;
            this.mainLabelText.Text = "Электронный тренажер по формированию представлений";
            // 
            // buttonBlock1
            // 
            this.buttonBlock1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlock1.Location = new System.Drawing.Point(12, 390);
            this.buttonBlock1.Name = "buttonBlock1";
            this.buttonBlock1.Size = new System.Drawing.Size(384, 139);
            this.buttonBlock1.TabIndex = 7;
            this.buttonBlock1.Text = "Сведения об ЭСО";
            this.buttonBlock1.UseVisualStyleBackColor = false;
            this.buttonBlock1.Click += new System.EventHandler(this.buttonBlock1_Click);
            // 
            // buttonBlock3
            // 
            this.buttonBlock3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBlock3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonBlock3.Location = new System.Drawing.Point(792, 390);
            this.buttonBlock3.Name = "buttonBlock3";
            this.buttonBlock3.Size = new System.Drawing.Size(384, 139);
            this.buttonBlock3.TabIndex = 8;
            this.buttonBlock3.Text = "??? что тут должно быть, Катя ???";
            this.buttonBlock3.UseVisualStyleBackColor = false;
            this.buttonBlock3.Click += new System.EventHandler(this.buttonBlock3_Click);
            // 
            // buttonBlock2
            // 
            this.buttonBlock2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlock2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBlock2.Location = new System.Drawing.Point(402, 390);
            this.buttonBlock2.Name = "buttonBlock2";
            this.buttonBlock2.Size = new System.Drawing.Size(384, 139);
            this.buttonBlock2.TabIndex = 9;
            this.buttonBlock2.Text = "Задания";
            this.buttonBlock2.UseVisualStyleBackColor = false;
            this.buttonBlock2.Click += new System.EventHandler(this.buttonBlock2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.buttonBlock1);
            this.Controls.Add(this.buttonBlock3);
            this.Controls.Add(this.buttonBlock2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainLabelText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 580);
            this.MinimumSize = new System.Drawing.Size(1203, 580);
            this.Name = "FormMain";
            this.Text = "Электронное средство обучения \"Повторяй-ка\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainLabelText;
        private System.Windows.Forms.Button buttonBlock1;
        private System.Windows.Forms.Button buttonBlock3;
        private System.Windows.Forms.Button buttonBlock2;
    }
}