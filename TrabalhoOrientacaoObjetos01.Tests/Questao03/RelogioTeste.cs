using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao03;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao03
{
    public class RelogioTeste
    {
        [Theory]

        [InlineData("00:02:04", "Zero horas")]
        [InlineData("01:03:05", "Uma hora")]
        [InlineData("02:04:06", "Duas horas")]
        [InlineData("03:05:07", "Três horas")]
        [InlineData("04:12:12", "Quatro horas")]
        [InlineData("05:16:17", "Cinco horas")]
        [InlineData("06:12:44", "Seis horas")]
        [InlineData("07:22:16", "Sete horas")]
        [InlineData("08:45:39", "Oito horas")]
        [InlineData("09:45:16", "Nove horas")]
        [InlineData("10:33:16", "Dez horas")]
        [InlineData("11:45:16", "Onze horas")]
        [InlineData("12:58:16", "Doze horas")]
        [InlineData("13:45:02", "Treze horas")]
        [InlineData("14:12:16", "Quatorze horas")]
        [InlineData("15:45:18", "Quinze horas")]
        [InlineData("16:45:11", "Dezesseis horas")]
        [InlineData("17:18:49", "Dezessete horas")]
        [InlineData("18:45:16", "Dezoito horas")]
        [InlineData("19:45:16", "Dezenove horas")]
        [InlineData("20:02:33", "Vinte horas")]
        [InlineData("21:17:17", "Vinte e uma horas")]
        [InlineData("22:54:52", "Vinte e duas horas")]
        [InlineData("23:44:47", "Vinte e três horas")]

        public void Validar_Todas_As_Horas_Por_Extenso(string hora, string horaExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = Convert.ToDateTime(hora);

            //Act
            var horaPorExtenso = relogio.ObterHoraPorExtenso();

            //Assert
            horaPorExtenso.Should().Be(horaExtenso);
        }

        

        
    }
}
