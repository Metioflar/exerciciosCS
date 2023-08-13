using System;

namespace EncontrarMaiorMenorVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tamanhoVetor = 100;
            int[] vetor = new int[tamanhoVetor];

            Random random = new Random();

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetor[i] = random.Next(); // Gera um número inteiro aleatório
            }

            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;
            int posicaoMaior = 0;
            int posicaoMenor = -1;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (vetor[i] > maiorValor)
                {
                    maiorValor = vetor[i];
                    posicaoMaior = i;
                }

                if (vetor[i] < menorValor)
                {
                    menorValor = vetor[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine($"Maior valor: {maiorValor} na posição: {posicaoMaior}");
            Console.WriteLine($"Menor valor: {menorValor} na posição: {posicaoMenor}");
        }
    }
}