using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculadoraIRPF
    {
        public double RendaAnual { get; set; }

        public CalculadoraIRPF(double rendaAnual)
        {
            RendaAnual = rendaAnual;
        }

        public (double impostoDevido, double aliquotaEfetiva) CalcularImposto()
        {
            double rendaMensal = RendaAnual / 12;
            double imposto = 0;

            if (rendaMensal <= 1903.98)
            {
                return (0, 0);
            }
            else if (rendaMensal <= 2826.65)
            {
                imposto = (RendaAnual * 0.075) - 142.80 * 12;
            }
            else if (rendaMensal <= 3751.05)
            {
                imposto = (RendaAnual * 0.15) - 354.80 * 12;
            }
            else if (rendaMensal <= 4664.68)
            {
                imposto = (RendaAnual * 0.225) - 636.13 * 12;
            }
            else
            {
                imposto = (RendaAnual * 0.275) - 869.36 * 12;
            }

            double aliquotaEfetiva = (imposto / RendaAnual) * 100;
            return (imposto, aliquotaEfetiva);
        }
    }
}
