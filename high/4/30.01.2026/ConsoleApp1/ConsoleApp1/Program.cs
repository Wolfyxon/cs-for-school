class Program
{
    const int LEN = 6;
    const int RANGE_MIN = 1;
    const int RANGE_MAX = 49;

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę losowań: ");
        int count = int.Parse(Console.ReadLine()!);

        int[][] results = {};

        Console.WriteLine("Zestawy wylosowanych liczb:");

        for(int i = 0; i < count; i++)
        {
            int[] arr = GenArray();
            results = results.Append(arr).ToArray();

            PrintArray(i, arr);
        }
        
        for(int num = RANGE_MIN; num <= RANGE_MAX; num++)
        {
            int occurings = 0;

            for(int array_i = 0; array_i < results.Length; array_i++)
            {
                int[] array = results[array_i];

                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        occurings++;
                    }
                }
            }

            Console.WriteLine($"Wystąpienia liczby {num}: {occurings}");
        }
        
    }

    static int[] GenArray()
    {
        int[] res = new int[LEN];
        Random rng = new Random();
        
        for(int i = 0; i < LEN; i++)
        {
            int n = -1;

            while(n == -1 || res.Contains(n))
            {
                n = rng.Next(RANGE_MIN, RANGE_MAX);
            }

            res[i] = n;
        }

        return res;
    }

    static void PrintArray(int index, int[] array)
    {
        Console.Write($"Losowanie {index + 1}: ");

        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();
    }
}