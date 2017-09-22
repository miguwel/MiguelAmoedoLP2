using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Codigo_Morsa
{
    class Mensagem
    {
        public string txt { get; set; }
        private string[] morse = new string[] 
        { 
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." 
        };

        private char[] letra = new char[]
        {
            'a', 'b', 'c', 'd', 'e','f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public string Codificar()
        {
            string codigo = "", x = "";

            Console.WriteLine("Codificar:");
            txt = Console.ReadLine();

            for (int i = 0; i < txt.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (txt[i] == letra[p] || txt[i] == char.ToUpper(letra[p]))
                    {
                        x = morse[p];
                    }
                }

                string cod = x + " ";
                codigo += cod;
            }

            return codigo;
        }

        public string Decodificar()
        {
            string mensagem = "";
            char caracter = ' ';

            Console.WriteLine("Decodificar:");
            txt = Console.ReadLine();

            string[] codigo = txt.Split(' ');

            for (int i = 0; i < codigo.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (codigo[i] == morse[p])
                    {
                        caracter = char.ToUpper(letra[p]);
                    }
                }

                char cod = caracter;
                mensagem += cod;
            }

            return mensagem;
        }
    }
}
