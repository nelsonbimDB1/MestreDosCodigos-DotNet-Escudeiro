using Exercicio_POO_4;
using NUnit.Framework;

namespace Exercicio_Test_nUnity
{
    public class Tests
    {
        [TestFixture]
        public class TestesNUnity
        {
            [Test]
            public void ControleDeveTrocarOCanalCorretamente()
            {
                ControleRemoto controle = new ControleRemoto();

                controle.EscolherCanal(12);

                Assert.True(controle.GetCanal() == 12);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            [TestCase(5)]
            public void ControleDeveTrocarOCanalCorretamente(int value)
            {
                ControleRemoto controle = new ControleRemoto();

                controle.EscolherCanal(value);

                Assert.True(controle.GetCanal() == value);
            }

            [Test]
            public void ControleNaoDeveTrocarOCanalCorretamente()
            {
                ControleRemoto controle = new ControleRemoto();

                controle.EscolherCanal(101);

                Assert.False(controle.GetCanal() == 101);
            }
        }
    }
}