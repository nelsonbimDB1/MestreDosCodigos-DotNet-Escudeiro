using System;
using Xunit;

namespace Exercicio_Test_xUnity
{
    public class TestesXUnity
    {
        [Fact]
        public void SomaDosValoresDeveSerPar()
        {
            int a = 2, b = 10;

            var soma = a + b;

            var resto = soma % 2;

            Assert.True(resto == 0);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(15)]
        public void NumeroDeveSerMultiploDe3(int numero)
        {
            var resto = numero % 3;
            Assert.True(resto == 0);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(11)]
        [InlineData(16)]
        public void NumeroNaoDeveSerMultiploDe3(int numero)
        {
            var resto = numero % 3;
            Assert.False(resto == 0);
        }
    }
}
