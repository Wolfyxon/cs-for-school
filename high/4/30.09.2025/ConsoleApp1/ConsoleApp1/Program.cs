
bool IsPalindrome(string text)
{
    char[] textArr = text.ToCharArray();
    textArr.Reverse();

    return text.ToLower() == new string(textArr).ToLower();
}

bool IsPrime(int n)
{
    for(int i = 2; i < n; i++)
    {
        if(n % i == 0)
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

void PrintMulTab(int n)
{
    List<string> strResults = new List<string>();
    int maxLen = 0;

    for(int i = 1; i <= 10; i++)
    {
        string str = (n * i).ToString();
        strResults.Add(str);

        if(str.Length > maxLen)
        {
            maxLen = str.Length;
        }
    }

    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{ApplyPadding(i.ToString(), maxLen)} | ");
    }

    Console.WriteLine("");

    for (int i = 0; i < strResults.Count; i++)
    {
        Console.Write($"{ApplyPadding(strResults[i], maxLen)} | ");
    }

    Console.WriteLine("");
}

string ApplyPadding(string str, int maxWidth)
{
    string space = "";

    for(int i = 0; i < maxWidth - str.Length; i++)
    {
        space += " ";
    } 

    return str + space;
}

void PrintNumsTo(int n)
{
    List<string> strResults = new List<string>();
    int maxLen = 0;

    for (int i = 1; i <= n; i++)
    {
        string str = i.ToString();
        strResults.Add(str);

        if(str.Length > maxLen)
        {
            maxLen = str.Length;
        }
    }

    for(int i = 0; i < strResults.Count; i++)
    {
        Console.Write($"{ApplyPadding(strResults[i], maxLen)} ");

        if (i != 0 && i % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}

void Main()
{
    string greeting = GetTimeGreeting(DateTime.Now.Hour);
    string name = Input("Podaj imię");

    Console.WriteLine($"{greeting}, {name}");

    if (IsPalindrome(name))
    {
        Console.WriteLine("Twoje imię to palindrom.");
    }
    else
    {
        Console.WriteLine("Twoje imię to nie palindromu");
    }

    int year = InputInt("Podaj rok urodzenia");
    int age = GetAge(year);

    Console.WriteLine($"Twój wiek: {age}");
    Console.WriteLine($"jesteś {GetAgeType(age)}");

    if (age <= 0)
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

    if (IsPrime(age))
    {
        Console.WriteLine("Jest liczbą pierwszą");
    }
    else
    {
        Console.WriteLine("Nie jest liczbą pierwszą");
    }

    Console.WriteLine("Tabliczka mnożenia wieku:");
    PrintMulTab(age);

    Console.WriteLine($"Liczby od 1 do {age}:");
    PrintNumsTo(age);
}

Main();
