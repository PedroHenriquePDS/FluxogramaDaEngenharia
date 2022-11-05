Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("----- Fluxograma da Engenharia -----");
System.Console.WriteLine();
System.Console.Write("O objeto está se movendo (S/N)?  ");
bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToLower() == "s";

System.Console.Write("Deveria? ");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToLower() == "s";

string resposta;

if (estaSeMovendo)
{
    if (deveria)
    {
        resposta = "Ótimo!";
    }
    else
    {
        resposta = "Use Silver Tape!";
    }
}
else
{
    if (deveria)
    {
        resposta = "Use WD-40!";
    }
    else
    {
        resposta = "Ótimo!";
    }


}
System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine(resposta);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("Pressione uma tecla para continuar...");
Console.ReadKey();
Console.ResetColor();
