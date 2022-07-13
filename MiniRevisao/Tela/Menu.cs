using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;
using Files;
//usamos system.configuration para importar as keys do arquivo app.config
//para criar o app.config so devemos criar um novo arquivo no gerenciador de soluçoes
using System.Configuration;

namespace Tela
{
    internal class Menu
    {
        public static void Criar()
        {
            // a key caminho esta no app.config, assim quando quiser mudar o valor dela é so ir no app config e nao no codigo
            string caminho_arquivo = ConfigurationManager.AppSettings["caminho"];
            int option, num, num2;
            float nota;
            string resp;
            while (true)
            {
                Console.WriteLine("0 - SAIR\n1 - LER ARQUIVO\n2 - TABUADA\n3 - CALULADORA\n4 - MEDIA DE NOTAS DA SALA");
                option = int.Parse(Console.ReadLine());
                if (option == 0) break;
                switch (option)
                {
                    case 1:
                        Arquivos.Ler(caminho_arquivo + "arq1.txt ");
                        break;
                    case 2:
                        Console.WriteLine("Insira o numero: ");
                        num = int.Parse(Console.ReadLine());
                        Tabuada.Tabuada10(num);
                        break;
                    case 3:
                        Console.WriteLine("Insira os dois numeros: ");
                        num = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Calculadora.Soma(num, num2);
                        break;
                    case 4:
                        List<float> notas = new List<float>();
                        while (true)
                        {
                            Console.WriteLine("Insira a nota do aluno: ");
                            nota = float.Parse(Console.ReadLine());
                            if (nota == -1.0f) break;
                            notas.Add(nota);
                        }
                        Media.Alunos(notas);
                        break;
                    default:
                        Console.WriteLine("Opção inexistente.");
                        break;
                }
            }
        }
    }
}
