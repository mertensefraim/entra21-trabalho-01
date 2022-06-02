using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class Numero
    {
        //Propriedades
        public double Valor;
        public double ValorAuxiliar;
        public string ValorPorExtenso = "";

        //Métodos
        public void ObterDecimalPorExtenso()
        {
            if (ValorAuxiliar != 0.00)
            {
                string converterParaInteiro = ValorAuxiliar + "";
                var posicaoPonto = converterParaInteiro.IndexOf(".");
                ValorAuxiliar = Convert.ToDouble(converterParaInteiro.Substring(posicaoPonto,2));
                ValorPorExtenso += "e ";
                ObterDezenaPorExtenso();
            }
        }
        public void ObterUnidadePorExtenso()
        {
            if (ValorAuxiliar >= 1.00 && ValorAuxiliar <= 1.99)
            {
                ValorPorExtenso += "um ";
                ValorAuxiliar = -1.00;
            }
            else if (ValorAuxiliar <= 2.99)
            {
                ValorPorExtenso += "dois ";
                ValorAuxiliar = -2.00;
            }
            else if (ValorAuxiliar <= 3.99)
            {
                ValorPorExtenso += "três ";
                ValorAuxiliar = -3.00;
            }
            else if (ValorAuxiliar <= 4.99)
            {
                ValorPorExtenso += "quatro ";
                ValorAuxiliar = -4.00;
            }
            else if (ValorAuxiliar <= 5.99)
            {
                ValorPorExtenso += "cinso ";
                ValorAuxiliar = -5.00;
            }
            else if (ValorAuxiliar <= 6.99)
            {
                ValorPorExtenso += "seis ";
                ValorAuxiliar = -6.00;
            }
            else if (ValorAuxiliar <= 7.99)
            {
                ValorPorExtenso += "sete ";
                ValorAuxiliar = -7.00;
            }
            else if (ValorAuxiliar <= 8.99)
            {
                ValorPorExtenso += "oito ";
                ValorAuxiliar = -8.00;
            }
            else if (ValorAuxiliar <= 9.99)
            {
                ValorPorExtenso += "nove ";
                ValorAuxiliar = -9.00;
            }
            ObterDecimalPorExtenso();
        }
        public void ObterDezenaPorExtenso()
        {
            if (ValorAuxiliar >= 10.00 && ValorAuxiliar <= 19.99)
            {
                if (ValorAuxiliar >= 10.00 && ValorAuxiliar <= 10.99)
                {
                    ValorPorExtenso += "dez ";
                    ValorAuxiliar = -10.00;
                }
                else if (ValorAuxiliar <= 11.99)
                {
                    ValorPorExtenso += "onze ";
                    ValorAuxiliar = -11.00;
                }
                else if (ValorAuxiliar <= 12.99)
                {
                    ValorPorExtenso += "doze ";
                    ValorAuxiliar = -12.00;
                }
                else if (ValorAuxiliar <= 13.99)
                {
                    ValorPorExtenso += "treze ";
                    ValorAuxiliar = -13.00;
                }
                else if (ValorAuxiliar <= 14.99)
                {
                    ValorPorExtenso += "catorze ";
                    ValorAuxiliar = -14.00;
                }
                else if (ValorAuxiliar <= 15.99)
                {
                    ValorPorExtenso += "quinze ";
                    ValorAuxiliar = -15.00;
                }
                else if (ValorAuxiliar <= 16.99)
                {
                    ValorPorExtenso += "dezesseis ";
                    ValorAuxiliar = -16.00;
                }
                else if (ValorAuxiliar <= 17.99)
                {
                    ValorPorExtenso += "dezessete ";
                    ValorAuxiliar = -17.00;
                }
                else if (ValorAuxiliar <= 18.99)
                {
                    ValorPorExtenso += "dezoito ";
                    ValorAuxiliar = -18.00;
                }
                else if (ValorAuxiliar <= 19.99)
                {
                    ValorPorExtenso += "dezenove ";
                    ValorAuxiliar = -19.00;
                }
            }
            else if (ValorAuxiliar <= 29.99)
            {
                ValorPorExtenso += "vinte ";
                ValorAuxiliar = -20.00;
            }
            else if (ValorAuxiliar <= 39.99)
            {
                ValorPorExtenso += "trinta ";
                ValorAuxiliar = -30.00;
            }
            else if (ValorAuxiliar <= 49.99)
            {
                ValorPorExtenso += "quarenta ";
                ValorAuxiliar = -40.00;
            }
            else if (ValorAuxiliar <= 59.99)
            {
                ValorPorExtenso += "cinquenta ";
                ValorAuxiliar = -50.00;
            }
            else if (ValorAuxiliar <= 69.99)
            {
                ValorPorExtenso += "sessenta ";
                ValorAuxiliar = -60.00;
            }
            else if (ValorAuxiliar <= 79.99)
            {
                ValorPorExtenso += "setenta ";
                ValorAuxiliar = -70.00;
            }
            else if (ValorAuxiliar <= 89.99)
            {
                ValorPorExtenso += "oitenta ";
                ValorAuxiliar = -80.00;
            }
            else if (ValorAuxiliar <= 99.99)
            {
                ValorPorExtenso += "noventa ";
                ValorAuxiliar = -90.00;
            }
            ObterUnidadePorExtenso();
        }
        public void ObterCentenaPorExtenso()
        {
            if (ValorAuxiliar >= 100.00 && ValorAuxiliar <= 199.99)
            {
                ValorPorExtenso += "cem ";
                ValorAuxiliar = -100.00;
            }
            else if (ValorAuxiliar <= 299.99)
            {
                ValorPorExtenso += "duzentos ";
                ValorAuxiliar = -200.00;
            }
            else if (ValorAuxiliar <= 399.99)
            {
                ValorPorExtenso += "trezentos ";
                ValorAuxiliar = -300.00;
            }
            else if (ValorAuxiliar <= 499.99)
            {
                ValorPorExtenso += "quatrocentos ";
                ValorAuxiliar = -400.00;
            }
            else if (ValorAuxiliar <= 599.99)
            {
                ValorPorExtenso += "quinhentos ";
                ValorAuxiliar = -500.00;
            }
            else if (ValorAuxiliar <= 699.99)
            {
                ValorPorExtenso += "seiscentos ";
                ValorAuxiliar = -600.00;
            }
            else if (ValorAuxiliar <= 799.99)
            {
                ValorPorExtenso += "setecentos ";
                ValorAuxiliar = -700.00;
            }
            else if (ValorAuxiliar <= 899.99)
            {
                ValorPorExtenso += "oitocentos ";
                ValorAuxiliar = -800.00;
            }
            else if (ValorAuxiliar <= 999.99)
            {
                ValorPorExtenso += "novecentos ";
                ValorAuxiliar = -900.00;
            }
            ObterDezenaPorExtenso();
        }
        public void ObterUidadeDeMilharPorExtenso()
        {
            if (ValorAuxiliar >= 1000.00 && ValorAuxiliar <= 1999.99)
            {
                ValorPorExtenso = "mil ";
                ValorAuxiliar = -1000.00;
            }
            else if (ValorAuxiliar <= 2999.99)
            {
                ValorPorExtenso = "dois mil ";
                ValorAuxiliar = -2000.00;
            }
            else if (ValorAuxiliar <= 3999.99)
            {
                ValorPorExtenso = "três mil ";
                ValorAuxiliar = -3000.00;
            }
            else if (ValorAuxiliar <= 4999.99)
            {
                ValorPorExtenso = "quatro mil ";
                ValorAuxiliar = -4000.00;
            }
            else if (ValorAuxiliar <= 5999.99)
            {
                ValorPorExtenso = "cinco mil ";
                ValorAuxiliar = -5000.00;
            }
            else if (ValorAuxiliar <= 6999.99)
            {
                ValorPorExtenso = "seis mil ";
                ValorAuxiliar = -6000.00;
            }
            else if (ValorAuxiliar <= 7999.99)
            {
                ValorPorExtenso = "sete mil ";
                ValorAuxiliar = -7000.00;
            }
            else if (ValorAuxiliar <= 8999.99)
            {
                ValorPorExtenso = "oito mil ";
                ValorAuxiliar = -8000.00;
            }
            else if (ValorAuxiliar <= 9999.99)
            {
                ValorPorExtenso = "nove mil ";
                ValorAuxiliar = -9000.00;
            }
            ObterCentenaPorExtenso();
        }
        public string ObterNumeroCompletoPorExtenso()
        {
            ValorAuxiliar = Valor;
            ObterUidadeDeMilharPorExtenso();
            return ValorPorExtenso;
        }
    }
}
