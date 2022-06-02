using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {
        public DateTime Hora;

        public string ObterHoraPorExtenso()
        {
            DateTime hora = hora.ToString("HH");

            if (hora < 10)
            {    

                if (hora == 0)
                {
                    return "Zero Hora, ";
                }
                else if (hora == 1)
                {
                    return "Uma Hora, ";
                }
                else if (hora == 2)
                {
                    return "Duas Horas, ";
                }
                else if (hora == 3)
                {
                    return "Três Horas, ";
                }
                else if (hora == 4)
                {
                    return "Quatro Horas, ";
                }
                else if (hora == 5)
                {
                    return "Cinco Horas, ";
                }
                else if (hora == 6)
                {
                    return "Seis Horas, ";
                }
                else if (hora == 7)
                {
                    return "Sete Horas, ";
                }
                else if (hora == 8)
                {
                    return "Oito Horas, ";
                }
                else 
                {
                    return "Nove Horas, ";
                }
            }
            else if (hora > 10)
            { 
                hora.ToString("HH");
                var primeiroNumero = hora.Substring(0, 1);
                var segundoNumero = hora.Substring(1, 1);

                if (primeiroNumero == "1")
                {
                    if (segundoNumero == "0")
                    {
                        return "Dez Horas, ";
                    }
                    else if (segundoNumero == "1")
                    {
                        return "Onze Horas, ";
                    }
                    else if (segundoNumero == "2")
                    {
                        return "Doze Horas, ";
                    }
                    else if (segundoNumero == "3")
                    {
                        return "Treze Horas, ";
                    }
                    else if (segundoNumero == "4")
                    {
                        return "Quatorze Horas, ";
                    }
                    else if (segundoNumero == "5")
                    {
                        return "Quinze Horas, ";
                    }
                    else if (segundoNumero == "6")
                    {
                        return "Dezesseis Horas, ";
                    }
                    else if (segundoNumero == "7")
                    {
                        return "Dezessete Horas, ";
                    }
                    else if (segundoNumero == "8")
                    {
                        return "Dezoito Horas, ";
                    }
                    else 
                    {
                        return "Dezenove Horas, ";
                    }
                }
            }
            else if (hora > 20)
            {
                hora.ToString("HH");
                var primeiroNumero = hora.Substring(0, 1);
                var segundoNumero = hora.Substring(1, 1);

                if (primeiroNumero == "2")
                {
                    if (segundoNumero == "0")
                    {
                        return "Vinte Horas, ";
                    }
                    else if (segundoNumero == "1")
                    {
                        return "Vinte e Uma Horas, ";
                    }
                    else if (segundoNumero == "2")
                    {
                        return "Vinte e Duas Horas, ";
                    }
                    else if (segundoNumero == "3")
                    {
                        return "Vinte e Três Horas, ";
                    }
                }
            }
        }
    }
}
