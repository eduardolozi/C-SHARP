using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Arquivos
    {
        public static void Ler(string caminho)
        {
            string text = File.ReadAllText(caminho);
            Console.WriteLine(text);
        }
    }
}
