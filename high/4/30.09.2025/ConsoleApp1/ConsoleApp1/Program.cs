
bool IsPalindrome(string text)
{
    char[] textArr = text.ToCharArray();
    textArr.Reverse();

    return text == new string(textArr);
}

bool IsPrime(int n)
{
    for(int i = 0; i < n; i++)
    {
        if(n % i == 0 && i != 1 && i != n)
        {
            return false;
        }
    }

    return true;
}

string GetTimeGreeting(int hour)
{
    if(hour > 20 || hour < 4)
    {
        return "Dobranoc";
    }

    if(hour > 17)
    {
        return "Dobry wieczór";
    }

    return "Dzień dobry";
}

string GetGradeName(int grade)
{
    string[] grades = [
        "niedostateczny",
        "dopuszczający",
        "dostateczny",
        "dobry",
        "bardzo dobry",
        "celujący"
    ];

    return grades[grade - 1];
}
int SumStart(int n)
{
    int res = 0;

    for (int i = 1; i <= n; i++)
    {
        res += i;
    }

    return res;
}

int GetAge(int birthYear)
{
    DateTime date = DateTime.Now;
    
    return date.Year - birthYear;
}

string Input(string prompt)
{
    Console.Write($"{prompt}: ");
    return Console.ReadLine();
}

string GetAgeType(int age)
{
    if (age > 17)
    {
        return "pełnoletni";
    }

    return "niepełnoletni";
}

int InputInt(string prompt)
{
    string str = Input(prompt);

    try
    {
        return int.Parse(str);
    } catch
    {
        Console.WriteLine("Wpisz poprawną liczbę.");
        return InputInt(prompt);
    }
}

string str = Input("Podaj tekst");

if(IsPalindrome(str))
{
    Console.WriteLine("Podałeś palindrom.");
} else
{
    Console.WriteLine("Nie podałeś palindromu");
}

int year = InputInt("Podaj wiek urodzenia");
int age = GetAge(year);

Console.WriteLine($"Twój wiek: {age}");
Console.WriteLine($"jesteś {GetAgeType(age)}");

if(age <= 0)
{
    Console.WriteLine("Nie urodziłeś się jeszcze");
}

if (age % 2 == 0)
{
    Console.WriteLine("Twój wiek jest parzysty");
}
else
{
    Console.WriteLine("Twój wiek jest nieparzysty");
}

