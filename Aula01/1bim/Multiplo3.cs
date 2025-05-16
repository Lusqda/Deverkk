using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class multiplosde3
    {
        public List<int> multiplo(int num1)
        {
            List<int> multiplos = new List<int>();

            for (int i = 0; i <= num1; i++)
            {
                if (i % 3 == 0)
                {
                    multiplos.Add(i);
                }
            }

            return multiplos;
        }
    }
}