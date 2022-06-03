using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    //Leonardo Pokrewecky Salvador
    public class Numero
    {
        //Propriedades
        public double Valor;
        public double ValorAuxiliar;
        private bool VerificarCentenaDezena = false;
        public string ValorPorExtenso = "";

        //Métodos
        public string ObterDecimalPorExtenso()
        {
            if (ValorAuxiliar > 0.00)
            {
                ValorAuxiliar = Math.Round((ValorAuxiliar * 100), 2);
                VerificarCentenaDezena = false;
                if (Valor > 0.99)
                {
                    ValorPorExtenso += "e ";
                }
                ObterDezenaPorExtenso();
                ValorPorExtenso += "centésimos";
            }
            else if (Valor == 0.00)
            {
                ValorPorExtenso = "zero";
            }
            return ValorPorExtenso;
        }
        public string ObterUnidadePorExtenso()
        {
            if (VerificarCentenaDezena == true && ValorAuxiliar > 0.00)
            {
                ValorPorExtenso += "e ";
                VerificarCentenaDezena = false;
            }
            if (ValorAuxiliar >= 1.00)
            {
                if (ValorAuxiliar >= 1.00 && ValorAuxiliar <= 1.99)
                {
                    ValorPorExtenso += "um ";
                    ValorAuxiliar += -1;
                }
                else if (ValorAuxiliar <= 2.99)
                {
                    ValorPorExtenso += "dois ";
                    ValorAuxiliar += -2;
                }
                else if (ValorAuxiliar <= 3.99)
                {
                    ValorPorExtenso += "três ";
                    ValorAuxiliar += -3;
                }
                else if (ValorAuxiliar <= 4.99)
                {
                    ValorPorExtenso += "quatro ";
                    ValorAuxiliar += -4.00;
                }
                else if (ValorAuxiliar <= 5.99)
                {
                    ValorPorExtenso += "cinco ";
                    ValorAuxiliar += -5;
                }
                else if (ValorAuxiliar <= 6.99)
                {
                    ValorPorExtenso += "seis ";
                    ValorAuxiliar += -6.00;
                }
                else if (ValorAuxiliar <= 7.99)
                {
                    ValorPorExtenso += "sete ";
                    ValorAuxiliar += -7;
                }
                else if (ValorAuxiliar <= 8.99)
                {
                    ValorPorExtenso += "oito ";
                    ValorAuxiliar += -8;
                }
                else if (ValorAuxiliar <= 9.99)
                {
                    ValorPorExtenso += "nove ";
                    ValorAuxiliar += -9;
                }
            }
            ObterDecimalPorExtenso();
            return ValorPorExtenso;
        }
        public string ObterDezenaPorExtenso()
        {
            if (VerificarCentenaDezena == true && ValorAuxiliar > 0.00)
            {
                ValorPorExtenso += "e ";
                VerificarCentenaDezena = false;
            }
            if (ValorAuxiliar >= 10.00)
            {
                if (ValorAuxiliar <= 19.99)
                {
                    if (ValorAuxiliar >= 10.00 && ValorAuxiliar <= 10.99)
                    {
                        ValorPorExtenso += "dez ";
                        ValorAuxiliar += -10;
                    }
                    else if (ValorAuxiliar <= 11.99)
                    {
                        ValorPorExtenso += "onze ";
                        ValorAuxiliar += -11;
                    }
                    else if (ValorAuxiliar <= 12.99)
                    {
                        ValorPorExtenso += "doze ";
                        ValorAuxiliar += -12;
                    }
                    else if (ValorAuxiliar <= 13.99)
                    {
                        ValorPorExtenso += "treze ";
                        ValorAuxiliar += -13;
                    }
                    else if (ValorAuxiliar <= 14.99)
                    {
                        ValorPorExtenso += "catorze ";
                        ValorAuxiliar += -14;
                    }
                    else if (ValorAuxiliar <= 15.99)
                    {
                        ValorPorExtenso += "quinze ";
                        ValorAuxiliar += -15;
                    }
                    else if (ValorAuxiliar <= 16.99)
                    {
                        ValorPorExtenso += "dezesseis ";
                        ValorAuxiliar += -16;
                    }
                    else if (ValorAuxiliar <= 17.99)
                    {
                        ValorPorExtenso += "dezessete ";
                        ValorAuxiliar += -17;
                    }
                    else if (ValorAuxiliar <= 18.99)
                    {
                        ValorPorExtenso += "dezoito ";
                        ValorAuxiliar += -18;
                    }
                    else if (ValorAuxiliar <= 19.99)
                    {
                        ValorPorExtenso += "dezenove ";
                        ValorAuxiliar += -19;
                    }
                }
                else if (ValorAuxiliar <= 29.99)
                {
                    ValorPorExtenso += "vinte ";
                    ValorAuxiliar += -20;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 39.99)
                {
                    ValorPorExtenso += "trinta ";
                    ValorAuxiliar += -30;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 49.99)
                {
                    ValorPorExtenso += "quarenta ";
                    ValorAuxiliar += -40;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 59.99)
                {
                    ValorPorExtenso += "cinquenta ";
                    ValorAuxiliar += -50;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 69.99)
                {
                    ValorPorExtenso += "sessenta ";
                    ValorAuxiliar += -60;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 79.99)
                {
                    ValorPorExtenso += "setenta ";
                    ValorAuxiliar += -70;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 89.99)
                {
                    ValorPorExtenso += "oitenta ";
                    ValorAuxiliar += -80;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 99.99)
                {
                    ValorPorExtenso += "noventa ";
                    ValorAuxiliar += -90;
                    VerificarCentenaDezena = true;
                }
            }
            ObterUnidadePorExtenso();
            return ValorPorExtenso;
        }
        public string ObterCentenaPorExtenso()
        {
            if (ValorAuxiliar >= 100.00)
            {
                if (ValorAuxiliar <= 199.99)
                {
                    ValorAuxiliar += -100;
                    if (ValorAuxiliar < 1)
                    {
                        ValorPorExtenso += "cem ";
                    }
                    else
                    {
                        ValorPorExtenso += "cento ";
                        VerificarCentenaDezena = true;
                    }
                }
                else if (ValorAuxiliar <= 299.99)
                {
                    ValorPorExtenso += "duzentos ";
                    ValorAuxiliar += -200;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 399.99)
                {
                    ValorPorExtenso += "trezentos ";
                    ValorAuxiliar += -300;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 499.99)
                {
                    ValorPorExtenso += "quatrocentos ";
                    ValorAuxiliar += -400;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 599.99)
                {
                    ValorPorExtenso += "quinhentos ";
                    ValorAuxiliar += -500;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 699.99)
                {
                    ValorPorExtenso += "seiscentos ";
                    ValorAuxiliar += -600;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 799.99)
                {
                    ValorPorExtenso += "setecentos ";
                    ValorAuxiliar += -700;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 899.99)
                {
                    ValorPorExtenso += "oitocentos ";
                    ValorAuxiliar += -800;
                    VerificarCentenaDezena = true;
                }
                else if (ValorAuxiliar <= 999.99)
                {
                    ValorPorExtenso += "novecentos ";
                    ValorAuxiliar += -900;
                    VerificarCentenaDezena = true;
                }
            }
            ObterDezenaPorExtenso();
            return ValorPorExtenso;
        }
        public string ObterUidadeDeMilharPorExtenso()
        {
            if (ValorAuxiliar >= 1000.00)
            {
                if (ValorAuxiliar <= 1999.99)
                {
                    ValorPorExtenso = "mil ";
                    ValorAuxiliar += -1000;
                }
                else if (ValorAuxiliar <= 2999.99)
                {
                    ValorPorExtenso = "dois mil ";
                    ValorAuxiliar += -2000;
                }
                else if (ValorAuxiliar <= 3999.99)
                {
                    ValorPorExtenso = "três mil ";
                    ValorAuxiliar += -3000;
                }
                else if (ValorAuxiliar <= 4999.99)
                {
                    ValorPorExtenso = "quatro mil ";
                    ValorAuxiliar += -4000;
                }
                else if (ValorAuxiliar <= 5999.99)
                {
                    ValorPorExtenso = "cinco mil ";
                    ValorAuxiliar += -5000;
                }
                else if (ValorAuxiliar <= 6999.99)
                {
                    ValorPorExtenso = "seis mil ";
                    ValorAuxiliar += -6000;
                }
                else if (ValorAuxiliar <= 7999.99)
                {
                    ValorPorExtenso = "sete mil ";
                    ValorAuxiliar += -7000;
                }
                else if (ValorAuxiliar <= 8999.99)
                {
                    ValorPorExtenso = "oito mil ";
                    ValorAuxiliar += -8000;
                }
                else if (ValorAuxiliar <= 9999.99)
                {
                    ValorPorExtenso = "nove mil ";
                    ValorAuxiliar += -9000;
                }
            }
            ObterCentenaPorExtenso();
            return ValorPorExtenso;
        }
        public string ObterNumeroCompletoPorExtenso()
        {
            ValorAuxiliar = Valor;
            ObterUidadeDeMilharPorExtenso();
            return ValorPorExtenso;
        }
    }
}
