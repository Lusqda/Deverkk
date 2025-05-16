using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaDesconto
    {
        public double ValorAtual { get; set; }
        public double PercentualDesconto { get; set; }

        public CalculaDesconto(double valorAtual, double percentualDesconto)
        {
            ValorAtual = valorAtual;
            PercentualDesconto = percentualDesconto;
        }

        public double CalcularValorDesconto()
        {
            return ValorAtual * (PercentualDesconto / 100);
        }

        public double CalcularValorFinal()
        {
            return ValorAtual - CalcularValorDesconto();
        }

        public void ExibirResultado()
        {
            Console.WriteLine("\nResumo do Desconto");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Valor atual da mercadoria: R$ {ValorAtual:F2}");
            Console.WriteLine($"Percentual de desconto: {PercentualDesconto:F2}%");
            Console.WriteLine($"Valor do desconto: R$ {CalcularValorDesconto():F2}");
            Console.WriteLine($"Valor final da mercadoria: R$ {CalcularValorFinal():F2}");
        }
    }
}
