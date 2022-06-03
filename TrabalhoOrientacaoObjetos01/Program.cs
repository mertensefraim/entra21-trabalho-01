using TrabalhoOrientacaoObjetos01.Questao01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

var escolhaUsuario = 0;

while (escolhaUsuario != 99)
{

    var validar = false;

    while (validar == false)
    {
        Console.Write(@"----------Questões----------
01 - Questão 01
02 - Questão 02
03 - Questão 03
99 - Sair
Escolha a questão desejada: ");
        try
        {
            escolhaUsuario = Convert.ToInt32(Console.ReadLine());

            if (escolhaUsuario == 1)
            {
                var questao = new ExercicioNumero();
                questao.Executar();
            }
            else if (escolhaUsuario == 2)
            {
                var questao = new ExercicioCalendario();
                questao.Executar();
            }
            else if (escolhaUsuario == 3)
            {
                var questao = new ExercicioRelogio();
                questao.Executar();
            }

            else if (escolhaUsuario == 99)
                validar = true;

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor digitado não é uma opção válida!");
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
