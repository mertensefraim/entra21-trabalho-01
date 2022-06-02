using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExercicioNumero
    {
        public void Executar()
        {
            // Objetivo: Dado a entrada de um valor decimal, deverá escrever o mesmo por extenso.
            //● Classe: Número
            //○ Propriedades:
            //■ Valor: double
            //○ Métodos:
            //■ ObterDecimalPorExtenso
            //■ ObterUnidadePorExtenso
            //■ ObterDezenaPorExtenso
            //■ ObterCentenaPorExtenso
            //■ ObterUnidadeDeMilharPorExtenso
            //■ ObterNumeroCompletoPorExtenso

            var numero = new Numero();
            var validar = false;
            var valor = 0.0;
            while (validar == false)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Infome número: ");
                    numero.Valor = Math.Round(Convert.ToDouble(Console.ReadLine()),2);
                    if (valor <= 9999.99)
                    {
                        validar = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
            } 
            Console.WriteLine(numero.ObterNumeroCompletoPorExtenso());
            Console.ReadKey();
        }
    }
}
