namespace TrabalhoOrientacaoObjetos01.Questao03
{
    // Wellington Scaburri
    public class ExercicioRelogio
    {        
        public void Executar()
        {
            var relogio = new Relogio();
            var valorUsuario = 0;
            var verificador = false;

            while (verificador == false)
            {
                try
                {
                    Console.Write("Informe a hora (No formato horas:minutos:segundos): ");
                    relogio.Hora = Convert.ToDateTime(Console.ReadLine());
                    verificador = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A hora digita não está em um formato permitido, tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            while (valorUsuario != 99)
            {
                Console.WriteLine($"A hora digitada foi {relogio.Hora.ToString("HH/mm/ss")}");

                verificador = false;

                while (verificador == false)
                {
                    Console.WriteLine(@"
-------Tabela de opções-------
01 - Apresentar hora por extenso
02 - Apresentar minuto por extenso
03 - Apresentar segundo por extenso
04 - Apresentar hora completa por extenso
09 - Voltar para digitar outra hora
99 - Voltar para Program
");
                    try
                    {
                        Console.Write("Escolha um valor para apresentação: ");
                        valorUsuario = Convert.ToInt32(Console.ReadLine());

                        if (valorUsuario == 1)
                            Console.WriteLine($"Hora por extenso: {relogio.ObterHoraPorExtenso()}");

                        else if (valorUsuario == 2)
                            Console.WriteLine($"Minuto por extenso: {relogio.ObterMinutoPorExtenso()}");

                        else if (valorUsuario == 3)
                            Console.WriteLine($"Segundo por extenso: {relogio.ObterSegundoPorExtenso()}");

                        else if (valorUsuario == 4)
                            Console.WriteLine($"Hora completa por extenso: {relogio.ObterHoraCompletaPorExtenso()}");

                        else if (valorUsuario == 9)
                            while (verificador == false)
                            {
                                try
                                {
                                    Console.Write("Informe a hora (No formato horas:minutos:segundos): ");
                                    relogio.Hora = Convert.ToDateTime(Console.ReadLine());
                                    verificador = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A hora digita não está em um formato permitido, tento novamente:");
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
