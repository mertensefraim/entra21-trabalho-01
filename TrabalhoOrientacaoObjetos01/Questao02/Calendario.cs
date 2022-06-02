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
                return "janeiro";
            }
            
            else if (mes == "02")
            {
                return "fevereiro";
            }
            
            else if (mes == "03")
            {
                return "março";
            }
            
            else if (mes == "04")
            {
                return "abril";
            }
            
            else if (mes == "05")
            {
                return "maio";
            }
            
            else if (mes == "06")
            {
                return "junho";
            }
            
            else if (mes == "07")
            {
                return "julho";
            }
            
            else if (mes == "08")
            {
                return "agosto";
            }

            else if (mes == "09")
            {
                return "setembro";
            }
            
            else if (mes == "10")
            {
                return "outubro";
            }
             
            else if (mes == "11")
            {
                return "novembro";
            }

            return "dezembro";       
        }

        public string ObterDiaPorExtenso()
        {
            var dia = Data.ToString("dd");
            var primeiroDigito = dia.Substring(0, 1);
            var primeiroDigitoExtenso = "";
            var segundoDigito = dia.Substring(1, 1);
            var segundoDigitoExtenso = "";
            var diaExtenso = "";

            if (primeiroDigito == "2")
                primeiroDigitoExtenso = "vinte";

            else if (primeiroDigito == "3")
                primeiroDigitoExtenso = "trinta";


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

            if (segundoDigito == "0") 
                diaExtenso = primeiroDigitoExtenso;
            else
                diaExtenso = primeiroDigitoExtenso + " e " + segundoDigitoExtenso;

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

        public string ObterAnoPorExtenso()
        {
            var ano = Data.ToString("yyyy");

            var primeiroDigito = ano.Substring(0, 1);
            var primeiroDigitoExtenso = "";

            var segundoDigito = ano.Substring(1, 1);
            var segundoDigitoExtenso = "";

            var terceiroDigito = ano.Substring(2, 1);
            var terceiroDigitoExtenso = "";

            var quartoDigito = ano.Substring(3, 1);
            var quartoDigitoExtenso = "";

            if (primeiroDigito == "1")
                primeiroDigitoExtenso = "mil";

            else if (primeiroDigito == "2")
                primeiroDigitoExtenso = "dois mil";

            if (segundoDigito == "1")
                segundoDigitoExtenso = "cento";

            else if (segundoDigito == "2")
                segundoDigitoExtenso = "duzentos";

            else if (segundoDigito == "3")
                segundoDigitoExtenso = "trezentos";

            else if (segundoDigito == "4")
                segundoDigitoExtenso = "quatrocentos";

            else if (segundoDigito == "5")
                segundoDigitoExtenso = "quinhentos";

            else if (segundoDigito == "6")
                segundoDigitoExtenso = "seiscentos";

            else if (segundoDigito == "7")
                segundoDigitoExtenso = "setecentos";

            else if (segundoDigito == "8")
                segundoDigitoExtenso = "oitocentos";

            else if (segundoDigito == "9")
                segundoDigitoExtenso = "novecentos";


            if (terceiroDigito == "2")
                terceiroDigitoExtenso = "vinte";

            else if (terceiroDigito == "3")
                terceiroDigitoExtenso = "trinta";
            
            else if (terceiroDigito == "4")
                terceiroDigitoExtenso = "quarenta";
            
            else if (terceiroDigito == "5")
                terceiroDigitoExtenso = "cinquenta";
            
            else if (terceiroDigito == "6")
                terceiroDigitoExtenso = "sessenta";
            
            else if (terceiroDigito == "7")
                terceiroDigitoExtenso = "setenta";
            
            else if (terceiroDigito == "8")
                terceiroDigitoExtenso = "oitenta";
            
            else if (terceiroDigito == "9")
                terceiroDigitoExtenso = "noventa";


            if (segundoDigito == "1")
                terceiroDigitoExtenso = "um";

            else if (quartoDigito == "2")
                quartoDigitoExtenso = "dois";

            else if (quartoDigito == "3")
                quartoDigitoExtenso = "três";

            else if (quartoDigito == "4")
                quartoDigitoExtenso = "quatro";

            else if (quartoDigito == "5")
                quartoDigitoExtenso = "cinco";

            else if (quartoDigito == "6")
                quartoDigitoExtenso = "seis";

            else if (quartoDigito == "7")
                quartoDigitoExtenso = "sete";

            else if (quartoDigito == "8")
                quartoDigitoExtenso = "oito";

            else if (quartoDigito == "9")
                quartoDigitoExtenso = "nove";

            var doisUltimosDigitos = terceiroDigitoExtenso + " e " + quartoDigitoExtenso;

            if (terceiroDigito == "1")
            {
                if (segundoDigito == "1")
                    doisUltimosDigitos = "onze";

                else if (segundoDigito == "2")
                    doisUltimosDigitos = "doze";

                else if (segundoDigito == "3")
                    doisUltimosDigitos = "treze";

                else if (segundoDigito == "4")
                    doisUltimosDigitos = "quatorze";

                else if (segundoDigito == "5")
                    doisUltimosDigitos = "quinze";

                else if (segundoDigito == "6")
                    doisUltimosDigitos = "dezesseis";

                else if (segundoDigito == "7")
                    doisUltimosDigitos = "dezessete";

                else if (segundoDigito == "8")
                    doisUltimosDigitos = "dezoito";

                else if (segundoDigito == "9")
                    doisUltimosDigitos = "dezenove";
            }

            if (doisUltimosDigitos == " e ")
            {
                return primeiroDigitoExtenso + " e " + segundoDigitoExtenso;
            }
            return primeiroDigitoExtenso + " " + segundoDigitoExtenso + " e " + doisUltimosDigitos;
        }

        public string ObterDataCompletaPorExtenso()
        {
            return ObterDiaPorExtenso() + " de " + ObterMesPorExtenso() + " de " + ObterAnoPorExtenso();
        }
    }
}
