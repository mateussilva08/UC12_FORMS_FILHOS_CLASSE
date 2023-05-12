namespace UC12_FORMS_FILHOS
{
    partial class FormLOGIN
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
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxADM = new System.Windows.Forms.CheckBox();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(46, 64);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(139, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // CheckBoxADM
            // 
            this.CheckBoxADM.AutoSize = true;
            this.CheckBoxADM.Location = new System.Drawing.Point(72, 106);
            this.CheckBoxADM.Name = "CheckBoxADM";
            this.CheckBoxADM.Size = new System.Drawing.Size(89, 17);
            this.CheckBoxADM.TabIndex = 2;
            this.CheckBoxADM.Text = "Administrador";
            this.CheckBoxADM.UseVisualStyleBackColor = true;
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.Location = new System.Drawing.Point(83, 149);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(66, 22);
            this.buttonENTRAR.TabIndex = 3;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 261);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.CheckBoxADM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "FormLOGIN";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxADM;
        private System.Windows.Forms.Button buttonENTRAR;
    }
}