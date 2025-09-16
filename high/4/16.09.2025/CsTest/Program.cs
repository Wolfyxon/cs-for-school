Console.Write("Podaj imię: ");
string? name = Console.ReadLine();

if(name != null)
{
    Console.WriteLine($"Witaj, {name}!");
} else
{
    Console.WriteLine("Nie podano imienia");
}

Console.Write("Podaj A: ");
float a = float.Parse(Console.ReadLine()!);

Console.Write("Podaj B: ");
float b = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Wynik: {a + b}");

