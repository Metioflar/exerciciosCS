namespace lista1
{
    using static System.Console;
    class Program
    {
        public static void Main(string[] args)
        {
            double percentagem = 0;
            WriteLine("Insira o valor do salário base a ser calculado: ");
            double salarioBase = double.Parse(ReadLine());
            if (salarioBase <= 1200)
            {
                WriteLine("Isento de impostos.");
            }
            else if (salarioBase >= 1201 && salarioBase <= 2500)
            {
                percentagem = 0.1;
            }
            else if (salarioBase >= 2501 && salarioBase <= 5000)
            {
                percentagem = 0.15;
            }
            else
            {
                percentagem = 0.20;
            }
            double salarioComDesconto = salarioBase - (salarioBase * percentagem);
            WriteLine($"O salário com desconto é ${salarioComDesconto}");
        }
    }
}