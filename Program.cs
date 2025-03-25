using System;
using System.Globalization;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");


            /* EXERCICIO 5 - OK
            int codigo1, numeroPecas1, codigo2, numeroPecas2;
            double valor1, valor2;

            Console.WriteLine("Informe o código da peça 1: ");
            codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de peças 1: ");
            numeroPecas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 1: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da peça 2: ");
            codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de peças 2: ");
            numeroPecas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 2: ");
            valor2 = double.Parse(Console.ReadLine());

            double total = numeroPecas1 * valor1 + numeroPecas2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
            */

            /* EXERCICIO 4 - OK
            int nFuncionario, horasTrabalhadas;
            double valorHora, salario;

            Console.WriteLine("Digite o número do funcionário: ");
            nFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"Numero do Funcionario = {nFuncionario}");
            Console.WriteLine($"Salario = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /* EXERCIOCIO 3 - OK
            int n1, n2, n3, n4, diferenca;
            Console.WriteLine("Digite 4 valores inteiros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            diferenca = (n1 * n2 - n3 * n4);

            Console.WriteLine($"DIFERENCA = {diferenca}");
            */

            /* EXERCICIO 2 - OK
            Console.WriteLine("Digite o valor do raio: ");
            Double raio, area, pi = 3.14159;

            raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine($"O radio da area é: {area.ToString("F4", CultureInfo.InvariantCulture)}");
            */

            /* EXERCICIO 1 - OK
            Console.WriteLine("Digite dois números inteiros: ");
            int n1, n2, soma;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine($"SOMA = {soma}");
            */
        }
    }
}