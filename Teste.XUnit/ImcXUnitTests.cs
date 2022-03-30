using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.core;
using Xunit;

namespace Teste.XUnit
{
    public class ImcXUnitTests
    {
        //método de teste
        [Fact]

        //descrição do teste
        public void SomarImc_RetornarResultado()
        {
            // arrange – organizar, preparar o teste
            double Peso = 90;
            double Altura = 2.0;

            // act – agir – execução/chamada do método
            var resultado = IMC.CalcularImc(Peso, Altura);
            // Assert – comportamento esperado, comportamento obtido
            Assert.Equal(22.5, resultado);

        }

        [Theory]
        [InlineData(100, 2.0, 25)]
        [InlineData(90, 2.0, 22.5)]

        public void CalcularImc_RetornarResultado_ParaUmaListaDeValores(double PrimeiroNumero, double SegundoNumero , 
                                                                             double ResultadoEsperado)
        {
            var resultadoSoma = IMC.CalcularImc(PrimeiroNumero, SegundoNumero);
            Assert.Equal(ResultadoEsperado, resultadoSoma);
        }


    }
}
