using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Codigo_Morsa
{
    class Program
    {
        static void Main(string[] args)
        {
             while (true)
            {

                Console.WriteLine("1 - Codificar");
                Console.WriteLine("2 - Decodificar");
                Console.WriteLine("3 - Transmitir");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                    break;

                Mensagem mAtual = new Mensagem();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Codificar: ");
                        mAtual.Texto = Console.ReadLine();
                        Console.WriteLine(mAtual.PortuguesParaMorse());
                        break;

                    case 2:
                        Console.WriteLine("Decodificar: ");
                        mAtual.Texto = Console.ReadLine();
                        mAtual.Codificada = true;
                        Console.WriteLine(mAtual.MorseParaPortugues());
                        break;

                    case 3:
                        Console.WriteLine("Transmitir (em português): ");
                        mAtual.Texto = Console.ReadLine();
                        Console.WriteLine(mAtual.PortuguesParaMorse());
                        mAtual.Transmitir();
                        break;

                    default:
                        break;
                }
            } 
        }
    }
}
