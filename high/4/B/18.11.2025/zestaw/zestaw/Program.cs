class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Podaj liczbę: ");
        int num = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Silnia {num}!: {Factorial(num)}");
    }

    static int Factorial(int n)
    {
        int res = 1;

        for(int i = 1; i <= n; i++)
        {
            res *= i;
        }

        return res;
    }
}