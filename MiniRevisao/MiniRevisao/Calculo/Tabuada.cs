using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Tabuada
    {
        public static void Tabuada10(int num)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + i * num);
            }
        }
    }
}
