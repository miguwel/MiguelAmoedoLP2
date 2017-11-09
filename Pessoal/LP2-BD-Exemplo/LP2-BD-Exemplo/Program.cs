using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_BD_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conec = new SqlConnection("Data Source=EN2LIA_14;Initial Catalog=Escola;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conec;
            cmd.CommandText = "INSERT INTO Alunos(id,Matricula,Nome) VALUES ('1','1','Jorj');";

            conec.Open();
            cmd.ExecuteNonQuery();
            conec.Close();

            Console.WriteLine("o.k.");
        }
    }
}
