//~~~~~~~~~~~~~~FUNÇOES~~~~~~~~~~~~~~
//local tipo retorno nome (parametros)
//local e tipo nao sao obrigatorios mas é raro nao declarar

/* LOCAL:
 *      PUBLIC   (pode virar lib)
 *      PRIVATE  (apenas quem tem acesso ao codigo ve)
 *      INTERNAL (interno ao namespace)
 *      PROTECTED
 */

/* TIPO:
 *      STATIC
 *      NÃO STATIC (NAO ESCREVE NADA)
 */

/* PASSAGEM POR REFERENCIA (MEXE NO ENDEREÇO DA VARIAVEL):
 * EX: public static void AumentaDois(ref int num) {
 *          num += 2;
 *      }
 *  Na função main devemos declarar a funçao assim: AumentaDois(ref num)
 */ 

/* PARAMETRO OUT NA FUNÇÃO (PERMITE RETORNAR MAIS DO QUE UMA VARIAVEL):
 *  EX: public static int Divisao(int dividendo, int divisor, out int resto) {
 *          int quociente = dividendo/divisor;
 *          resto = dividendo - (quociente*divisor);
 *          return quociente;
 *      }
 *  Na funçao main devemos declarar a funão assim: quoc = Divisao(divid, divis, out rest);
 */

/* PARAMS (PASSAGEM DE INUMEROS VALORES PARA A FUNÇAO):
 * EX: public static int Soma(params Int[] vetorNumeros) {
 *          if(vetorNumeros.Length == 0 || vetorNumeros.Length == 1) return 0;
 *          else {
 *              for(int i = 0; i < vetorNumeros.Legnth; i++) res += vetorNumeros[i];
 *          }
 *          return res;
 *     }
 * Na funçao main poderiamos ter: 
 *      Soma(1, 3, 5, 7, 8, 9);
 *      int[] vet = {1, 3, 5, 7, 9)
 *      Soma(vet);
 *      Soma();
 */

// PascalCase

namespace Funcoes
{
    class Program
    {
        /*static int Calcula(int a, int b)
        {
            return (a + b);
        }*/

        private static void LerArquivo(int numero)
        {
            string caminho = @"C:\Arquivos\arq" + numero + ".txt";
            if (File.Exists(caminho))
            {
                using (StreamReader arquivo = File.OpenText(caminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
                LerArquivo(++numero);
            } else
            {
                Console.WriteLine("Não existem mais arquivos no diretório.");
            }
        }

        private static void InsereNomes(ref List<string>list)
        {
            int aux;
            string nome;
            while(true)
            {
                Console.Write("Digite 1 para inserir e 0 para sair: ");
                aux = int.Parse(Console.ReadLine());
                if (aux == 0) break;
                else
                {
                    Console.WriteLine("Insira o nome: ");
                    nome = Console.ReadLine();
                    list.Add(nome);
                }
            }
        }
        
        static void Main(string[] args)
        {
            //int a = 2, b = 3; 
            //Console.WriteLine(Calcula(a, b));

            // O @ é pra nao dar incompatibilidade com as barras
            LerArquivo(1);

            using(StreamWriter arquivo = File.CreateText(@"C:\Arquivos\arq1.txt"))
            {
                string content = "Oi eu sou o eduardo e estou mainpulando o arquivo";
                arquivo.WriteLine(content);
            }
            File.AppendAllText(@"C:\Arquivos\arq1.txt", "sim eu sou foda\n");
            using (StreamWriter arquivo = File.AppendText(@"C:\Arquivos\arq1.txt"))
            {
                string content = "Haha manipulei denovo";
                arquivo.WriteLine(content);
            }

            // Passando uma lista por referencia
            List<string> list = new List<string>();
            InsereNomes(ref list);
            foreach (string str in list) Console.WriteLine("Nome: {0}", str);
        }
    }
    
}
