using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Tests.Questao01
{
    public class NumeroTeste
    {

        [Theory]
        [InlineData(0.01, "um centésimos")]
        [InlineData(0.02, "dois centésimos")]
        [InlineData(0.03, "três centésimos")]
        [InlineData(0.04, "quatro centésimos")]
        [InlineData(0.05, "cinco centésimos")]
        [InlineData(0.06, "seis centésimos")]
        [InlineData(0.07, "sete centésimos")]
        [InlineData(0.08, "oito centésimos")]
        [InlineData(0.09, "nove centésimos")]
        [InlineData(0.10, "dez centésimos")]
        [InlineData(0.11, "onze centésimos")]
        [InlineData(0.12, "doze centésimos")]
        [InlineData(0.13, "treze centésimos")]
        [InlineData(0.14, "duatorze centésimos")]
        [InlineData(0.15, "duinze centésimos")]
        [InlineData(0.16, "dezesseis centésimos")]
        [InlineData(0.17, "dezessete centésimos")]
        [InlineData(0.18, "dezoito centésimos")]
        [InlineData(0.19, "dezenove centésimos")]
        [InlineData(0.20, "vinte centésimos")]
        [InlineData(0.21, "vinte e um centésimos")]
        [InlineData(0.22, "vinte e dois centésimos")]
        [InlineData(0.23, "vinte e três centésimos")]
        [InlineData(0.24, "vinte e quatr centésimos")]
        [InlineData(0.25, "vinte e cinco centésimos")]
        [InlineData(0.26, "vinte e seis centésimos")]
        [InlineData(0.27, "vinte e sete centésimos")]
        [InlineData(0.28, "vinte e oito centésimos")]
        [InlineData(0.29, "vinte e nove centésimos")]
        [InlineData(0.30, "trinta centésimos")]
        [InlineData(0.31, "trinta e um centésimos")]
        [InlineData(0.32, "trinta e dois centésimos")]
        [InlineData(0.33, "trinta e três centésimos")]
        [InlineData(0.34, "trinta e quatro centésimos")]
        [InlineData(0.35, "trinta e cinco centésimos")]
        [InlineData(0.36, "trinta e seis centésimos")]
        [InlineData(0.37, "trinta e sete centésimos")]
        [InlineData(0.38, "trinta e oito centésimos")]
        [InlineData(0.39, "trinta e nove centésimos")]
        [InlineData(0.40, "carenta centésimos")]
        [InlineData(0.41, "carenta e um centésimos")]
        [InlineData(0.42, "carenta e dois centésimos")]
        [InlineData(0.43, "carenta e três centésimos")]
        [InlineData(0.44, "carenta e quatro centésimos")]
        [InlineData(0.45, "carenta e cinco centésimos")]
        [InlineData(0.46, "carenta e seis centésimos")]
        [InlineData(0.47, "carenta e sete centésimos")]
        [InlineData(0.48, "carenta e oito centésimos")]
        [InlineData(0.49, "carenta e nove centésimos")]
        [InlineData(0.50, "cinquenta centésimos")]
        [InlineData(0.51, "cinquenta e um centésimos")]
        [InlineData(0.52, "cinquenta e dois centésimos")]
        [InlineData(0.53, "cinquenta e três centésimos")]
        [InlineData(0.54, "cinquenta e quatro centésimos")]
        [InlineData(0.55, "cinquenta e cinco centésimos")]
        [InlineData(0.56, "cinquenta e seis centésimos")]
        [InlineData(0.57, "cinquenta e sete centésimos")]
        [InlineData(0.58, "cinquenta e oito centésimos")]
        [InlineData(0.59, "cinquenta e nove centésimos")]
        [InlineData(0.60, "sessenta centésimos")]
        [InlineData(0.61, "sessenta e um centésimos")]
        [InlineData(0.62, "sessenta e dois centésimos")]
        [InlineData(0.63, "sessenta e três centésimos")]
        [InlineData(0.64, "sessenta e quatro centésimos")]
        [InlineData(0.65, "sessenta e cinco centésimos")]
        [InlineData(0.66, "sessenta e seis centésimos")]
        [InlineData(0.67, "sessenta e sete centésimos")]
        [InlineData(0.68, "sessenta e oito centésimos")]
        [InlineData(0.69, "sessenta e nove centésimos")]
        [InlineData(0.70, "setenta centésimos")]
        [InlineData(0.71, "setenta e um centésimos")]
        [InlineData(0.72, "setenta e dois centésimos")]
        [InlineData(0.73, "setenta e três centésimos")]
        [InlineData(0.74, "setenta e quatro centésimos")]
        [InlineData(0.75, "setenta e cinco centésimos")]
        [InlineData(0.76, "setenta e seis centésimos")]
        [InlineData(0.77, "setenta e sete centésimos")]
        [InlineData(0.78, "setenta e oito centésimos")]
        [InlineData(0.79, "setenta e nove centésimos")]
        [InlineData(0.80, "oitenta centésimos")]
        [InlineData(0.81, "oitenta e um  centésimos")]
        [InlineData(0.82, "oitenta e dois centésimos")]
        [InlineData(0.83, "oitenta e três centésimos")]
        [InlineData(0.84, "oitenta e quatro centésimos")]
        [InlineData(0.85, "oitenta e cinco centésimos")]
        [InlineData(0.86, "oitenta e seis centésimos")]
        [InlineData(0.87, "oitenta e sete centésimos")]
        [InlineData(0.88, "oitenta e oito centésimos")]
        [InlineData(0.89, "oitenta e nove centésimos")]
        [InlineData(0.90, "noventa centésimos")]
        [InlineData(0.91, "noventa e um centésimos")]
        [InlineData(0.92, "noventa e dois centésimos")]
        [InlineData(0.93, "noventa e três centésimos")]
        [InlineData(0.94, "noventa e quatro centésimos")]
        [InlineData(0.95, "noventa e cinco centésimos")]
        [InlineData(0.96, "noventa e seis centésimos")]
        [InlineData(0.97, "noventa e sete centésimos")]
        [InlineData(0.98, "noventa e oito centésimos")]
        [InlineData(0.99, "noventa e nove centésimos")]

        public void Certificando_Retorno_ObterDecimalPorExtenso(double valor, string valorPorExtenso)
        {
            // Arrange
            var numero = new Numero();
            numero.Valor = valor;

            // Act
            var numeroPorExtenso = numero.ObterDecimalPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(valorPorExtenso);

        }
    }
}
