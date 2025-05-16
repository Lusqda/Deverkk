using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class Fatoriais
    {
        public int CalcularFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            int fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}