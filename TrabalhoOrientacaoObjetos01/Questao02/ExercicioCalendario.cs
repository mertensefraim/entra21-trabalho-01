using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExercicioCalendario
    {
        public void Executar()
        {
            var calendario = new Calendario();
            Console.Write("Digite uma data. Obs.: deve estar no formato ano/mes/dia: ");
            calendario.Data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"A data digitada foi {calendario.Data.ToString("dd/MM/yyyy")}" +
                $"\nEla por extenso fica: {calendario.ObterDataCompletaPorExtenso()}");
        }
    }
}
