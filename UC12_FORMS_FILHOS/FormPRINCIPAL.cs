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
    public partial class FormPRINCIPAL : Form
    {

        public FormPRINCIPAL()
        {
            InitializeComponent();
            ValidaPermissao();

           // MessageBox.Show(ClassVARIAVEIS.usuario);
        }
        private void ValidaPermissao()
        {
            if (ClassVARIAVEIS.permissao == "admin")
            {
                cadastroToolStripMenuItem.Visible = true;
            }
            else
            {
                cadastroToolStripMenuItem.Visible = false;
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form telaCADASTRO = new FormCADASTRO();
            
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.Show();
            telaCADASTRO.WindowState = FormWindowState.Maximized;

            Form telaUSUARIO = new FormUSUARIO();

            telaUSUARIO.MdiParent = this;
            telaUSUARIO.Show();
            telaUSUARIO.WindowState = FormWindowState.Maximized;


        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaRELATORIO = new FormRELATORIO();
            telaRELATORIO.MdiParent = this;
            telaRELATORIO.Show();
            telaRELATORIO.WindowState = FormWindowState.Maximized;

        }

        private void FormPRINCIPAL_Load(object sender, EventArgs e)
        {

        }
    }
}
