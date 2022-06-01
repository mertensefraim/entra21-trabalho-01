using TrabalhoOrientacaoObjetos01.Questao01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

var escolhaUsuario = 0;

while (escolhaUsuario != 99)
{
    Console.Write(@"------Questões----------
Questão 01 - 01
Questão 02 - 02
Questão 03 - 03
Sair - 99
Escolha a questão desejada: ");
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

    
}
