class Program
{
    const int CHARS_START = 97;
    const int CHARS_END = 122;

    public static void Main(String[] args) 
    {
        Console.Write("Podaj tekst (tylko małe litery i spacje): ");
        String text = Console.ReadLine()!;

        Console.Write("Podaj klucz: ");
        int key = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Szyfr cezara: ");
        Console.WriteLine(Ceasar(text, key));
    }

    public static int WrapIndex(int index, int size)
    {
        return ((index % size) + size) % size;
    }

    public static String Ceasar(String text, int key)
    {
        String res = "";

        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            
            if((int)c < CHARS_START || (int)c > CHARS_END)
            {
                res += c;
                continue;
            }
            
            int charRelativeIdx = c - CHARS_START;
            int newRelativeIdx = WrapIndex(charRelativeIdx + key, CHARS_END - CHARS_START);
            
            res += (char)(CHARS_START + newRelativeIdx);
        }

        return res;
    }
}