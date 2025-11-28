class Program
{
    public static void Main(String[] args)
    {
        int[] array = GetRandomArray(100);
        Sort(array);

        for(uint i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("");
    }

    static void Sort(int[] array)
    {
        bool sorted = false;

        while(!sorted)
        {
            sorted = true;

            for (uint i = 1; i < array.Length; i++)
            {
                int prev = array[i - 1];
                int current = array[i];

                if(prev > current)
                {
                    sorted = false;

                    array[i - 1] = current;
                    array[i] = prev;
                }
            }
        }
    }

    static int[] GetRandomArray(uint len)
    {
        int[] res = new int[len];
        Random rng = new Random();

        for (uint i = 0; i < len; i++)
        {
            res[i] = rng.Next(0, 100);
        }

        return res;
    }
}