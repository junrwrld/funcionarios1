using funcionarios1;
using System;
using System.Globalization;

namespace funcionarios
{
    public class _funcionarios
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1;
            Funcionario funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            funcionario1.funcionarioNome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.funcionarioSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            funcionario2.funcionarioNome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.funcionarioSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (funcionario1.funcionarioSalario + funcionario2.funcionarioSalario) / 2.0;

            Console.WriteLine("O salário médio dos funcionários é: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}