using FluentAssertions;
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
        [InlineData("2005/02/24", "fevereiro")]
        [InlineData("2005/03/24", "março")]
        [InlineData("2005/04/24", "abril")]
        [InlineData("2005/05/24", "maio")]
        [InlineData("2005/06/24", "junho")]
        [InlineData("2005/07/24", "julho")]
        [InlineData("2005/08/24", "agosto")]
        [InlineData("2005/09/24", "setembro")]
        [InlineData("2005/10/24", "outubro")]
        [InlineData("2005/11/24", "novembro")]
        [InlineData("2005/12/24", "dezembro")]
        public void Validar_ObterMesPorExtenso(string mes, string resultado)
        {
            // Arrange
            var calendario = new Calendario();
            calendario.Data = Convert.ToDateTime(mes);

            // Act
            var obterMes = calendario.ObterMesPorExtenso();

            // Assert
            obterMes.Should().Be(resultado);
        }

        [Theory]
        [InlineData("2005/01/01", "um")]
        [InlineData("2005/01/02", "dois")]
        [InlineData("2005/01/03", "três")]
        [InlineData("2005/01/04", "quatro")]
        [InlineData("2005/01/05", "cinco")]
        [InlineData("2005/01/06", "seis")]
        [InlineData("2005/01/07", "sete")]
        [InlineData("2005/01/08", "oito")]
        [InlineData("2005/01/09", "nove")]
        [InlineData("2005/01/10", "dez")]
        [InlineData("2005/01/11", "onze")]
        [InlineData("2005/01/12", "doze")]
        [InlineData("2005/01/13", "treze")]
        [InlineData("2005/01/14", "quatorze")]
        [InlineData("2005/01/15", "quinze")]
        [InlineData("2005/01/16", "dezesseis")]
        [InlineData("2005/01/17", "dezessete")]
        [InlineData("2005/01/18", "dezoito")]
        [InlineData("2005/01/19", "dezenove")]
        [InlineData("2005/01/20", "vinte")]
        [InlineData("2005/01/21", "vinte e um")]
        [InlineData("2005/01/22", "vinte e dois")]
        [InlineData("2005/01/23", "vinte e três")]
        [InlineData("2005/01/24", "vinte e quatro")]
        [InlineData("2005/01/25", "vinte e cinco")]
        [InlineData("2005/01/26", "vinte e seis")]
        [InlineData("2005/01/27", "vinte e sete")]
        [InlineData("2005/01/28", "vinte e oito")]
        [InlineData("2005/01/29", "vinte e nove")]
        [InlineData("2005/01/30", "trinta")]
        [InlineData("2005/01/31", "trinta e um")]
        public void Validar_ObterDiaPorExtenso(string dia, string resultado)
        {
            // Arrange
            var calendario = new Calendario();
            calendario.Data = Convert.ToDateTime(dia);

            // Act
            var obterDia = calendario.ObterDiaPorExtenso();

            // Assert
            obterDia.Should().Be(resultado);
        }

        [Theory]
        [InlineData("1970/10/24", "mil novecentos e setenta")]
        [InlineData("1971/10/24", "mil novecentos e setenta e um")]
        [InlineData("1972/10/24", "mil novecentos e setenta e dois")]
        [InlineData("1973/10/24", "mil novecentos e setenta e três")]
        [InlineData("1974/10/24", "mil novecentos e setenta e quatro")]
        [InlineData("1975/10/24", "mil novecentos e setenta e cinco")]
        [InlineData("1976/10/24", "mil novecentos e setenta e seis")]
        [InlineData("1977/10/24", "mil novecentos e setenta e sete")]
        [InlineData("1978/10/24", "mil novecentos e setenta e oito")]
        [InlineData("1979/10/24", "mil novecentos e setenta e nove")]
        [InlineData("1980/10/24", "mil novecentos e oitenta")]
        [InlineData("1981/10/24", "mil novecentos e oitenta e um")]
        [InlineData("1982/10/24", "mil novecentos e oitenta e dois")]
        [InlineData("1983/10/24", "mil novecentos e oitenta e três")]
        [InlineData("1984/10/24", "mil novecentos e oitenta e quatro")]
        [InlineData("1985/10/24", "mil novecentos e oitenta e cinco")]
        [InlineData("1986/10/24", "mil novecentos e oitenta e seis")]
        [InlineData("1987/10/24", "mil novecentos e oitenta e sete")]
        [InlineData("1988/10/24", "mil novecentos e oitenta e oito")]
        [InlineData("1989/10/24", "mil novecentos e oitenta e nove")]
        [InlineData("1990/10/24", "mil novecentos e noventa")]
        [InlineData("1991/10/24", "mil novecentos e noventa e um")]
        [InlineData("1992/10/24", "mil novecentos e noventa e dois")]
        [InlineData("1993/10/24", "mil novecentos e noventa e três")]
        [InlineData("1994/10/24", "mil novecentos e noventa e quatro")]
        [InlineData("1995/10/24", "mil novecentos e noventa e cinco")]
        [InlineData("1996/10/24", "mil novecentos e noventa e seis")]
        [InlineData("1997/10/24", "mil novecentos e noventa e sete")]
        [InlineData("1998/10/24", "mil novecentos e noventa e oito")]
        [InlineData("1999/10/24", "mil novecentos e noventa e nove")]
        [InlineData("2000/10/24", "dois mil ")]
        [InlineData("2001/10/24", "dois mil e um")]
        [InlineData("2002/10/24", "dois mil e dois")]
        [InlineData("2003/10/24", "dois mil e tres")]
        [InlineData("2004/10/24", "dois mil e quatro")]
        [InlineData("2005/10/24", "dois mil e cinco")]
        [InlineData("2006/10/24", "dois mil e seis")]
        [InlineData("2007/10/24", "dois mil e sete")]
        [InlineData("2008/10/24", "dois mil e oito")]
        [InlineData("2009/10/24", "dois mil e nove")]
        [InlineData("2010/10/24", "dois mil e dez")]
        [InlineData("2011/10/24", "dois mil e onze")]
        [InlineData("2012/10/24", "dois mil e doze")]
        [InlineData("2013/10/24", "dois mil e treze")]
        [InlineData("2014/10/24", "dois mil e quatorze")]
        [InlineData("2015/10/24", "dois mil e quinze")]
        [InlineData("2016/10/24", "dois mil e dezesseis")]
        [InlineData("2017/10/24", "dois mil e dezessete")]
        [InlineData("2018/10/24", "dois mil e dezoito")]
        [InlineData("2019/10/24", "dois mil e dezenove")]
        [InlineData("2020/10/24", "dois mil e vinte")]
        [InlineData("2021/10/24", "dois mil e vinte um")]
        [InlineData("2022/10/24", "dois mil e vinte dois")]
        [InlineData("2023/10/24", "dois mil e vinte três")]
        [InlineData("2024/10/24", "dois mil e vinte quatro")]
        [InlineData("2025/10/24", "dois mil e vinte cinco")]
        [InlineData("2026/10/24", "dois mil e vinte seis")]
        [InlineData("2027/10/24", "dois mil e vinte sete")]
        [InlineData("2028/10/24", "dois mil e vinte oito")]
        [InlineData("2029/10/24", "dois mil e vinte nove")]
        [InlineData("2030/10/24", "dois mil e trinta")]


        public void Validar_ObterAnoPorExtenso(string ano, string resultado)
        {
            // Arrange
            var calendario = new Calendario();
            calendario.Data = Convert.ToDateTime(ano);

            // Act
            var obterAno = calendario.ObterAnoPorExtenso();

            // Assert
            obterAno.Should().Be(resultado);
        }
    }
}
