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

        }
        public void ObterCentenaPorExtenso()
        {
            
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
