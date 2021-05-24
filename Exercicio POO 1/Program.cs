using System;
using System.Collections;
using System.Linq;

namespace Exercicio_POO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ornitorrinco1 = new Ornitorrinco("Ornitorrinco 1");
            var ornitorrinco1Clone = ornitorrinco1.Clone();

            var ornitorrinco2 = new Ornitorrinco("Ornitorrinco 2");

            Console.WriteLine(ornitorrinco1.GetEnumerator());
        }


        public abstract class Mamifero
        {
            public string Nome { get; set; }
            public int MetrosAndados { get; set; } = 0;

            public abstract void SeAlimentar(); //ABSTRACAO 

            public void Andar() => MetrosAndados++; //POLIFORMISMO COM SOBRECARGA DE PARAMETRO

            public void Andar(int metros) => MetrosAndados += metros; //POLIFORMISMO COM SOBRECARGA DE PARAMETRO

            public virtual void NascimentoFilhote() => Console.WriteLine("Ventre da mãe!"); //POLIFORMISMO COM METODOS VIRTUAIS
        }

        public class Macaco : Mamifero
        {
            public string Especie { get; set; }
            public override void SeAlimentar() => Console.WriteLine("Comer Banana!");
        }

        public class Cachorro : Mamifero
        {
            public string Raca { get; set; }
            public override void SeAlimentar() => Console.WriteLine("Comer racao!");
        }

        public class Ornitorrinco : Mamifero, ICloneable, IDisposable, IComparable<Ornitorrinco>, IEnumerable
        {
            public Ornitorrinco[] Filhotes = new Ornitorrinco[10];
            bool disposed = false;

            public Ornitorrinco(string nome)
            {
                Nome = nome;
                GerarFilhos();
            }

            public void GerarFilhos() => Filhotes = Filhotes.Select((_, index) => new Ornitorrinco($"Filhote numero {index}")).ToArray();

            public override void SeAlimentar() => Console.WriteLine("Comer larvas ou insetos!");
            public new void NascimentoFilhote() => Console.WriteLine("Ventre da mãe!");


            //IMPLEMENTAÇÃO ICloneable
            public object Clone() => new Ornitorrinco("Ornitorrinco 2");

            //IMPLEMENTAÇÂO IDisposable Pattern
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                if (disposing)
                {
                    //Limpar recursos alocados, classes, interfaces injetadas e etc.
                }

                disposed = true;
            }

            //IMPLEMENTAÇÃO IComparable
            public int CompareTo(Ornitorrinco ornitorrinco)
            {
                if (Nome == ornitorrinco.Nome)
                {
                    return MetrosAndados.CompareTo(ornitorrinco.MetrosAndados);
                }
                
                return ornitorrinco.Nome.CompareTo(Nome);
            }

            //IMPLEMENTAÇÃO IEnumarable
            public IEnumerator GetEnumerator()
            {
                foreach (object filhote in Filhotes)
                {
                    if (filhote == null)
                    {
                        break;
                    }
                    yield return filhote;
                }
            }
        }
    }
}
