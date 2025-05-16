using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class fatoriais
    {
        public int CalcularFatorial(int numero)
        {
            if (numero < 0)
                throw new ArgumentException("Número não pode ser negativo", nameof(numero));

            if (numero == 0 || numero == 1)
                return 1;

            checked
            {
                return numero * CalcularFatorial(numero - 1);
            }
        }
    }
}