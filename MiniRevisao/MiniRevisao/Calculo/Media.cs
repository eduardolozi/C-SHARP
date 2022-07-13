using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Alunos(List<float> notas)
        {
            float somaNotas = 0.0f;
            float media;
            foreach (float i in notas)
            {
                somaNotas = somaNotas + i;
            }
            media = somaNotas / notas.Count;
            Console.WriteLine("Média da turma: " + media);
        }
    }
}
