class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Podaj tekst: ");
        String text = Console.ReadLine()!;

        Console.WriteLine($"Liczba samogłosek: {CharLib.CountVowels(text)}");
        Console.WriteLine($"Tekst po usunięciu duplikatów: {CharLib.RemoveDuplicateChars(text)}");
    }
}

class CharLib
{
    const String VOWELS = "aąeęiouóyAĄEĘIOUÓY";

    public static int CountVowels(String? text)
    {
        int res = 0;

        if(text != null)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i])) {
                    res += 1;
                }
            }
        }

        return res;
    }

    public static String RemoveDuplicateChars(String? text)
    {
        String res = "";

        if(text != null)
        {
            for(int i = 0; i < text.Length; i++)
            {
                Char currentChar = text[i];

                if (res.Length == 0 || res.Last() != currentChar)
                {
                    res += currentChar;
                }
            }
        }

        return res;
    }

    public static bool IsVowel(Char ch)
    {
        for(int i = 0; i < VOWELS.Length; i++)
        {
            if (VOWELS[i] == ch)
            {
                return true;
            }
        }

        return false;
    }
}