namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExercicioRelogio
    {
        public void Executar()
        {
            var relogio = new Relogio();

            Console.Write("Informe a hora: ");
            relogio.Hora = Convert.ToDateTime(Console.ReadLine());

            var horaCompletaExtenso = relogio.ObterHoraCompletaPorExtenso();

            Console.WriteLine(horaCompletaExtenso);
        }
    }
}
