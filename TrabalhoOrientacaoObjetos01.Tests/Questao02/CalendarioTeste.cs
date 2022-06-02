using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao02;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao02
{
    public class CalendarioTeste
    {
        [Theory]
        [InlineData("2005/01/24", "janeiro")]
        public void Validar_ObterMesPorExtenso(string mes, string resultado)
        {
            // Arrange
            var calendario = new Calendario();
            calendario.Data = Convert.ToDateTime(mes);

            // Act
            var obterMes = calendario.ObterMesPorExtenso();
        }
    }
}
