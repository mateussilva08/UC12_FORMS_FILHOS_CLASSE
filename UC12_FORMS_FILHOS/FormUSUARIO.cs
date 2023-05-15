using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_FORMS_FILHOS
{
    public partial class FormUSUARIO : Form
    {
        public FormUSUARIO()
        {
            InitializeComponent();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {

            try
            {
               
                string admin = "";
                if (radioButtonADM.Checked)
                {
                    admin = "admin";
                }
                if (radioButtonUSUARIO.Checked)
                {
                    admin = "usuario";
                }

                if (textBoxUSUARIO.Text != "" && textBoxSENHA.Text != "" && textBoxCOMFIRMARSENHA.Text != "" && admin != "")
                {


                    ClassMYSQL.conexao.Open();
                    ClassMYSQL.comando.CommandText = "INSERT INTO tbl_usuarios (permissao, usuario, senha) VALUES ('" + admin + "', '" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');";

                    

                    if (textBoxSENHA.Text == textBoxCOMFIRMARSENHA.Text)
                    {
                        if (textBoxSENHA.Text.Length >= 8)
                        {
                            MySqlDataReader readaerLOGIN = ClassMYSQL.comando.ExecuteReader();
                        }
                        else
                        {
                            MessageBox.Show("Minimo de 8 caracteres");
                        }
                       
                       
                    }

                    else
                    {
                        MessageBox.Show("As senhas precisam ser iguais");
                    }
                   

                }
                else
                {
                    MessageBox.Show("Campos em branco");
                }
               
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Campos em branco");
            }
            finally
            {
                ClassMYSQL.conexao.Close();
            }

        }
    }
}








