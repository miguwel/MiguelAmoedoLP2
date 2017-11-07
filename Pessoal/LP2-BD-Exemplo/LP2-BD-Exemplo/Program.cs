using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_BD_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conec = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=");
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conec;
            cmd.CommandText = "INSERT INTO Aluno(nome) VALUES ('ok');";

            conec.Open();
            cmd.ExecuteNonQuery();
            conec.Close();

            Console.WriteLine("o.k.");
        }
    }
}
