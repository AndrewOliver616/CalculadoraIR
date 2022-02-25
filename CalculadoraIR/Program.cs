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
            Console.WriteLine("Olá, Bem-vindo(a) ao Calcura IR 2022");
            Console.WriteLine("");
            Console.WriteLine("Digite abaixo o valor bruto do seu salário");
            double salario = double.Parse(Console.ReadLine());
            if (salario >= 1900.0 && salario <= 2800.0)
            {
                double percentAliquota = 0.075;
                double valorAliquota = salario * percentAliquota;
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ " + valorAliquota);
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                double percentAliquota = 0.15;
                double valorAliquota = salario * percentAliquota;
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ " + valorAliquota);
            }
            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                double percentAliquota = 0.225;
                double valorAliquota = salario * percentAliquota;
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ " + valorAliquota);
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
