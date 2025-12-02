using System.Diagnostics;

class Program
{
    public static void Main(String[] args)
    {
        RunTests();

        int[] array = GetRandomArray(100);
        Sort(array);

        Console.WriteLine("Posortowana tablica:");

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

    static void RunTests()
    {
        Debug.Assert(
            ArrayEquals(
                    SortAndReturn([ 1, 3, 2]), 
                    [1, 2, 3]
            ),
            "Test 1 błędny"
        );

        Debug.Assert(
            !ArrayEquals(
                    SortAndReturn([2, 1, 3]),
                    [3, 2, 1]
            ),
            "Test 2 błędny"
        );
    }

    static int[] SortAndReturn(int[] array)
    {
        Sort(array);
        return array;
    }

    static bool ArrayEquals(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        for (uint i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }
  }