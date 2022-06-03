using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    // Efraim Calebe Mertens
    public class ExercicioCalendario
    {
        public void Executar()
        {
            var calendario = new Calendario();
            var valorUsuario = 0;
            var verificador = false;

            while (verificador == false)
            {
                try
                {
                    Console.Write("Digite uma data na formatação yyyy/MM/dd: ");
                    calendario.Data = Convert.ToDateTime(Console.ReadLine());
                    verificador = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A data digita não está em um formato permitido, tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            while (valorUsuario != 99)
            {
                Console.WriteLine($"A data digitada foi {calendario.Data.ToString("dd/MM/yyyy")}");

                verificador = false;

                while (verificador == false)
                {
                    Console.WriteLine(@"
-------Tabela de opções-------
01 - Apresentar dia por extenso
02 - Apresentar mês por extenso
03 - Apresentar ano por extenso
04 - Apresentar data completa por extenso
09 - Voltar para digitar outra data
99 - Voltar para Program
");
                    try
                    {
                        Console.Write("Escolha um valor para apresentação: ");
                        valorUsuario = Convert.ToInt32(Console.ReadLine());

                        if (valorUsuario == 1)
                            Console.WriteLine($"Dia por extenso: {calendario.ObterDiaPorExtenso()}");

                        else if (valorUsuario == 2)
                            Console.WriteLine($"Mês por extenso: {calendario.ObterMesPorExtenso()}");

                        else if (valorUsuario == 3)
                            Console.WriteLine($"Ano por extenso: {calendario.ObterAnoPorExtenso()}");

                        else if (valorUsuario == 4)
                            Console.WriteLine($"Data completa por extenso: {calendario.ObterDataCompletaPorExtenso()}");

                        else if (valorUsuario == 9)
                            while (verificador == false)
                            {
                                try
                                {
                                    Console.Write("Digite uma data na formatação yyyy/MM/dd: ");
                                    calendario.Data = Convert.ToDateTime(Console.ReadLine());
                                    verificador = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A data digita não está em um formato permitido, tento novamente:");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }

                        else if (valorUsuario == 99)
                            verificador = true;

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Não existe uma opção com o valor digitado!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor deve ser um inteiro");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
