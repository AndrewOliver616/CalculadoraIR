using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculaIR();
            
        }

        static void CalculaIR()
        {
            Console.WriteLine("Olá, Bem-vindo(a) ao Calcura IR 2024");
            Console.WriteLine("");
            Console.WriteLine("Digite abaixo a sua renda anual");
            double rendaAnual = double.Parse(Console.ReadLine());

            if (rendaAnual <= 22847.76)
            {
                Console.WriteLine("Contribuinte Isento";
            }
            if (rendaAnual >= 22847.77 && rendaAnual <= 33919.80)
            {
                double percentAliquota = 0.075;
                double valorAliquota = rendaAnual * percentAliquota;
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ " + valorAliquota);
            }
            else if (rendaAnual >= 33919.81 && rendaAnual <= 45012.60)
            {
                double percentAliquota = 0.15;
                double valorAliquota = rendaAnual * percentAliquota;
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("O imposto a pagar é R$ " + valorAliquota);
            }
            else if (rendaAnual >= 45012.61 && rendaAnual <= 55976.76)
            {
                double percentAliquota = 0.225;
                double valorAliquota = rendaAnual * percentAliquota;
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("O imposto a pagar é R$ " + valorAliquota);
            }
            else if (rendaAnual >= 55976.16)
            {
                double percentAliquota = 0.275;
                double valorAliquota = rendaAnual * percentAliquota;
                Console.WriteLine("A sua aliquota é de 27.5%");
                Console.WriteLine("O imposto a pagar é R$ " + valorAliquota);
            }

            Console.WriteLine("Fim do cálculo");
            Console.WriteLine("Tecle enter para voltar ao início");
            Console.ReadLine();
            Console.Clear();
            CalculaIR();


            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636
        }

    }
}
