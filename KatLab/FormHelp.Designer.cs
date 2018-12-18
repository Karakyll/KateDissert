namespace KatLab
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.buttonBlockHelpBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBlockHelpBack
            // 
            this.buttonBlockHelpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlockHelpBack.Location = new System.Drawing.Point(1007, 475);
            this.buttonBlockHelpBack.Name = "buttonBlockHelpBack";
            this.buttonBlockHelpBack.Size = new System.Drawing.Size(108, 34);
            this.buttonBlockHelpBack.TabIndex = 3;
            this.buttonBlockHelpBack.Text = "Назад";
            this.buttonBlockHelpBack.UseVisualStyleBackColor = true;
            this.buttonBlockHelpBack.Click += new System.EventHandler(this.buttonBlockHelpBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(149, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(902, 341);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::KatLab.Properties.Resources.powerpoint_background_for_school_cortezcolorado_with_regard_to_powerpoint_backgrounds_school;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBlockHelpBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1203, 580);
            this.MinimumSize = new System.Drawing.Size(1203, 580);
            this.Name = "FormHelp";
            this.Text = "Сведения об ЭСО";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHelp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlockHelpBack;
        private System.Windows.Forms.Label label1;
    }
}