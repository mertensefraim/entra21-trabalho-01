using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class Calendario
    {
        public DateTime Data;

        public string ObterMesPorExtenso()
        {
            var mes = Data.ToString("MM");

            if (mes == "01")
            {
                return "Janeiro";
            }
            
            else if (mes == "02")
            {
                return "Fevereiro";
            }
            
            else if (mes == "03")
            {
                return "Março";
            }
            
            else if (mes == "04")
            {
                return "Abril";
            }
            
            else if (mes == "05")
            {
                return "Maio";
            }
            
            else if (mes == "06")
            {
                return "Junho";
            }
            
            else if (mes == "07")
            {
                return "Julho";
            }
            
            else if (mes == "08")
            {
                return "Agosto";
            }

            else if (mes == "09")
            {
                return "Setembro";
            }
            
            else if (mes == "10")
            {
                return "Outubro";
            }
             
            else if (mes == "11")
            {
                return "Novembro";
            }

            return "Dezembro";       
        }

        public string ObterDiaPorExtenso()
        {
            var dia = Data.ToString("dd");
            var primeiroDigito = dia.Substring(0, 1);
            var primeiroDigitoExtenso = "";
            var segundoDigito = dia.Substring(1, 1);
            var segundoDigitoExtenso = "";
            
            if (primeiroDigito == "2")
                primeiroDigitoExtenso = "vinte";

            else if (primeiroDigito == "3")
                primeiroDigito = "trinta";

            if (segundoDigito == "1")
                segundoDigitoExtenso = "um";

            else if (segundoDigito == "2")
                segundoDigitoExtenso = "dois";

            else if (segundoDigito == "3")
                segundoDigitoExtenso = "três";

            else if (segundoDigito == "4")
                segundoDigitoExtenso = "quatro";

            else if (segundoDigito == "5")
                segundoDigitoExtenso = "cinco";

            else if (segundoDigito == "6")
                segundoDigitoExtenso = "seis";

            else if (segundoDigito == "7")
                segundoDigitoExtenso = "sete";

            else if (segundoDigito == "8")
                segundoDigitoExtenso = "oito";

            else if (segundoDigito == "9")
                segundoDigitoExtenso = "nove";

            var diaExtenso = primeiroDigito + " e " + segundoDigitoExtenso;

            if (primeiroDigito == "1")
            {
                if (segundoDigito == "1")
                    diaExtenso = "onze";

                else if (segundoDigito == "2")
                    diaExtenso = "doze";

                else if (segundoDigito == "3")
                    diaExtenso = "treze";

                else if (segundoDigito == "4")
                    diaExtenso = "quatorze";

                else if (segundoDigito == "5")
                    diaExtenso = "quinze";

                else if (segundoDigito == "6")
                    diaExtenso = "dezesseis";

                else if (segundoDigito == "7")
                    diaExtenso = "dezessete";

                else if (segundoDigito == "8")
                    diaExtenso = "dezoito";

                else if (segundoDigito == "9")
                    diaExtenso = "dezenove";
            }

            return diaExtenso;
        }
    }
}
