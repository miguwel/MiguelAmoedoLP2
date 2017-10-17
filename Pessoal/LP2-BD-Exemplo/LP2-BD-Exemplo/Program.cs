using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_BD_Exemplo
{
    class Program,

    {
        static void Main(string[] args)
        {
            MySqlConnection conec = new MySqlConnection("Server=localhost;Database=casa;Uid=root;Pwd=");

            conec.Open();
            // Interagir com o Banco de Dados;
            conec.Close();
        }
    }
}
