using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_FORMS_FILHOS
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            ClassVARIAVEIS.usuario = textBoxUSUARIO.Text;

            if (CheckBoxADM.Checked)
            {
                ClassVARIAVEIS.permissao = "admin";
            }
            else
            {
                ClassVARIAVEIS.usuario = "user";
            }
            Form telaPRINCIPAL = new FormPRINCIPAL();
            telaPRINCIPAL.Show();
        }
    }
}
