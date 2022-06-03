namespace TrabalhoOrientacaoObjetos01.Questao03
{
    // Wellington Scaburri
    public class Relogio
    {
        public DateTime Hora;

        public string ObterHoraPorExtenso()
        {
            var hora = Hora.ToString("HH");

            var primeiroNumero = hora.Substring(0, 1);
            var segundoNumero = hora.Substring(1, 1);
            var horaExtenso = "";

            if (primeiroNumero == "0")
            {
                if (segundoNumero == "0")
                {
                    horaExtenso = "Zero horas";
                }
                else if (segundoNumero == "1")
                {
                    horaExtenso = "Uma hora";
                }
                else if (segundoNumero == "2")
                {
                    horaExtenso = "Duas horas";
                }
                else if (segundoNumero == "3")
                {
                    horaExtenso = "Três horas";
                }
                else if (segundoNumero == "4")
                {
                    horaExtenso = "Quatro horas";
                }
                else if (segundoNumero == "5")
                {
                    horaExtenso = "Cinco horas";
                }
                else if (segundoNumero == "6")
                {
                    horaExtenso = "Seis horas";
                }
                else if (segundoNumero == "7")
                {
                    horaExtenso = "Sete horas";
                }
                else if (segundoNumero == "8")
                {
                    horaExtenso = "Oito horas";
                }
                else
                {
                    horaExtenso = "Nove horas";
                }
            }
            else if (primeiroNumero == "1")
            {
                if (segundoNumero == "0")
                {
                    horaExtenso = "Dez horas";
                }
                else if (segundoNumero == "1")
                {
                    horaExtenso = "Onze horas";
                }
                else if (segundoNumero == "2")
                {
                    horaExtenso = "Doze horas";
                }
                else if (segundoNumero == "3")
                {
                    horaExtenso = "Treze horas";
                }
                else if (segundoNumero == "4")
                {
                    horaExtenso = "Quatorze horas";
                }
                else if (segundoNumero == "5")
                {
                    horaExtenso = "Quinze horas";
                }
                else if (segundoNumero == "6")
                {
                    horaExtenso = "Dezesseis horas";
                }
                else if (segundoNumero == "7")
                {
                    horaExtenso = "Dezessete horas";
                }
                else if (segundoNumero == "8")
                {
                    horaExtenso = "Dezoito horas";
                }
                else
                {
                    horaExtenso = "Dezenove horas";
                }
            }
            else if (primeiroNumero == "2")
            {
                if (segundoNumero == "0")
                {
                    horaExtenso = "Vinte horas";
                }
                else if (segundoNumero == "1")
                {
                    horaExtenso = "Vinte e uma horas";
                }
                else if (segundoNumero == "2")
                {
                    horaExtenso = "Vinte e duas horas";
                }
                else if (segundoNumero == "3")
                {
                    horaExtenso = "Vinte e três horas";
                }
            }

            return horaExtenso;
        }

        public string ObterMinutoPorExtenso()
        {
            var minuto = Hora.ToString("mm");

            var primeiroNumero = minuto.Substring(0, 1);
            var segundoNumero = minuto.Substring(1, 1);
            var primeiroNumeroExtenso = "";
            var minutoExtenso = "";

            if (primeiroNumero == "2")
            {
                primeiroNumeroExtenso = "vinte";
            }
            else if (primeiroNumero == "3")
            {
                primeiroNumeroExtenso = "trinta";
            }
            else if (primeiroNumero == "4")
            {
                primeiroNumeroExtenso = "quarenta";
            }
            else
            {
                primeiroNumeroExtenso = "cinquenta";
            }

            if (segundoNumero == "0")
            {
                minutoExtenso = primeiroNumeroExtenso + " minutos";
            }
            else if (segundoNumero == "1")
            {
                minutoExtenso = primeiroNumeroExtenso + " e um minutos";
            }
            else if (segundoNumero == "2")
            {
                minutoExtenso = primeiroNumeroExtenso + " e dois minutos";
            }
            else if (segundoNumero == "3")
            {
                minutoExtenso = primeiroNumeroExtenso + " e três minutos";
            }
            else if (segundoNumero == "4")
            {
                minutoExtenso = primeiroNumeroExtenso + " e quatro minutos";
            }
            else if (segundoNumero == "5")
            {
                minutoExtenso = primeiroNumeroExtenso + " e cinco minutos";
            }
            else if (segundoNumero == "6")
            {
                minutoExtenso = primeiroNumeroExtenso + " e seis minutos";
            }
            else if (segundoNumero == "7")
            {
                minutoExtenso = primeiroNumeroExtenso + " e sete minutos";
            }
            else if (segundoNumero == "8")
            {
                minutoExtenso = primeiroNumeroExtenso + " e oito minutos";
            }
            else
            {
                minutoExtenso = primeiroNumeroExtenso + " e nove minutos";
            }

            if (primeiroNumero == "0")
            {
                if (segundoNumero == "0")
                {
                    minutoExtenso = "zero minutos";
                }
                else if (segundoNumero == "1")
                {
                    minutoExtenso = "um minuto";
                }
                else if (segundoNumero == "2")
                {
                    minutoExtenso = "dois minutos";
                }
                else if (segundoNumero == "3")
                {
                    minutoExtenso = "três minutos";
                }
                else if (segundoNumero == "4")
                {
                    minutoExtenso = "quatro minutos";
                }
                else if (segundoNumero == "5")
                {
                    minutoExtenso = "cinco minutos";
                }
                else if (segundoNumero == "6")
                {
                    minutoExtenso = "seis minutos";
                }
                else if (segundoNumero == "7")
                {
                    minutoExtenso = "sete minutos";
                }
                else if (segundoNumero == "8")
                {
                    minutoExtenso = "oito minutos";
                }
                else
                {
                    minutoExtenso = "nove minutos";
                }
            }
            else if (primeiroNumero == "1")
            {
                if (segundoNumero == "0")
                {
                    minutoExtenso = "dez minutos";
                }
                else if (segundoNumero == "1")
                {
                    minutoExtenso = "onze minutos";
                }
                else if (segundoNumero == "2")
                {
                    minutoExtenso = "doze minutos";
                }
                else if (segundoNumero == "3")
                {
                    minutoExtenso = "treze minutos";
                }
                else if (segundoNumero == "4")
                {
                    minutoExtenso = "quatorze minutos";
                }
                else if (segundoNumero == "5")
                {
                    minutoExtenso = "quinze minutos";
                }
                else if (segundoNumero == "6")
                {
                    minutoExtenso = "dezesseis minutos";
                }
                else if (segundoNumero == "7")
                {
                    minutoExtenso = "dezessete minutos";
                }
                else if (segundoNumero == "8")
                {
                    minutoExtenso = "dezoito minutos";
                }
                else
                {
                    minutoExtenso = "dezenove minutos";
                }
            }

            return minutoExtenso;
        }

        public string ObterSegundoPorExtenso()
        {
            var segundo = Hora.ToString("ss");

            var primeiroNumero = segundo.Substring(0, 1);
            var segundoNumero = segundo.Substring(1, 1);
            var primeiroNumeroExtenso = "";
            var segundoExtenso = "";

            if (primeiroNumero == "2")
            {
                primeiroNumeroExtenso = "vinte";
            }
            else if (primeiroNumero == "3")
            {
                primeiroNumeroExtenso = "trinta";
            }
            else if (primeiroNumero == "4")
            {
                primeiroNumeroExtenso = "quarenta";
            }
            else
            {
                primeiroNumeroExtenso = "cinquenta";
            }

            if (segundoNumero == "0")
            {
                segundoExtenso = primeiroNumeroExtenso + " segundos";
            }
            else if (segundoNumero == "1")
            {
                segundoExtenso = primeiroNumeroExtenso + " e um segundos";
            }
            else if (segundoNumero == "2")
            {
                segundoExtenso = primeiroNumeroExtenso + " e dois segundos";
            }
            else if (segundoNumero == "3")
            {
                segundoExtenso = primeiroNumeroExtenso + " e três segundos";
            }
            else if (segundoNumero == "4")
            {
                segundoExtenso = primeiroNumeroExtenso + " e quatro segundos";
            }
            else if (segundoNumero == "5")
            {
                segundoExtenso = primeiroNumeroExtenso + " e cinco segundos";
            }
            else if (segundoNumero == "6")
            {
                segundoExtenso = primeiroNumeroExtenso + " e seis segundos";
            }
            else if (segundoNumero == "7")
            {
                segundoExtenso = primeiroNumeroExtenso + " e sete segundos";
            }
            else if (segundoNumero == "8")
            {
                segundoExtenso = primeiroNumeroExtenso + " e oito segundos";
            }
            else
            {
                segundoExtenso = primeiroNumeroExtenso + " e nove segundos";
            }

            if (primeiroNumero == "0")
            {
                if (segundoNumero == "0")
                {
                    segundoExtenso = "zero segundos";
                }
                else if (segundoNumero == "1")
                {
                    segundoExtenso = "um segundo";
                }
                else if (segundoNumero == "2")
                {
                    segundoExtenso = "dois segundos";
                }
                else if (segundoNumero == "3")
                {
                    segundoExtenso = "três segundos";
                }
                else if (segundoNumero == "4")
                {
                    segundoExtenso = "quatro segundos";
                }
                else if (segundoNumero == "5")
                {
                    segundoExtenso = "cinco segundos";
                }
                else if (segundoNumero == "6")
                {
                    segundoExtenso = "seis segundos";
                }
                else if (segundoNumero == "7")
                {
                    segundoExtenso = "sete segundos";
                }
                else if (segundoNumero == "8")
                {
                    segundoExtenso = "oito segundos";
                }
                else
                {
                    segundoExtenso = "nove segundos";
                }
            }
            else if (primeiroNumero == "1")
            {
                if (segundoNumero == "0")
                {
                    segundoExtenso = "dez segundos";
                }
                else if (segundoNumero == "1")
                {
                    segundoExtenso = "onze segundos";
                }
                else if (segundoNumero == "2")
                {
                    segundoExtenso = "doze segundos";
                }
                else if (segundoNumero == "3")
                {
                    segundoExtenso = "treze segundos";
                }
                else if (segundoNumero == "4")
                {
                    segundoExtenso = "quatorze segundos";
                }
                else if (segundoNumero == "5")
                {
                    segundoExtenso = "quinze segundos";
                }
                else if (segundoNumero == "6")
                {
                    segundoExtenso = "dezesseis segundos";
                }
                else if (segundoNumero == "7")
                {
                    segundoExtenso = "dezessete segundos";
                }
                else if (segundoNumero == "8")
                {
                    segundoExtenso = "dezoito segundos";
                }
                else
                {
                    segundoExtenso = "dezenove segundos";
                }
            }

            return segundoExtenso;
        }

        public string ObterHoraCompletaPorExtenso()
        {
            var horaExtenso = ObterHoraPorExtenso();
            var minutoExtenso = ObterMinutoPorExtenso();
            var segundoExtenso = ObterSegundoPorExtenso();

            return horaExtenso + ", " + minutoExtenso + " e " + segundoExtenso;
        }
    }
}
