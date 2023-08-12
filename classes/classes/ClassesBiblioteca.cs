namespace ClassesBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
                public class Livro
        {
            public int IdLivro { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int AnoPublicacao { get; set; }

            public Livro(int id, string titulo, string autor, int ano)
            {
                IdLivro = id;
                Titulo = titulo;
                Autor = autor;
                AnoPublicacao = ano;
            }

        }

        public class Pessoa
        {
            public int IdPessoaCPF { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Endereco { get; set; }

            public Pessoa(int id, string nome, int idade, string endereco)
            {
                IdPessoaCPF = id;
                Nome = nome;
                Idade = idade;
                Endereco = endereco;
            }

        }

        public class Emprestimo
        {
            public int IdEmprestimo { get; set; }
            public DateTime DataEmprestimo { get; set; }
            public DateTime DataDevolucao { get; set; }
            public Livro LivroEmprestado { get; set; }
            public Pessoa PessoaAlugou { get; set; }

            public Emprestimo(int id, DateTime emprestimo, DateTime devolucao, Livro livro, Pessoa pessoa)
            {
                IdEmprestimo = id;
                DataEmprestimo = emprestimo;
                DataDevolucao = devolucao;
                LivroEmprestado = livro;
                PessoaAlugou = pessoa;
                DataDevolucao = emprestimo.AddDays(15);
            }
            public void Devolver()
            {
                DataDevolucao = DateTime.Now;
            }
            public double CalcularMulta()
            {
                double multa = 0;
                if (DataDevolucao > DataEmprestimo.AddDays(15))
                {
                    TimeSpan atraso = DataDevolucao - DataEmprestimo.AddDays(15);
                    multa = atraso.TotalDias * 2; // Multa de R$2 por dia de atraso
                }
                return multa;
            }
            public string Alugar()
            {
                return $"Livro {LivroEmprestado.Titulo} alugado por {PessoaEmprestada.Nome}. Boas leituras!";
            }

        }
        }
    }
}

