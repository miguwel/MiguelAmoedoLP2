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
            string stg;
            int n, i;
            n = 0;
            Carro[] carro = new Carro[10000];
            i = 1;
            while(i != 0)
            {
                carro[n] = new Carro();
                Console.WriteLine("Insira os dados do Carro: ");
                
                Console.Write("Marca: ");
                carro[n].Marca = Console.ReadLine();

                Console.Write("Modelo: ");
                carro[n].Modelo = Console.ReadLine();

                Console.Write("Cor: ");
                carro[n].Cor = Console.ReadLine();

                Console.Write("Placa: ");
                carro[n].Placa = Console.ReadLine();

                Console.Write("Potencia: ");
                carro[n].Potencia = int.Parse(Console.ReadLine());

                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("1 - Inserir outro Carro");

                i = int.Parse(Console.ReadLine());
                n++;
            }

            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conec;
            conec.Open();

            for (i = 0; i < n; i++) 
            {
                cmd.Parameters.AddWithValue("Marca", carro[i].Marca);
                cmd.Parameters.AddWithValue("Modelo", carro[i].Modelo);
                cmd.Parameters.AddWithValue("Cor", carro[i].Cor);
                cmd.Parameters.AddWithValue("Placa", carro[i].Placa);
                cmd.Parameters.AddWithValue("Pot", carro[i].Potencia);

                stg = string.Format("INSERT INTO Carro(Marca , Modelo , Cor , Placa , Potencia) VALUES (@Marca, @Modelo, @Cor, @Placa, @Pot);");
                cmd.CommandText = stg;
                cmd.ExecuteNonQuery();

                cmd.Parameters.RemoveAt("Marca");
                cmd.Parameters.RemoveAt("Modelo");
                cmd.Parameters.RemoveAt("Cor");
                cmd.Parameters.RemoveAt("Placa");
                cmd.Parameters.RemoveAt("Pot");

            }
       
            conec.Close();

            Console.WriteLine("SAUCE, NO KETCHUP, JUST SAUCE");
        }
    }
}
