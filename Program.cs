using Kámen_nůžky_papír;
using Spectre.Console;

Random generatorVoleb = new Random();
Hra hra = new Hra();
string vyberNepritele = "";
bool cykl1 = true;
var highlight = new Style().Foreground(Color.Yellow2);

int skoreHrace = hra.SkoreHrac;
int skoreNepritele = hra.SkoreNepritel;

for (int i = 3; i >= 1; i--)
{
    Console.Clear();
    Console.WriteLine("Hra začíná za " + i + "...");
    System.Threading.Thread.Sleep(1000); 
}
Console.Clear();


while (cykl1 == true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Skóre Počítače: " + skoreNepritele);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Skóre Hráče: " + skoreHrace);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("- - - - - - - -");
    var vyberHrace = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .PageSize(10)
        .HighlightStyle(highlight)
        .AddChoices(new[] {
            "Kámen", "Nůžky", "Papír"
        })); ;
    Console.Clear();

    int nahodneCislo = generatorVoleb.Next(1, 4);
    switch (nahodneCislo)
    {
        case 1:
            {
                vyberNepritele = "Kámen";
                break;
            }
        case 2:
            {
                vyberNepritele = "Nůžky";
                break;
            }
        case 3:
            {
                vyberNepritele = "Papír";
                break;
            }
    }

    Console.Write("Počítač vybral: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(vyberNepritele);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Hráč vybral: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(vyberHrace);
    Console.ForegroundColor = ConsoleColor.White;

    if ((vyberHrace.Equals("Kámen") && vyberNepritele.Equals("Nůžky")) || (vyberHrace.Equals("Nůžky") && vyberNepritele.Equals("Papír")) || (vyberHrace.Equals("Papír") && vyberNepritele.Equals("Kámen")))
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("");

        Console.WriteLine("Hráč vyhrál!");
        Console.ForegroundColor = ConsoleColor.Blue;

        skoreHrace++;
    }
    else if ((vyberHrace.Equals("Kámen") && vyberNepritele.Equals("Papír")) || (vyberHrace.Equals("Nůžky") && vyberNepritele.Equals("Kámen")) || (vyberHrace.Equals("Papír") && vyberNepritele.Equals("Nůžky")))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("Počítač vyhrál!");
        Console.ForegroundColor = ConsoleColor.White;

        skoreNepritele++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("");
        Console.WriteLine("Remíza!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Stiskněte jakoukoli klávesu pro pokračování...");
    Console.ForegroundColor = ConsoleColor.White;

    Console.ReadKey();
    Console.Clear();

    if (skoreHrace == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Skóre Počítače: " + skoreNepritele);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Skóre Hráče: " + skoreHrace);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("- - - - - - - -");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Hráč ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Vyhrál celou hru!");
        cykl1 = false;


    }
    else if (skoreNepritele == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Skóre Počítače: " + skoreNepritele);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Skóre Hráče: " + skoreHrace);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("- - - - - - - -");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Počítač ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Vyhrál celou hru!");
        cykl1 = false;

    }
}    