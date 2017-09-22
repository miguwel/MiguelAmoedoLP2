using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Codigo_Morsa
{
    class Mensagem
    {
        public string Texto { get; set; }
        public bool Codificada { get; set; }

        private int frequenciaNatural = 2000; 
        private int duracaoNatural = 240; 
        private string[] alfabetoMorse = new string[] {
            ".-",
            "-...",
            "-.-.",
            "-..",
            ".",
            "..-.",
            "--.",
            "....",
            "..",
            ".---",
            "-.-",
            ".-..",
            "--",
            "-.",
            "---",
            ".--.",
            "--.-",
            ".-.",
            "...",
            "-",
            "..-",
            "...-",
            ".--",
            "-..-",
            "-.--",
            "--..",
        };

        public string PortuguesParaMorse()
        {
            string res = "";
            char[] input = Texto.ToCharArray();

            for (int i = 0; i < Texto.Length; i++)
            {
                int index = input[i] - 'A';
                string somar = "";

                if (index >= 0 && index < alfabetoMorse.Length)
                {
                    somar = alfabetoMorse[input[i] - 'A'];
                }

                else if (input[i].ToString() == " ")
                    somar = "  ";

                else
                    somar = input[i] + "";

                res += somar;
                res += " ";
            }

            return res;
        }

        public string MorseParaPortugues()
        {
            if (Codificada)
            {
                string res = "";

                string[] letras = Texto.Split(' ');

                foreach (string letra in letras)
                {
                    int index = Array.IndexOf(alfabetoMorse, letra);

                    if (index != -1)
                    {
                        char ch = (char)(index + 'A');
                        Console.Write(ch);
                    }
                    else
                        Console.Write(" ");
                }
                return res;
            }

            throw new Exception("A mensagem não está codificada!");
        }

        public void Transmitir()
        {
            string emMorse = Texto;

            if (!Codificada)
                emMorse = PortuguesParaMorse();

            for (int i = 0; i < emMorse.Length; i++)
            {
                if (emMorse[i] == '.')
                    Console.Beep(frequenciaNatural, duracaoNatural / 2);
                else if (emMorse[i] == '-')
                    Console.Beep(frequenciaNatural, duracaoNatural);
            }
        }

        public Mensagem()
        {
            Codificada = false;
        }
    }
}
