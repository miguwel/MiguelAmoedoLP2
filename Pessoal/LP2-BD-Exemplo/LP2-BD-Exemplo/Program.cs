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
            string stg, op1, op2, op3, op4;
            int o, j;
            Carro carro = new Carro();
            o = 1;
            Console.WriteLine("-----------------Banco de Dados-------------------");
            SqlCommand comando = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI"),
                CommandText = @"SELECT Id, Marca, Modelo, Cor, Placa
                                FROM Carro;"
            };
            try
            {
                comando.Connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        int Id = reader.GetInt32(0);
                        string Marca = reader.GetString(1);
                        string Modelo = reader.GetString(2);
                        string Cor = reader.GetString(3);
                        string Placa = reader.GetString(4);

                        Console.WriteLine("Id: {0} {1} {2} {3} {4};", Id, Marca, Modelo, Cor, Placa);
                    }
                }
                comando.Connection.Close();       
            }
            catch
            {
                Console.WriteLine("CHAMA O CORPO DE BOMBEIROS");
            }
            Console.WriteLine("--------------------------------------------------");
            while (o != 0)
            {
                Console.WriteLine("\n1 - Cadastrar");
                Console.WriteLine("2 - Deletar");
                Console.WriteLine("0 - Encerrar\n");
                o = int.Parse(Console.ReadLine());

                if (o == 1)
                {
                   
                    Console.WriteLine("\nInsira os dados do Carro: ");

                    Console.Write("   Marca: ");
                    carro.Marca = Console.ReadLine();

                    Console.Write("   Modelo: ");
                    carro.Modelo = Console.ReadLine();

                    Console.Write("   Cor: ");
                    carro.Cor = Console.ReadLine();

                    Console.Write("   Placa: ");
                    carro.Placa = Console.ReadLine();

                    Console.Write("   Potencia: ");
                    carro.Potencia = int.Parse(Console.ReadLine());

                    SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI");
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = conec;
                    conec.Open();

                    cmd.Parameters.AddWithValue("Marca", carro.Marca);
                    cmd.Parameters.AddWithValue("Modelo", carro.Modelo);
                    cmd.Parameters.AddWithValue("Cor", carro.Cor);
                    cmd.Parameters.AddWithValue("Placa", carro.Placa);
                    cmd.Parameters.AddWithValue("Pot", carro.Potencia);

                    stg = string.Format(@"INSERT 
                                        INTO Carro(Marca , Modelo , Cor , Placa , Potencia) 
                                        VALUES (@Marca, @Modelo, @Cor, @Placa, @Pot);");
                    cmd.CommandText = stg;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Marca");
                    cmd.Parameters.RemoveAt("Modelo");
                    cmd.Parameters.RemoveAt("Cor");
                    cmd.Parameters.RemoveAt("Placa");
                    cmd.Parameters.RemoveAt("Pot");

                    conec.Close();

                    Console.WriteLine("Cadastrado com sucesso");
                }

                if(o == 2)
                {
                    Console.WriteLine("\n1 - Por ID");
                    Console.WriteLine("2 - Por Potencia");
                    Console.WriteLine("3 - Por Modelo e Cor\n");
                    j = int.Parse(Console.ReadLine());
                    
                    if(j == 1)
                    {
                        Console.Write("\nDigite o ID: ");
                        op1 = Console.ReadLine();

                        SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI");
                        SqlCommand cmd = new SqlCommand();

                        cmd.Connection = conec;

                        cmd.Parameters.AddWithValue("id", op1);
                        
                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Id = @id";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("id");

                        Console.WriteLine("\nEfetuado com sucesso\n");
                    }

                    if (j == 2)
                    {
                        Console.Write("\nDigite a Potencia Minima: ");
                        op2 = Console.ReadLine();

                        SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI");
                        SqlCommand cmd = new SqlCommand();

                        cmd.Connection = conec;

                        cmd.Parameters.AddWithValue("pot", op2);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Potencia <= @pot";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("pot");

                        Console.WriteLine("\nEfetuado com sucesso\n");
                    }

                    if (j == 3)
                    {
                        Console.Write("\nDigite o Modelo: ");
                        op3 = Console.ReadLine();
                        Console.Write("Digite a Cor: ");
                        op4 = Console.ReadLine();

                        SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI");
                        SqlCommand cmd = new SqlCommand();

                        cmd.Connection = conec;

                        cmd.Parameters.AddWithValue("Mod", op3);
                        cmd.Parameters.AddWithValue("Cor", op4);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Modelo = @Mod AND Cor = @Cor";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("Mod");
                        cmd.Parameters.RemoveAt("Cor");

                        Console.WriteLine("\nEfetuado com sucesso\n");
                    }

                    Console.WriteLine("-----------------Banco de Dados-------------------");
                    SqlCommand comand = new SqlCommand()
                    {
                        Connection = new SqlConnection("Data Source=localhost;Initial Catalog=LPAula;Integrated Security=SSPI"),
                        CommandText = @"SELECT Id, Marca, Modelo, Cor, Placa
                                FROM Carro;"
                    };
                    try
                    {
                        comand.Connection.Open();
                        SqlDataReader reader = comand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int Id = reader.GetInt32(0);
                                string Marca = reader.GetString(1);
                                string Modelo = reader.GetString(2);
                                string Cor = reader.GetString(3);
                                string Placa = reader.GetString(4);

                                Console.WriteLine("Id: {0} {1} {2} {3} {4};", Id, Marca, Modelo, Cor, Placa);
                            }
                        }
                        comand.Connection.Close();
                    }
                    catch
                    {
                        Console.WriteLine("CHAMA O CORPO DE BOMBEIROS");
                    }
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }
    }
}
