namespace UC12_FORMS_FILHOS
{
    partial class FormUSUARIO
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
            this.textBoxCOMFIRMARSENHA = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.radioButtonADM = new System.Windows.Forms.RadioButton();
            this.radioButtonUSUARIO = new System.Windows.Forms.RadioButton();
            this.groupBoxPERMISSAO = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.groupBoxPERMISSAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(64, 52);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(175, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // textBoxCOMFIRMARSENHA
            // 
            this.textBoxCOMFIRMARSENHA.Location = new System.Drawing.Point(64, 197);
            this.textBoxCOMFIRMARSENHA.Name = "textBoxCOMFIRMARSENHA";
            this.textBoxCOMFIRMARSENHA.Size = new System.Drawing.Size(175, 20);
            this.textBoxCOMFIRMARSENHA.TabIndex = 2;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(64, 126);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(175, 20);
            this.textBoxSENHA.TabIndex = 3;
            // 
            // radioButtonADM
            // 
            this.radioButtonADM.AutoSize = true;
            this.radioButtonADM.Location = new System.Drawing.Point(6, 37);
            this.radioButtonADM.Name = "radioButtonADM";
            this.radioButtonADM.Size = new System.Drawing.Size(88, 17);
            this.radioButtonADM.TabIndex = 4;
            this.radioButtonADM.TabStop = true;
            this.radioButtonADM.Text = "Administrador";
            this.radioButtonADM.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSUARIO
            // 
            this.radioButtonUSUARIO.AutoSize = true;
            this.radioButtonUSUARIO.Location = new System.Drawing.Point(115, 37);
            this.radioButtonUSUARIO.Name = "radioButtonUSUARIO";
            this.radioButtonUSUARIO.Size = new System.Drawing.Size(61, 17);
            this.radioButtonUSUARIO.TabIndex = 5;
            this.radioButtonUSUARIO.TabStop = true;
            this.radioButtonUSUARIO.Text = "Usuário";
            this.radioButtonUSUARIO.UseVisualStyleBackColor = true;
            // 
            // groupBoxPERMISSAO
            // 
            this.groupBoxPERMISSAO.Controls.Add(this.radioButtonADM);
            this.groupBoxPERMISSAO.Controls.Add(this.radioButtonUSUARIO);
            this.groupBoxPERMISSAO.Location = new System.Drawing.Point(297, 52);
            this.groupBoxPERMISSAO.Name = "groupBoxPERMISSAO";
            this.groupBoxPERMISSAO.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPERMISSAO.TabIndex = 6;
            this.groupBoxPERMISSAO.TabStop = false;
            this.groupBoxPERMISSAO.Text = "Permissão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirme sua Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(239, 278);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 10;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // FormUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPERMISSAO);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxCOMFIRMARSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "FormUSUARIO";
            this.Text = "FormUSUARIO";
            this.groupBoxPERMISSAO.ResumeLayout(false);
            this.groupBoxPERMISSAO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxCOMFIRMARSENHA;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.RadioButton radioButtonADM;
        private System.Windows.Forms.RadioButton radioButtonUSUARIO;
        private System.Windows.Forms.GroupBox groupBoxPERMISSAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}