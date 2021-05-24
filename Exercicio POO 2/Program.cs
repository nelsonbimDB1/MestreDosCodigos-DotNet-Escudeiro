using System;

namespace Exercicio_POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.AlterarNome("Nelson Bim");
            pessoa.AlterarDataDeNascimento(new DateTime(1993, 7, 13));
            pessoa.AlterarAltura(185);

            pessoa.ImprimeDadosPessoa();
        }

        public class Pessoa
        {
            private string Nome { get; set; }
            private DateTime DataDeNascimento { get; set; }
            private int AlturaEmCentimetros { get; set; }

            public void AlterarNome(string nome) => Nome = nome;
            public void AlterarDataDeNascimento(DateTime dataDeNascimento) => DataDeNascimento = dataDeNascimento;
            public void AlterarAltura(int alturaEmCentimetros) => AlturaEmCentimetros = alturaEmCentimetros;

            public string ObterNome() => Nome;
            public DateTime ObterDataDeNascimento() => DataDeNascimento;
            public int ObterAlturaEmCentimetros() => AlturaEmCentimetros;
            public int ObterDataNascimento()
            {
                int idade = DateTime.Now.Year - DataDeNascimento.Year;
                if (DateTime.Now.DayOfYear < DataDeNascimento.DayOfYear)
                    idade--;

                return idade;
            }

            public void ImprimeDadosPessoa()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Data de Nascimento: {DataDeNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Idade: {ObterDataNascimento()}");
                Console.WriteLine($"Altura: {AlturaEmCentimetros}cm");
            }

        }
    }
}
