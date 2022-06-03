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

        [Theory]

        [InlineData("00:00:04", "zero minutos")]
        [InlineData("01:01:05", "um minuto")]
        [InlineData("03:02:06", "dois minutos")]
        [InlineData("03:03:07", "três minutos")]
        [InlineData("04:04:08", "quatro minutos")]
        [InlineData("08:05:12", "cinco minutos")]
        [InlineData("04:06:41", "seis minutos")]
        [InlineData("06:07:12", "sete minutos")]
        [InlineData("04:08:55", "oito minutos")]
        [InlineData("14:09:23", "nove minutos")]
        [InlineData("12:10:44", "dez minutos")]
        [InlineData("13:11:25", "onze minutos")]
        [InlineData("12:12:35", "doze minutos")]
        [InlineData("07:13:12", "treze minutos")]
        [InlineData("12:14:08", "quatorze minutos")]
        [InlineData("08:15:07", "quinze minutos")]
        [InlineData("12:16:26", "dezesseis minutos")]
        [InlineData("12:17:44", "dezessete minutos")]
        [InlineData("18:18:33", "dezoito minutos")]
        [InlineData("22:19:44", "dezenove minutos")]
        [InlineData("04:20:18", "vinte minutos")]
        [InlineData("14:21:18", "vinte e um minutos")]
        [InlineData("05:22:22", "vinte e dois minutos")]
        [InlineData("11:23:36", "vinte e três minutos")]
        [InlineData("12:24:18", "vinte e quatro minutos")]
        [InlineData("23:25:44", "vinte e cinco minutos")]
        [InlineData("04:26:48", "vinte e seis minutos")]
        [InlineData("07:27:24", "vinte e sete minutos")]
        [InlineData("09:28:18", "vinte e oito minutos")]
        [InlineData("01:29:58", "vinte e nove minutos")]
        [InlineData("03:30:18", "trinta minutos")]
        [InlineData("14:31:45", "trinta e um minutos")]
        [InlineData("06:32:18", "trinta e dois minutos")]
        [InlineData("03:33:33", "trinta e três minutos")]
        [InlineData("11:34:23", "trinta e quatro minutos")]
        [InlineData("04:35:24", "trinta e cinco minutos")]
        [InlineData("05:36:18", "trinta e seis minutos")]
        [InlineData("08:37:18", "trinta e sete minutos")]
        [InlineData("16:38:16", "trinta e oito minutos")]
        [InlineData("03:39:26", "trinta e nove minutos")]
        [InlineData("03:40:01", "quarenta minutos")]
        [InlineData("14:41:45", "quarenta e um minutos")]
        [InlineData("19:42:19", "quarenta e dois minutos")]
        [InlineData("22:43:12", "quarenta e três minutos")]
        [InlineData("11:44:23", "quarenta e quatro minutos")]
        [InlineData("04:45:24", "quarenta e cinco minutos")]
        [InlineData("05:46:18", "quarenta e seis minutos")]
        [InlineData("11:47:33", "quarenta e sete minutos")]
        [InlineData("16:48:32", "quarenta e oito minutos")]
        [InlineData("03:49:26", "quarenta e nove minutos")]
        [InlineData("03:50:01", "cinquenta minutos")]
        [InlineData("22:51:45", "cinquenta e um minutos")]
        [InlineData("19:52:01", "cinquenta e dois minutos")]
        [InlineData("14:53:26", "cinquenta e três minutos")]
        [InlineData("06:54:23", "cinquenta e quatro minutos")]
        [InlineData("01:55:03", "cinquenta e cinco minutos")]
        [InlineData("05:56:28", "cinquenta e seis minutos")]
        [InlineData("11:57:33", "cinquenta e sete minutos")]
        [InlineData("13:58:32", "cinquenta e oito minutos")]
        [InlineData("23:59:11", "cinquenta e nove minutos")]


        public void Validar_Todos_Os_Minutos_Por_Extenso(string hora, string minutoExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = Convert.ToDateTime(hora);

            //Act
            var minutoPorExtenso = relogio.ObterMinutoPorExtenso();

            //Assert
            minutoPorExtenso.Should().Be(minutoExtenso);
        }






    }
}
