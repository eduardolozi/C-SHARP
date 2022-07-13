namespace Funcoes
{
    class Arquivos
    {
        static void Main(string[] args)
        {
            //~~~~~~~~ARQUIVOS~~~~~~~~~~
            
            //Para ler arquivos linha por linha
            using (StreamReader arquivos = File.OpenText(@"C:\Arquivos\arq2.txt"))
            {
                string line;
                while ((line = arquivos.ReadLine()) != null) Console.WriteLine(line);
            }

            //Para criar e escrever um artigo (ou sobrescrever um ja existente)
            using (StreamWriter arquivos = File.CreateText(@"C:\Arquivos\arq3.txt"))
            {
                arquivos.WriteLine("Oi eu sou o Goku!");
            }

            //Para escrever no final do arquivo
            File.AppendAllText(@"C:\Arquivos\arq3.txt", "E eu sou o Eduardo.");

            //Para ler o arquivo inteiro
            string text = File.ReadAllText(@"C:\Arquivos\arq3.txt");
            Console.WriteLine(text);

        }
    }
}

