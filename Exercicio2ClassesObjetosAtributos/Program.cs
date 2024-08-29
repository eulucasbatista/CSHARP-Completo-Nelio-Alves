using System;
using System.Globalization;

namespace Exercicio2ClassesObjetosAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios fun1 = new Funcionarios();
            Funcionarios fun2 = new Funcionarios();
           

            Console.WriteLine("Digite o nome do Funcionário:");
            Console.Write("Nome:");
            fun1.Nome = Console.ReadLine();
            Console.Write("Salario:");
            fun1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\r\nNome do primeiro funcionario: " + fun1.Nome);
            Console.WriteLine("\r\nSalario do primeiro funcionario: " + fun1.Salario);

            Console.WriteLine("Digite o nome do segundo Funcionário:");
            Console.Write("Nome:");
            fun2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            fun2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\r\nNome do segundo funcionario: " + fun2.Nome);
            Console.WriteLine("\r\nSalario do segundo funcionario: " + fun2.Salario);

            //Calculando a Media dos salarios
            double media = (fun1.Salario + fun2.Salario) / 2.0;
            Console.WriteLine("\r\nSalario médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
