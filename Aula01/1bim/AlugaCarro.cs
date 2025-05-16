using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class AluguelCarro
    {
        private const double ValorDiaria = 95.00;
        private const double ValorPorKm = 0.35;

        public int DiasAlugados { get; set; }
        public double KmInicial { get; set; }
        public double KmFinal { get; set; }

        public AluguelCarro(int diasAlugados, double kmInicial, double kmFinal)
        {
            DiasAlugados = diasAlugados;
            KmInicial = kmInicial;
            KmFinal = kmFinal;
        }

        public double CalcularKmPercorridos()
        {
            return KmFinal - KmInicial;
        }

        public double CalcularValorDiarias()
        {
            return DiasAlugados * ValorDiaria;
        }

        public double CalcularValorKm()
        {
            return CalcularKmPercorridos() * ValorPorKm;
        }

        public double CalcularValorTotal()
        {
            return CalcularValorDiarias() + CalcularValorKm();
        }

        public void ExibirResultado()
        {
            Console.WriteLine("\nResumo do Aluguel");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total de dias alugados: {DiasAlugados} dias");
            Console.WriteLine($"Quilometragem inicial: {KmInicial} km");
            Console.WriteLine($"Quilometragem final: {KmFinal} km");
            Console.WriteLine($"Quilometros percorridos: {CalcularKmPercorridos()} km");
            Console.WriteLine($"Valor das diárias ({DiasAlugados} dias × R$95,00): R$ {CalcularValorDiarias():F2}");
            Console.WriteLine($"Valor por km rodado ({CalcularKmPercorridos()} km × R$0,35): R$ {CalcularValorKm():F2}");
            Console.WriteLine($"VALOR TOTAL DO ALUGUEL: R$ {CalcularValorTotal():F2}");
        }
    }
}