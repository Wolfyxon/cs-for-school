
using System.Diagnostics;

class Program
{
    const int PESEL_LENGTH = 11;

    static void Main(String[] args)
    {
        RunTests();

        Console.Write("Podaj PESEL: ");

        String peselStr = Console.ReadLine()!;
        int[] pesel;

        if(peselStr.Length != PESEL_LENGTH)
        {
            Console.WriteLine($"PESEL musi zawierać {PESEL_LENGTH} znaków");
            return;
        }

        try
        {
            pesel = ParseDigits(peselStr);
        } catch
        {
            Console.WriteLine("PESEL może zawierać tylko liczby");
            return;
        }

        if(ParseGender(pesel) == 'K')
        {
            Console.WriteLine("Kobieta");
        } else
        {
            Console.WriteLine("Mężczyzna");
        }

        if(VerifyChecksum(pesel))
        {
            Console.WriteLine("Suma kontrolna jest poprawna");
        } else
        {
            Console.WriteLine("Suma kontrolna NIEPOPRAWNA");
        }
    }

    static void RunTests()
    {
        string peselStr = "55030101193";
        int[] pesel = ParseDigits(peselStr);

        Debug.Assert(ParseGender(pesel) == 'M', "Błędna płeć");
        Debug.Assert(VerifyChecksum(pesel), "Suma kontrolna testowego PESELu błędna");
    }

    static int[] ParseDigits(string str)
    {
        int[] digits = new int[str.Length];

        for(int i = 0; i < str.Length; i++)
        {
            digits[i] = int.Parse(str[i].ToString());
        }

        return digits;
    }

    static bool VerifyChecksum(int[] pesel)
    {
        int[] WEIGHTS = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        int lastDigit = pesel[PESEL_LENGTH - 1]; // 11
        int s = 0;

        for(int i = 0; i < 10; i++)
        {
            int digit = pesel[i];
            int weight = WEIGHTS[i];
            
            s += digit * weight;
        }

        double m = s % 10;
        double r = 0;

        if(m != 0)
        {
            r = 10 - m;
        }
        
        return r == lastDigit;
    }

    static char ParseGender(int[] pesel)
    {
        int genderDigit = pesel[10]; // 11

        if(genderDigit % 2 == 0)
        {
            return 'K';
        } else
        {
            return 'M';
        }
    }
}