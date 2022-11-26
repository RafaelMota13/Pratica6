

Console.WriteLine("-Exemplo de Sub-rotina-");

Console.Write("Digite seu nome......: ");
Console.ReadKey();

// Lógica de validação do nome
// ....
exibirMensagemDeErro("Nome inválido. O nome é obrigatório."); // Argumento

Console.Write("Digite seu idade.....: ");
Console.ReadKey();

exibirMensagemDeErro("A idade deve estar entre 0 e 150 anos.");

Console.Write("Digite seu profissão.: ");
Console.ReadKey();

exibirMensagemDeErro("A profissão é obrigatória.");


// Sub-rotina do tipo PROCEDIMENTO com passagem de parâmetro

void exibirMensagemDeErro(string mensagem) // Assinatura
{
    
    string mensagemAjustada = $"| {mensagem} |";       //
    int quantidaDeTracos = mensagemAjustada.Length;    // Parâmetro
    string barra = "".PadRight(quantidaDeTracos, '-'); //

    Console.WriteLine();
    Console.WriteLine(barra);
    Console.Write("| ");
    Console.ForegroundColor= ConsoleColor.DarkRed;
    Console.Write(mensagem);
    Console.ResetColor();
    Console.WriteLine(" |");
    Console.WriteLine(barra);
    Console.WriteLine();
    Console.Beep();
    Console.Beep();

}


//     Console.WriteLine();
//    Console.WriteLine("------------------------------");
//    Console.Write("|");
//    Console.ForegroundColor= ConsoleColor.DarkRed;
//    Console.Write("Erro ao obter as informações");
//    Console.ResetColor();
//    Console.WriteLine("|");
//    Console.WriteLine("------------------------------");
//    Console.WriteLine();
//    Console.Beep();
//    Console.Beep();


