using AdvocaciaPrincipal.modelo;
using System;
using Xunit;

namespace AdvocaciaTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {  //Arrange

            Advogado ad = new Advogado();
            ad.Idade = 20;
            bool esperado = true;
            bool resultado = false;
            //act
            resultado = ad.verificarSeAdvogadoEMaiorIdade();

            // assert
            Assert.Equal(esperado, resultado);
        }
    }
}
