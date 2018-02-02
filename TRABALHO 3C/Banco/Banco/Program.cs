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
            int confirm;
            int op = 1;
            int erro = 0;
            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=Banco;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conec;

            while (op != 3)
            {
                Console.WriteLine("-------------------Bem Vindo!-------------------------------------------------------------------------------------------");
                Console.WriteLine("\n1 - Acessar Contas");
                Console.WriteLine("2 - Area Restrita");
                Console.WriteLine("3 - Sair\n");

                op = Int32.Parse(Console.ReadLine());

                Cliente c = new Cliente();

                while (op == 1)
                {

                    Console.Write("\nId Usuário: ");
                    c.Id = Int32.Parse(Console.ReadLine());

                    Console.Write("\nSenha: ");


                    cmd.Connection.Open();

                    cmd.Parameters.AddWithValue("Id", c.Id);
                    cmd.Parameters.AddWithValue("Senha", c.Senha = Int32.Parse(Console.ReadLine()));

                    cmd.CommandText = @"SELECT Id, Senha FROM Cliente WHERE Id = @Id AND Senha = @Senha;";

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("\n---------------Acesso Garantido-----------------------------------------------------------------------------------------");
                        op = 1;
                        c.Id = c.Id;
                    }

                    else
                    {
                        Console.WriteLine("\n----------------Acesso Negado-------------------------------------------------------------------------------------------");
                        op = 0;
                    }

                    cmd.Parameters.RemoveAt("Id");
                    cmd.Parameters.RemoveAt("Senha");

                    cmd.Connection.Close();

                    while (op != 0)
                    {
                        Console.WriteLine("\n1 - Ver Saldo");
                        Console.WriteLine("2 - Realizar Trasferencias");
                        Console.WriteLine("0 - Sair\n");

                        op = Int32.Parse(Console.ReadLine());

                        if (op == 1)
                        {
                            Console.Write("\nNúmero da Conta: ");
                            c.nConta = Int32.Parse(Console.ReadLine());

                            cmd.Connection.Open();

                            cmd.Parameters.AddWithValue("idUser", c.Id);
                            cmd.Parameters.AddWithValue("nConta", c.nConta);

                            cmd.CommandText = @"SELECT Saldo FROM Conta WHERE Id = @nConta AND Id_cliente = @idUser;";

                            SqlDataReader leitor = cmd.ExecuteReader();

                            if (leitor.HasRows)
                            {
                                while (leitor.Read())
                                {
                                    double Saldo = leitor.GetInt32(0);

                                    Console.WriteLine("\nSeu saldo atual é de: R${0}", Saldo);
                                }
                            }

                            else
                                Console.WriteLine("\n---------------Conta Inexistente ou Não é sua---------------------------------------------------------------------------");

                            cmd.Parameters.RemoveAt("idUser");
                            cmd.Parameters.RemoveAt("nConta");

                            cmd.Connection.Close();
                        }

                        if (op == 2)
                        {
                            double SaldoUsuario = 0;
                            double SaldoDestinatario = 0;

                            Console.Write("\nNúmero de Sua Conta: ");
                            c.nConta = Int32.Parse(Console.ReadLine());
                            cmd.Connection.Open();

                            cmd.Parameters.AddWithValue("idUser", c.Id);
                            cmd.Parameters.AddWithValue("nConta", c.nConta);

                            cmd.CommandText = @"SELECT Saldo FROM Conta WHERE Id = @nConta AND Id_cliente = @idUser;";

                            SqlDataReader leitor = cmd.ExecuteReader();

                            if (leitor.HasRows)
                            {
                                while (leitor.Read())
                                {
                                    SaldoUsuario = leitor.GetInt32(0);
                                }
                            }

                            else
                            {
                                Console.WriteLine("\n---------------Conta Inexistente ou Não é sua---------------------------------------------------------------------------");
                                erro = 1;
                            }

                            cmd.Parameters.RemoveAt("idUser");
                            cmd.Parameters.RemoveAt("nConta");

                            cmd.Connection.Close();

                            if (erro != 1)
                            {
                                Console.Write("\nNúmero da Conta que deseja transferir o dinheiro: ");
                                int ContaDest = Int32.Parse(Console.ReadLine());

                                Console.Write("\nInforme a quantia de dinheiro, em reais: ");
                                int qtd = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("\n Deseja confirmar a transação da conta: {0}; \n Para a conta: {1}; \n No valor de R${2}? se sim digite '1'\n", c.nConta, ContaDest, qtd);
                                confirm = Int32.Parse(Console.ReadLine());
                                if (confirm == 1)
                                {
                                    cmd.Connection.Open();
                                    cmd.Parameters.AddWithValue("nConta", ContaDest);

                                    cmd.CommandText = @"SELECT Saldo FROM Conta WHERE Id = @nConta";

                                    leitor = cmd.ExecuteReader();

                                    if (leitor.HasRows)
                                    {
                                        while (leitor.Read())
                                        {
                                            SaldoDestinatario = leitor.GetInt32(0);
                                        }
                                    }

                                    cmd.Parameters.RemoveAt("nConta");

                                    cmd.Connection.Close();

                                    SaldoUsuario = SaldoUsuario - qtd;
                                    SaldoDestinatario = SaldoDestinatario + qtd;

                                    Console.WriteLine("\n---------------TRANSAÇÃO COMPLETA-----------------Seu saldo atual é de: R${0}-------------------------------------------", SaldoUsuario);

                                    cmd.Connection.Open();

                                    cmd.Parameters.AddWithValue("Saldo", SaldoUsuario);
                                    cmd.Parameters.AddWithValue("nConta", c.nConta);

                                    cmd.CommandText = @"UPDATE Conta
                                                        SET Saldo = @Saldo
                                                        WHERE id = @nConta;";

                                    cmd.ExecuteNonQuery();

                                    cmd.Parameters.RemoveAt("nConta");
                                    cmd.Parameters.RemoveAt("Saldo");

                                    cmd.Connection.Close();

                                    cmd.Connection.Open();

                                    cmd.Parameters.AddWithValue("Saldo", SaldoDestinatario);
                                    cmd.Parameters.AddWithValue("nConta", ContaDest);

                                    cmd.CommandText = @"UPDATE Conta
                                                        SET Saldo = @Saldo
                                                        WHERE id = @nConta;";

                                    cmd.ExecuteNonQuery();

                                    cmd.Parameters.RemoveAt("nConta");
                                    cmd.Parameters.RemoveAt("Saldo");

                                    cmd.Connection.Close();
                                }
                            }
                        }
                    }
                }

                while (op == 2)
                {
                    Console.Write("\nNumero da Agencia: ");
                    int nAgencia = Int32.Parse(Console.ReadLine());

                    Console.Write("\nSenha: ");
                    int senha = Int32.Parse(Console.ReadLine());

                    cmd.Connection.Open();

                    cmd.Parameters.AddWithValue("Id", nAgencia);
                    cmd.Parameters.AddWithValue("Acesso", senha);

                    cmd.CommandText = @"SELECT Id, Acesso FROM Agencia WHERE Id = @Id AND Acesso = @Acesso";

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        Console.WriteLine("\n---------------Acesso Garantido-----------------------------------------------------------------------------------------");
                        op = 1;
                        c.Id = c.Id;
                    }

                    else
                    {
                        Console.WriteLine("\n----------------Acesso Negado-------------------------------------------------------------------------------------------");
                        op = 0;
                    }

                    cmd.Parameters.RemoveAt("Id");
                    cmd.Parameters.RemoveAt("Acesso");

                    cmd.Connection.Close();

                    while(op != 0)
                    {
                        Console.WriteLine("\n1 - Cadastrar Cliente");
                        Console.WriteLine("2 - Excluir Cliente");
                        Console.WriteLine("3 - Criar Conta");
                        Console.WriteLine("4 - Excluir Conta");
                        Console.WriteLine("5 - Cadastrar Nova Agencia");
                        Console.WriteLine("6 - Excluir Agencia");
                        Console.WriteLine("7 - Conferir Dados de Clientes com Contas");
                        Console.WriteLine("0 - Sair\n");

                        op = Int32.Parse(Console.ReadLine());

                        if(op == 1)
                        {
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("Sobrenome: ");
                            string sobrenome = Console.ReadLine();

                            Console.Write("CPF: ");
                            string cpf = Console.ReadLine();

                            Console.Write("CEP: ");
                            string cep = Console.ReadLine();

                            Random rnd = new Random();
                            int rng = rnd.Next(0, 9);
                            int rng2 = rnd.Next(0, 9);
                            int rng3 = rnd.Next(0, 9);
                            int rng4 = rnd.Next(0, 9);

                            string pass = "";

                            pass = pass + Convert.ToString(rng);
                            pass = pass + Convert.ToString(rng2);
                            pass = pass + Convert.ToString(rng3);
                            pass = pass + Convert.ToString(rng4);

                            cmd.Connection.Open();

                            cmd.Parameters.AddWithValue("Nome", nome);
                            cmd.Parameters.AddWithValue("Sobre", sobrenome);
                            cmd.Parameters.AddWithValue("CPF", cpf);
                            cmd.Parameters.AddWithValue("CEP", cep);
                            cmd.Parameters.AddWithValue("Senha", pass);

                            cmd.CommandText = @"INSERT 
                                                INTO Cliente(Nome, Sobrenome, CPF, CEP, Senha)
                                                VALUES(@Nome,@Sobre,@CPF,@CEP,@Senha);";

                            cmd.ExecuteNonQuery();

                            cmd.Parameters.RemoveAt("Nome");
                            cmd.Parameters.RemoveAt("Sobre");
                            cmd.Parameters.RemoveAt("CPF");
                            cmd.Parameters.RemoveAt("CEP");
                            cmd.Parameters.RemoveAt("Senha");

                            cmd.Connection.Close();

                            Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");
                        }

                        if (op == 2)
                        {
                            Console.Write("Insira o id do Cliente: ");
                            int id = Int32.Parse(Console.ReadLine());

                            Console.Write("Confirma que quer cancelar o cadastro do Cliente Id: {0} (Digite 1): ", id);
                            confirm = Int32.Parse(Console.ReadLine());

                            if (confirm == 1)
                            {
                                cmd.Connection.Open();

                                cmd.Parameters.AddWithValue("Id", id);

                                cmd.CommandText = @"DELETE FROM Cliente
                                                        WHERE Id = @Id";

                                cmd.ExecuteNonQuery();

                                cmd.Parameters.RemoveAt("Id");

                                cmd.Connection.Close();

                                Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");
                            }
                        }

                        if (op == 3)
                        {
                            Console.Write("Tipo: ");
                            string tipo = Console.ReadLine();

                            Console.Write("Id do Cliente: ");
                            int idCliente = Int32.Parse(Console.ReadLine());


                            cmd.Connection.Open();

                            cmd.Parameters.AddWithValue("Tipo", tipo);
                            cmd.Parameters.AddWithValue("idCliente", idCliente);
                            cmd.Parameters.AddWithValue("agencia", nAgencia);

                            cmd.CommandText = @"INSERT 
                                                INTO Conta(Tipo, id_cliente, id_agencia)
                                                VALUES(@Tipo,@idCliente,@agencia);";

                            cmd.ExecuteNonQuery();

                            cmd.Parameters.RemoveAt("Tipo");
                            cmd.Parameters.RemoveAt("idCliente");
                            cmd.Parameters.RemoveAt("agencia");

                            cmd.Connection.Close();

                            Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");

                        }

                        if (op == 4)
                        {
                            Console.Write("Insira o Número da Conta: ");
                            int id = Int32.Parse(Console.ReadLine());

                            Console.Write("Confirma que quer deletar a Conta de Id: {0} (Digite 1): ", id);
                            confirm = Int32.Parse(Console.ReadLine());

                            if (confirm == 1)
                            {
                                cmd.Connection.Open();

                                cmd.Parameters.AddWithValue("Id", id);

                                cmd.CommandText = @"DELETE FROM Conta
                                                        WHERE Id = @Id";

                                cmd.ExecuteNonQuery();

                                cmd.Parameters.RemoveAt("Id");

                                cmd.Connection.Close();

                                Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");
                            }
                        }

                        if (op == 5)
                        {
                            Console.Write("Localização: ");
                            string Local = Console.ReadLine();

                            Console.Write("Confirma que uma nova agencia foi aberta no endereço: {0} (Digite 1); ", Local);
                            confirm = Int32.Parse(Console.ReadLine());

                            if (confirm == 1)
                            {
                                Random rnd = new Random();
                                int rng = rnd.Next(0, 9);
                                int rng2 = rnd.Next(0, 9);
                                int rng3 = rnd.Next(0, 9);
                                int rng4 = rnd.Next(0, 9);
                                int rng5 = rnd.Next(0, 9);
                                int rng6 = rnd.Next(0, 9);

                                string pass = "";

                                pass = pass + Convert.ToString(rng);
                                pass = pass + Convert.ToString(rng2);
                                pass = pass + Convert.ToString(rng3);
                                pass = pass + Convert.ToString(rng4);
                                pass = pass + Convert.ToString(rng5);
                                pass = pass + Convert.ToString(rng6);

                                cmd.Connection.Open();

                                cmd.Parameters.AddWithValue("End", Local);
                                cmd.Parameters.AddWithValue("Acesso", pass);

                                cmd.CommandText = @"INSERT 
                                                INTO Agencia(Endereço, Acesso)
                                                VALUES(@End,@Acesso);";

                                cmd.ExecuteNonQuery();

                                cmd.Parameters.RemoveAt("End");
                                cmd.Parameters.RemoveAt("Acesso");

                                cmd.Connection.Close();

                                Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");
                            }
                        }

                        if (op == 6)
                        {
                            Console.Write("Insira o Número da Agencia: ");
                            int id = Int32.Parse(Console.ReadLine());

                            Console.Write("Confirma que quer deletar a Agencia: {0} (Digite 1): ", id);
                            confirm = Int32.Parse(Console.ReadLine());

                            if (confirm == 1)
                            {
                                cmd.Connection.Open();

                                cmd.Parameters.AddWithValue("Id", id);

                                cmd.CommandText = @"DELETE FROM Agencia
                                                        WHERE Id = @Id";

                                cmd.ExecuteNonQuery();

                                cmd.Parameters.RemoveAt("Id");

                                cmd.Connection.Close();

                                Console.WriteLine("\n---------------Operação Efetuada com Sucesso----------------------------------------------------------------------------");
                            }
                        }

                        if (op == 7)
                        {

                            cmd.Connection.Open();

                            cmd.CommandText = @"SELECT c.Id, c.Nome, c.Sobrenome, ct.Tipo, ct.Id_agencia FROM Cliente AS c, Conta AS ct WHERE c.id = ct.id_cliente;";

                            SqlDataReader leitor = cmd.ExecuteReader();

                            if (leitor.HasRows)
                            {
                                while (leitor.Read())
                                {
                                    int id_cliente = leitor.GetInt32(0);
                                    string nome = leitor.GetString(1);
                                    string sobrenome = leitor.GetString(2);
                                    string tipo = leitor.GetString(3);
                                    int agencia = leitor.GetInt32(4);

                                    Console.WriteLine("\nNumero Cliente: {0}; Nome: {1}; Tipo: {2}; Agencia: {3};", id_cliente, nome + " " + sobrenome, tipo, agencia);

                                }
                            }

                            cmd.Connection.Close();

                            Console.WriteLine("\n");
                            }
                        }
                    }
                }
            }
        }
    }

                        
