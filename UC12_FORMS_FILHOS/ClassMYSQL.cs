using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UC12_FORMS_FILHOS
{
    internal class ClassMYSQL
    {
        public static string servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd";
        public static MySqlConnection conexao = new MySqlConnection(servidor);
        public static MySqlCommand comando = conexao.CreateCommand();
    }
}
