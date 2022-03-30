using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.core;


namespace Teste.MSTeste
{
    // classe de testes que você queira executar
    [TestClass]
    class ImcMSTests
    {
        public object Operacoes { get; private set; }

        //Metodo de teste
        [TestMethod]
        //descrição do teste
        public void SomarImc_RetornaResultado()
        {
            // arrange – organizar, preparar o teste
            double Peso = 80;
            double Altura = 1.90;

            // act – agir – execução/chamada do método
            var resultado = core.IMC.CalcularImc(Peso, Altura);

            // Assert – comportamento esperado, comportamento obtido
            Assert.AreEqual(22.16, resultado);
               
        }

    }
}
