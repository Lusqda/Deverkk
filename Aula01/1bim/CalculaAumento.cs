using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaAumento
    {
        public double SalarioInicial { get; set; }
        public double PercentualAumento { get; set; }

        public CalculaAumento(double salarioInicial, double percentualAumento)
        {
            SalarioInicial = salarioInicial;
            PercentualAumento = percentualAumento;
        }

        public double CalcularValorAumento()
        {
            return SalarioInicial * (PercentualAumento / 100);
        }

        public double CalcularNovoSalario()
        {
            return SalarioInicial + CalcularValorAumento();
        }
        public void ExibirResultado()
        {
            Console.WriteLine("\nResumo do Aumento");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Salário inicial: R$ {SalarioInicial:F2}");
            Console.WriteLine($"Percentual de aumento: {PercentualAumento:F2}%");
            Console.WriteLine($"Valor do aumento: R$ {CalcularValorAumento():F2}");
            Console.WriteLine($"Novo salário: R$ {CalcularNovoSalario():F2}");
        }
    }
}