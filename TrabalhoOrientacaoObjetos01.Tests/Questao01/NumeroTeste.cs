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
        [InlineData(0.00, "zero")]
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
        [InlineData(0.14, "catorze centésimos")]
        [InlineData(0.15, "quinze centésimos")]
        [InlineData(0.16, "dezesseis centésimos")]
        [InlineData(0.17, "dezessete centésimos")]
        [InlineData(0.18, "dezoito centésimos")]
        [InlineData(0.19, "dezenove centésimos")]
        [InlineData(0.20, "vinte centésimos")]
        [InlineData(0.21, "vinte e um centésimos")]
        [InlineData(0.22, "vinte e dois centésimos")]
        [InlineData(0.23, "vinte e três centésimos")]
        [InlineData(0.24, "vinte e quatro centésimos")]
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
        [InlineData(0.40, "quarenta centésimos")]
        [InlineData(0.41, "quarenta e um centésimos")]
        [InlineData(0.42, "quarenta e dois centésimos")]
        [InlineData(0.43, "quarenta e três centésimos")]
        [InlineData(0.44, "quarenta e quatro centésimos")]
        [InlineData(0.45, "quarenta e cinco centésimos")]
        [InlineData(0.46, "quarenta e seis centésimos")]
        [InlineData(0.47, "quarenta e sete centésimos")]
        [InlineData(0.48, "quarenta e oito centésimos")]
        [InlineData(0.49, "quarenta e nove centésimos")]
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
        [InlineData(0.81, "oitenta e um centésimos")]
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
            numero.ValorAuxiliar = valor;
            numero.Valor = valor;
            // Act
            var numeroPorExtenso = numero.ObterDecimalPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(valorPorExtenso);

        }

        [Theory]
        [InlineData(0.00, "zero")]
        [InlineData(1.00, "um ")]
        [InlineData(2.00, "dois ")]
        [InlineData(3.00, "três ")]
        [InlineData(4.00, "quatro ")]
        [InlineData(5.00, "cinco ")]
        [InlineData(6.00, "seis ")]
        [InlineData(7.00, "sete ")]
        [InlineData(8.00, "oito ")]
        [InlineData(9.00, "nove ")]
        [InlineData(10.00, "dez ")]
        [InlineData(11.00, "onze ")]
        [InlineData(12.00, "doze ")]
        [InlineData(13.00, "treze ")]
        [InlineData(14.00, "catorze ")]
        [InlineData(15.00, "quinze ")]
        [InlineData(16.00, "dezesseis ")]
        [InlineData(17.00, "dezessete ")]
        [InlineData(18.00, "dezoito ")]
        [InlineData(19.00, "dezenove ")]
        [InlineData(20.00, "vinte ")]
        [InlineData(21.00, "vinte e um ")]
        [InlineData(22.00, "vinte e dois ")]
        [InlineData(23.00, "vinte e três ")]
        [InlineData(24.00, "vinte e quatro ")]
        [InlineData(25.00, "vinte e cinco ")]
        [InlineData(26.00, "vinte e seis ")]
        [InlineData(27.00, "vinte e sete ")]
        [InlineData(28.00, "vinte e oito ")]
        [InlineData(29.00, "vinte e nove ")]
        [InlineData(30.00, "trinta ")]
        [InlineData(31.00, "trinta e um ")]
        [InlineData(32.00, "trinta e dois ")]
        [InlineData(33.00, "trinta e três ")]
        [InlineData(34.00, "trinta e quatro ")]
        [InlineData(35.00, "trinta e cinco ")]
        [InlineData(36.00, "trinta e seis ")]
        [InlineData(37.00, "trinta e sete ")]
        [InlineData(38.00, "trinta e oito ")]
        [InlineData(39.00, "trinta e nove ")]
        [InlineData(40.00, "quarenta ")]
        [InlineData(41.00, "quarenta e um ")]
        [InlineData(42.00, "quarenta e dois ")]
        [InlineData(43.00, "quarenta e três ")]
        [InlineData(44.00, "quarenta e quatro ")]
        [InlineData(45.00, "quarenta e cinco ")]
        [InlineData(46.00, "quarenta e seis ")]
        [InlineData(47.00, "quarenta e sete ")]
        [InlineData(48.00, "quarenta e oito ")]
        [InlineData(49.00, "quarenta e nove ")]
        [InlineData(50.00, "cinquenta ")]
        [InlineData(51.00, "cinquenta e um ")]
        [InlineData(52.00, "cinquenta e dois ")]
        [InlineData(53.00, "cinquenta e três ")]
        [InlineData(54.00, "cinquenta e quatro ")]
        [InlineData(55.00, "cinquenta e cinco ")]
        [InlineData(56.00, "cinquenta e seis ")]
        [InlineData(57.00, "cinquenta e sete ")]
        [InlineData(58.00, "cinquenta e oito ")]
        [InlineData(59.00, "cinquenta e nove ")]
        [InlineData(60.00, "sessenta ")]
        [InlineData(61.00, "sessenta e um ")]
        [InlineData(62.00, "sessenta e dois ")]
        [InlineData(63.00, "sessenta e três ")]
        [InlineData(64.00, "sessenta e quatro ")]
        [InlineData(65.00, "sessenta e cinco ")]
        [InlineData(66.00, "sessenta e seis ")]
        [InlineData(67.00, "sessenta e sete ")]
        [InlineData(68.00, "sessenta e oito ")]
        [InlineData(69.00, "sessenta e nove ")]
        [InlineData(70.00, "setenta ")]
        [InlineData(71.00, "setenta e um ")]
        [InlineData(72.00, "setenta e dois ")]
        [InlineData(73.00, "setenta e três ")]
        [InlineData(74.00, "setenta e quatro ")]
        [InlineData(75.00, "setenta e cinco ")]
        [InlineData(76.00, "setenta e seis ")]
        [InlineData(77.00, "setenta e sete ")]
        [InlineData(78.00, "setenta e oito ")]
        [InlineData(79.00, "setenta e nove ")]
        [InlineData(80.00, "oitenta ")]
        [InlineData(81.00, "oitenta e um ")]
        [InlineData(82.00, "oitenta e dois ")]
        [InlineData(83.00, "oitenta e três ")]
        [InlineData(84.00, "oitenta e quatro ")]
        [InlineData(85.00, "oitenta e cinco ")]
        [InlineData(86.00, "oitenta e seis ")]
        [InlineData(87.00, "oitenta e sete ")]
        [InlineData(88.00, "oitenta e oito ")]
        [InlineData(89.00, "oitenta e nove ")]
        [InlineData(90.00, "noventa ")]
        [InlineData(91.00, "noventa e um ")]
        [InlineData(92.00, "noventa e dois ")]
        [InlineData(93.00, "noventa e três ")]
        [InlineData(94.00, "noventa e quatro ")]
        [InlineData(95.00, "noventa e cinco ")]
        [InlineData(96.00, "noventa e seis ")]
        [InlineData(97.00, "noventa e sete ")]
        [InlineData(98.00, "noventa e oito ")]
        [InlineData(99.00, "noventa e nove ")]
        public void Certificando_Retorno_ObterDezenaPorExtenso(double valor, string valorPorExtenso)
        {           // Arran
            var numero = new Numero();
            numero.ValorAuxiliar = valor;
            numero.Valor = valor;
            // Act
            var numeroPorExtenso = numero.ObterDezenaPorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(valorPorExtenso);

        }

        [Theory]
        [InlineData(0.00, "zero")]
        [InlineData(1.00, "um ")]
        [InlineData(2.00, "dois ")]
        [InlineData(3.00, "três ")]
        [InlineData(4.00, "quatro ")]
        [InlineData(5.00, "cinco ")]
        [InlineData(6.00, "seis ")]
        [InlineData(7.00, "sete ")]
        [InlineData(8.00, "oito ")]
        [InlineData(9.00, "nove ")]
        public void Certificando_Retorno_ObterUnidadePorExtenso(double valor, string valorPorExtenso)
        {           // Arran
            var numero = new Numero();
            numero.ValorAuxiliar = valor;
            numero.Valor = valor;
            // Act
            var numeroPorExtenso = numero.ObterUnidadePorExtenso();

            // Assert
            numeroPorExtenso.Should().Be(valorPorExtenso);

        }

    }
}
