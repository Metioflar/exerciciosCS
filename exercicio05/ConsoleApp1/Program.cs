using static System.Console;

namespace PreferenciaCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            WriteLine("Informe o tipo de combustível abastecido:");
            WriteLine("1 - Álcool");
            WriteLine("2 - Gasolina");
            WriteLine("3 - Diesel");
            WriteLine("4 - Fim");

            Write("Insira o valor: "); int tipoCombustivel = int.Parse(ReadLine());
        
            while (tipoCombustivel != 4)
            {
                if (tipoCombustivel >= 1 && tipoCombustivel <= 3)
                {
                    switch (tipoCombustivel)
                    {
                        case 1:
                            alcool++;
                            break;
                        case 2:
                            gasolina++;
                            break;
                        case 3:
                            diesel++;
                            break;
                    }
                }
                else
                {
                    WriteLine("Código inválido! Por favor, informe um código válido.");
                }
                WriteLine("==============================================");
                WriteLine("Novo cliente, informe o próximo tipo de combustível abastecido:");
                WriteLine("1 - Álcool");
                WriteLine("2 - Gasolina");
                WriteLine("3 - Diesel");
                WriteLine("4 - Fim");

                Write("Insira o valor: "); tipoCombustivel = int.Parse(ReadLine());
                
            }
            WriteLine("==============================================");
            WriteLine("Obrigada por responder a nossa pesquisa! :D");
            WriteLine("================ RESULTADOS ==================");
            WriteLine($"Foram abastecidos {alcool} de álcool. ");
            WriteLine($"Foram abastecidos {gasolina} de gasolina. ");
            WriteLine($"Foram abastecidos {diesel} de diesel. ");
            WriteLine("==============================================");
        }
    }
}