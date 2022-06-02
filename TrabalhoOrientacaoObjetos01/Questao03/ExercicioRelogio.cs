namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExercicioRelogio
    {
        public void Executar()
        {
            var relogio = new Relogio();
            var opcaoValida = false;

            while (opcaoValida == false)
            {
                try
                {
                    Console.Write("Informe a hora: ");
                    relogio.Hora = Convert.ToDateTime(Console.ReadLine());

                    opcaoValida = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Informe uma hora válida");
                    opcaoValida = false;
                }
            }

            var horaCompletaExtenso = relogio.ObterHoraCompletaPorExtenso();

            Console.WriteLine(horaCompletaExtenso);
        }
    }
}
