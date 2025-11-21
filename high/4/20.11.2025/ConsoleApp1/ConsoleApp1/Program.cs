class Program
{
    public static void Main(String[] args)
    {

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

                if (i == 0 || res[i - 1] != currentChar)
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