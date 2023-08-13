using static System.Console;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Digite a quantidade atual em estoque: ");
            int quantidadeAtual = int.Parse(ReadLine());

            Write("Digite a quantidade máxima em estoque: ");
            int quantidadeMaxima = int.Parse(ReadLine());

            Write("Digite a quantidade mínima em estoque: ");
            int quantidadeMinima = int.Parse(ReadLine());

            double quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2.0;

            if (quantidadeAtual >= quantidadeMedia)
            {
                WriteLine($"a quantidade média é: {quantidadeMedia}, sendo assim: ");
                WriteLine("Não efetuar compra");
            }
            else
            {
                WriteLine($"a quantidade média é: {quantidadeMedia}, sendo assim: ");
                WriteLine("Efetuar compra");
            }
        }
    }
}