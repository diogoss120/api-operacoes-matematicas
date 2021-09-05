using Bootcamp.Entities;
using System;
using Xunit;

namespace Bootcamp.Tests
{
    public class CalculosMatematicosTests
    {
        private readonly Calculos calc01 = new Calculos(5, 5);
        private readonly Calculos calc02 = new Calculos(5, 0);
        private readonly Calculos calc03 = new Calculos(0, 5);
        private readonly Calculos calc04 = new Calculos(0, 0);
        private readonly Calculos calc05 = new Calculos(5, -5);
        private readonly Calculos calc06 = new Calculos(-5, 5);
        private readonly Calculos calc07 = new Calculos(-5, -5);

        [Fact]
        public void Divisoes()
        {
            Assert.Equal(1, calc01.Divisao());
            Assert.Equal(0, calc03.Divisao());
            Assert.Equal(-1, calc05.Divisao());
            Assert.Equal(-1, calc06.Divisao());
            Assert.Equal(1, calc07.Divisao());

            // esses 2 Assert.Throws seguintes devem estourar um ArgumentException,
            // pois foi definido que um número não pode ser divisivel por zero
            Assert.Throws<ArgumentException>(() => calc02.Divisao());
            Assert.Throws<ArgumentException>(() => calc04.Divisao());
        }

        [Fact]
        public void Multiplicacoes()
        {
            Assert.Equal(25, calc01.Multiplicacao());
            Assert.Equal(0, calc02.Multiplicacao());
            Assert.Equal(0, calc03.Multiplicacao());
            Assert.Equal(0, calc04.Multiplicacao());
            Assert.Equal(-25, calc05.Multiplicacao());
            Assert.Equal(-25, calc06.Multiplicacao());
            Assert.Equal(25, calc07.Multiplicacao());
        }

        [Fact]
        public void Somas()
        {
            Assert.Equal(10, calc01.Soma());
            Assert.Equal(5, calc02.Soma());
            Assert.Equal(5, calc03.Soma());
            Assert.Equal(0, calc04.Soma());
            Assert.Equal(0, calc05.Soma());
            Assert.Equal(0, calc06.Soma());
            Assert.Equal(-10, calc07.Soma());
        }
    }
}
