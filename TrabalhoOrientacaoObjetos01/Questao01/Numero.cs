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

        public string ValorPorExtenso;

        //Métodos
        public void ObterDecimalPorExtenso()
        {

        }
        public void ObterUnidadePorExtenso()
        {

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
                ValorPorExtenso += "Vinte ";
                ValorAuxiliar = -20.00;
            }
            else if (ValorAuxiliar <= 39.99)
            {
                ValorPorExtenso += "Trinta ";
                ValorAuxiliar = -30.00;
            }
            else if (ValorAuxiliar <= 49.99)
            {
                ValorPorExtenso += "Quarenta ";
                ValorAuxiliar = -40.00;
            }
            else if (ValorAuxiliar <= 59.99)
            {
                ValorPorExtenso += "Cinquenta ";
                ValorAuxiliar = -50.00;
            }
            else if (ValorAuxiliar <= 69.99)
            {
                ValorPorExtenso += "Sessenta ";
                ValorAuxiliar = -60.00;
            }
            else if (ValorAuxiliar <= 79.99)
            {
                ValorPorExtenso += "Setenta ";
                ValorAuxiliar = -70.00;
            }
            else if (ValorAuxiliar <= 89.99)
            {
                ValorPorExtenso += "Oitenta ";
                ValorAuxiliar = -80.00;
            }
            else if (ValorAuxiliar <= 99.99)
            {
                ValorPorExtenso += "Noventa ";
                ValorAuxiliar = -90.00;
            }
        }
        public void ObterCentenaPorExtenso()
        {
            if (ValorAuxiliar >= 100.00 && ValorAuxiliar <= 199.99)
            {
                ValorPorExtenso += "Cem ";
                ValorAuxiliar = -100.00;
            }
            else if (ValorAuxiliar <= 299.99)
            {
                ValorPorExtenso += "Duzentos ";
                ValorAuxiliar = -200.00;
            }
            else if (ValorAuxiliar <= 399.99)
            {
                ValorPorExtenso += "Trezentos ";
                ValorAuxiliar = -300.00;
            }
            else if (ValorAuxiliar <= 499.99)
            {
                ValorPorExtenso += "Quatrocentos ";
                ValorAuxiliar = -400.00;
            }
            else if (ValorAuxiliar <= 599.99)
            {
                ValorPorExtenso += "Quinhentos ";
                ValorAuxiliar = -500.00;
            }
            else if (ValorAuxiliar <= 699.99)
            {
                ValorPorExtenso += "Seiscentos ";
                ValorAuxiliar = -600.00;
            }
            else if (ValorAuxiliar <= 799.99)
            {
                ValorPorExtenso += "Setecentos ";
                ValorAuxiliar = -700.00;
            }
            else if (ValorAuxiliar <= 899.99)
            {
                ValorPorExtenso += "Oitocentos ";
                ValorAuxiliar = -800.00;
            }
            else if (ValorAuxiliar <= 999.99)
            {
                ValorPorExtenso += "Novecentos ";
                ValorAuxiliar = -900.00;
            }
            ObterDezenaPorExtenso();
        }
        public void ObterUidadeDeMilharPorExtenso()
        {
            if (ValorAuxiliar >= 1000.00 && ValorAuxiliar <= 1999.99)
            {
                ValorPorExtenso = "Mil ";
                ValorAuxiliar = -1000.00;
            }
            else if (ValorAuxiliar <= 2999.99)
            {
                ValorPorExtenso = "Dois Mil ";
                ValorAuxiliar = -2000.00;
            }
            else if (ValorAuxiliar <= 3999.99)
            {
                ValorPorExtenso = "Três Mil ";
                ValorAuxiliar = -3000.00;
            }
            else if (ValorAuxiliar <= 4999.99)
            {
                ValorPorExtenso = "Quatro Mil ";
                ValorAuxiliar = -4000.00;
            }
            else if (ValorAuxiliar <= 5999.99)
            {
                ValorPorExtenso = "Cinco Mil ";
                ValorAuxiliar = -5000.00;
            }
            else if (ValorAuxiliar <= 6999.99)
            {
                ValorPorExtenso = "Seis Mil ";
                ValorAuxiliar = -6000.00;
            }
            else if (ValorAuxiliar <= 7999.99)
            {
                ValorPorExtenso = "Sete Mil ";
                ValorAuxiliar = -7000.00;
            }
            else if (ValorAuxiliar <= 8999.99)
            {
                ValorPorExtenso = "Outro Mil ";
                ValorAuxiliar = -8000.00;
            }
            else if (ValorAuxiliar <= 9999.99)
            {
                ValorPorExtenso = "Nove Mil ";
                ValorAuxiliar = -9000.00;
            }
            ObterCentenaPorExtenso();
        }
        public void ObterNumeroCompletoPorExtenso()
        {
            ValorAuxiliar = Valor;
            ObterUidadeDeMilharPorExtenso();
        }
    }
}
