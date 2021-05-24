using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Exercicio_POO_1
{
    #region 1- POO

    //Programação orientada a a Objetos é o metodo da programação (Ou melhor dizendo, Paradigma, como é chamado)
    //O paradigma tras o desenvolvimento mais próximo da realidade, transformando os objetos em Objetos e ações reais

    internal class Monitor
    {
        public int Polegadas { get; set; }
        public int Frequencia { get; set; }
        public double TaxaDeResposta { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Ligado { get; set; }

        public void LigarDesligar() => Ligado = !Ligado;
    }

    internal class Bicicleta
    {
        public string Cor { get; set; }
        public int Aro { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Velocidade { get; set; }


        public void Pedalar() => this.Velocidade++;

        public void Frear() => this.Velocidade = 0;
    }


    #endregion

    #region 2 - Poliformismo
    //Polimorfismo é o conceito que define que o mesmo método pode ser implementado de diferentes formas em objetos de diferentes classes;
    //Podemos exemplificar de duas formas basicas
    //Sobreescrever metodos marcados como Virtual de uma classe herdada e com sobrecarga de parametros
    //Segue exemplo abaixo
    //O Metodo acelerar é um exemplo de poliformismo, aonde o metodo sem parametro é marcado como virtual e aceita ser sobrescrito
    //E existe novamente o metodo Acelerar porém com um parametro de sobrecarga
    //Sendo assim o mesmo metodo ter varias implementações

    internal class Veiculo
    {
        public double Velocidade { get; set; } = 0;

        public virtual void Acelerar() 
        {
            Velocidade++;
        }

        public void Acelerar(double velocidadeDesejada)
        {
            Velocidade = velocidadeDesejada;
        }
    }

    internal class Aviao : Veiculo
    {
        public override void Acelerar()
        {
            Velocidade = Velocidade + 100;
        }
    }

    internal class Patinete : Veiculo
    {
        public override void Acelerar()
        {
            Velocidade += 0.2;
        }
    }

    #endregion

    #region 3- O que é abstração
    //A Abstração é um conceito importante na programação orientada a objetos, se não for a mais importante.
    //Levando em consideração o exemplo acima, a classe veículo poderia ser abstrata com um método Acelerar também abstrato, forçando a implementação em quem herdar essa classee.
    //A classe veículo não tem capacidade de saber como cada veículo irá acelerar. Abstraindo o método, todos veículos iram acelerar, porém cada um com sua implementação (velocidade)
    #endregion

    #region 4- O que é encapsulamento?
    //O encapsulamento de propriedades de uma classe, nos tras segurança na programação orientadas a objetos
    //O Encapsulamento oculta propriedades de uma classe, sendo possível mudar o valor das propriedades apenas por metodos implementados nessa classe
    //Bloqueando a alteração do valor das propriedades diretamente pelas mesmas
    //As propriedades Nome e Idade da class Pessoa, só poderão ser definidas pelos metodos implementados nessa classe;

    internal class Pessoa
    {
        private string Nome;
        private int Idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void DefinirNome(string nome)
        {
            this.Nome = nome;
        }
        public void DefinirIdade(int idade)
        {
            this.Idade = idade;
        }

    }

    #endregion

    #region 5- Quando usar uma classe abstrata e quando devo usar uma interface
    //Em uma interface a mesma funciona como  um contrato, forçando a implementação de todas propriedades e metodos na classe que a herdar
    //As interfaces não podem ter implementações. São muito usadas para um desenvolvimento limpo e com baixo acoplamento
    //Já as classes abstratas podem conter implementações, só é possível herdar uma classe abstrata em outra classe

    #region Classes abstratas
    public abstract class Mamifero
    {
        public string Nome { get; set; }
        public int MetrosAndados { get; set; } = 0;

        public abstract void SeAlimentar();

        public void Andar() => MetrosAndados++; //POLIFORMISMO COM SOBRECARGA DE PARAMETRO

        public void Andar(int metros) => MetrosAndados += metros; //POLIFORMISMO COM SOBRECARGA DE PARAMETRO

        public virtual void NascimentoFilhote() => Console.WriteLine("Ventre da mãe!"); //POLIFORMISMO COM METODOS VIRTUAIS
    }

    public class Macaco : Mamifero, IMacaco
    {
        public TipoMacaco TipoMacaco { get; set; }
        public override void SeAlimentar() => Console.WriteLine("Comer Banana!");
    }

    public class Cachorro : Mamifero
    {
        public string Raca { get; set; }
        public override void SeAlimentar() => Console.WriteLine("Comer racao!");
    }

    public enum TipoMacaco
    {
        Simio = 1 ,
        Antropoides
    }

    #endregion

    #region Interfaces
    //Interface macaco não tem nenhuma implementação, somente as propriedades e metodos que serão obrigatórios em quem implementar a mesma
    internal interface IMacaco
    {
        TipoMacaco TipoMacaco { get; set; }

        void SeAlimentar();
    }

    //Podemos injetar varias interfaces em uma classe, sendo assim criamos uma interface que obrigue a implementação da propriedade Especie, sendo possível definir a especie
    //Podendo ser injetada não só no macaco, mas em qualquer animal
    internal interface IEspecie
    {
        string Especie { get; set; }
    }

    //O macaco normal implementa a interface IMacaco, portanto deve possuir a implementação de todas os atributos e comportamentos estipulados na interface.
    //Diferente da classe abstrata ele não recebeu a implementação já pronta do método dormir.
    internal class Passaro : IEspecie
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Especie { get; set; }

        public void Dormir()
        {
            //implementacao de dormir do macaco normal
        }

        public void Voar()
        {
            //implementação de subir na arvore do macaco normal
        }
    }

    #endregion

    #endregion

    #region 6-O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
    //IDisposable: Define que uma classe implemente o método Dispose(). Esse método é usado para liberar recursos não gerenciaveis, como por exemplo memória.
    internal class ExemploIDisposable : IDisposable
    {
        public MemoryStream Arquivo { get; set; }

        public ExemploIDisposable()
        {
            Arquivo = new MemoryStream();
        }

        public void Dispose()
        {
            //Código para liberar recursos não gerenciaveis
            Arquivo.Close();
        }
    }

    //IComparable: Define que uma classe implemente o método CompareTo(). Esse método permite definir a posição de um objeto em uma ordem de classificação.
    internal class ExemploIComparable : IComparable
    {
        public int Valor { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var exemplo = obj as ExemploIComparable;
            if (exemplo != null)
            {
                if (this.Valor < exemplo.Valor) return -1;
                else if (this.Valor > exemplo.Valor) return 1;
                else return 0;
            }
            else
            {
                throw new ArgumentException($"O objeto não é um {(typeof(ExemploIComparable).Name)}");
            }
        }
    }

    //ICloneable:  Define quem uma classe implemente o método Clone(). Esse método permite replicar um objeto com os mesmos valores de uma instância existente.
    internal class ExemploICloneable : ICloneable
    {
        public object Clone()
        {
            var clone = (ExemploICloneable)this.MemberwiseClone();
            return clone;
        }
    }

    //IEnumerable: Define que uma classe implemente o método GetEnumerator() que retorna um enumerador, esse enumerador permite a iteração simples em uma lista não generica de elementos, resumindo ele permite deixar algo "iteravel".    

    internal class ListExemploIEnumerable : IEnumerable<int>
    {
        private int[] Itens;
        public ListExemploIEnumerable(params int[] itens)
        {
            this.Itens = itens;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListExemploIEnumerator(this.Itens);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new ListExemploIEnumerator(this.Itens);
        }
    }

    internal class ListExemploIEnumerator : IEnumerator<int>
    {
        private int[] Itens;
        private int Index = -1;

        public int Current { get; set; } = -1;

        object IEnumerator.Current => Current;

        public ListExemploIEnumerator(params int[] itens)
        {
            this.Itens = itens;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if ((this.Index + 1) == Itens.Length) return false;
            this.Index++;
            this.Current = Itens[this.Index];
            return true;
        }

        public void Reset()
        {
            this.Index = -1;
        }
    }
    #endregion

    #region 7-Existe herança múltipla (de classes) em C#?
    //Não é possivel que uma classe herde de mais de uma classe no C#, o que podemos fazer é utilizar 
    //as interfaces para resolver situações onde necessitariamos de multiplas definições para um mesmo objeto.

    internal class ClasseBase
    {
        //código da classe base que será herdada por todas as filhas
    }

    //Ao definir uma classe, podemos herdar somente de uma classe base. Caso a classe base herde de uma terceira classe e assim sucessivamente, sua classe irá
    //herdar todas os atributos e comportamentos de toda a hierarquia de herança.
    //O que pode ser feito para 'burlar' essa limitação é utilizar as interfaces, pois não temos limite de interfaces que uma classe pode implementar
    internal class ClasseFilha : ClasseBase, Interface1, Interface2
    {

    }

    internal interface Interface1 { }
    internal interface Interface2 { }
    #endregion
}
