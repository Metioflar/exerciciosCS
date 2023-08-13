using static System.Console;

namespace CalculoSalarioComHoraExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            const int horasPorSemana = 40;
            const int semanasPorMes = 4;
            const double taxaHoraExtra = 1.5; // 50% de acréscimo

            Write("Digite o número de horas trabalhadas em um mês: ");
            double horasTrabalhadas = double.Parse(ReadLine());

            Write("Digite o valor da hora: ");
            double salarioPorHora = double.Parse(ReadLine());

            double salarioBase = horasTrabalhadas * salarioPorHora;
            double horasExtras = 0;

            if (horasTrabalhadas > horasPorSemana * semanasPorMes)
            {
                horasExtras = horasTrabalhadas - (horasPorSemana * semanasPorMes);
                double salarioHoraExtra = salarioPorHora * taxaHoraExtra;
                double salarioHoraExtraTotal = horasExtras * salarioHoraExtra;
                salarioBase += salarioHoraExtraTotal;
            }

            WriteLine($"Salário total do funcionário: R${salarioBase}");
        }
    }
}