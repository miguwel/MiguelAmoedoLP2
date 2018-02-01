using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=Banco;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conec;

            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("1 - Acessar Contas");
            Console.WriteLine("2 - Area Restrita");
             
            op = Int32.Parse(Console.ReadLine());

            Cliente c = new Cliente();

            while(op == 1)
            {
                int id, senha;

                Console.WriteLine("Id Usuário: ");
                id = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Senha: ");
                senha = Int32.Parse(Console.ReadLine());

                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("Id", id);
                cmd.Parameters.AddWithValue("Senha", senha);
                
                cmd.CommandText = @"SELECT Id, Senha FROM Cliente WHERE Id = @Id AND Senha = @Senha;";
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Acesso Garantido");
                    op = 1;
                }

                else
                {
                    Console.WriteLine("Acesso Negado");
                    op = 0;
                }

                cmd.Parameters.RemoveAt("Id");
                cmd.Parameters.RemoveAt("Senha");

                cmd.Connection.Close();

                while(op != 0)
                {
                    Console.WriteLine("1 - Ver Saldo");
                    Console.WriteLine("2 - Realizar Trasferencias");
                    Console.WriteLine("3 - Acessar Extrato");
                    Console.WriteLine("0 - Sair");

                    op = Int32.Parse(Console.ReadLine());

                    if(op == 1)
                    {
                        int nConta;

                        Console.WriteLine("Número da Conta");
                        nConta = Int32.Parse(Console.ReadLine());

                        cmd.Connection.Open();

                        cmd.Parameters.AddWithValue("idUser", id);
                        cmd.Parameters.AddWithValue("nConta", nConta);

                        cmd.CommandText = @"SELECT Saldo FROM Conta WHERE Id = @nConta AND Id_cliente = @idUser;";
                        
                        SqlDataReader leitor = cmd.ExecuteReader();

                        if (leitor.HasRows)
                        {
                            while (leitor.Read())
                            {
                                float Saldo = leitor.GetFloat(0);

                                Console.WriteLine("R${0}", Saldo);
                            }
                        }

                        else
                            Console.WriteLine("Conta Inexistente");

                        cmd.Parameters.RemoveAt("idUser");
                        cmd.Parameters.RemoveAt("nConta");

                        cmd.Connection.Close();
                    }
                }
            }
        }
    }
}
