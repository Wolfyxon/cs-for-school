/*
Napisz program sortujący tablicę metodą przez wybieranie według zamieszczonej dokumentacji:

Sortowanie przez wybieranie - jedna z prostszych metod sortowania o złożoności O(n^2). 
Polega na wyszukaniu elementu mającego się znaleźć na żądanej pozycji i zamianie miejscami z tym, który jest tam
obecnie. Operacja jest wykonywana dla wszystkich indeksów sortowanej tablicy.
Algorytm przedstawia się następująco:
1. wyszukaj minimalną wartość z tablicy spośród elementów od i do końca tablicy
2. zamień wartość minimalną, z elementem na pozycji i
Gdy zamiast wartości minimalnej wybierana będzie maksymalna, wówczas tablica będzie posortowana
od największego do najmniejszego elementu.

Założenia do programu
‒ Program wykonywany w konsoli.
‒ Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub
C# lub Java lub Python.
‒ Sortowanie odbywa się malejąco, nie wykorzystuje gotowych funkcji do sortowania oraz do szukania
maksimum.
‒ Sortowana jest tablica 10 liczb całkowitych. Tablica jest polem klasy.
‒ Tablica jest wczytywana z klawiatury po uprzednim wypisaniu odpowiedniego komunikatu.
‒ Wszystkie elementy posortowanej tablicy są wyświetlane na ekranie.
‒ Klasa zawiera co najmniej dwie metody: sortującą i szukającą wartość najwyższą. Widzialność
metody szukającej ogranicza się jedynie do klasy.
‒ Metoda szukająca zwraca wartość, w zależności od przyjętej taktyki może być to wartość
maksymalna lub index wartości maksymalnej.
‒ Program powinien być zapisany czytelnie, z zasadami czystego formatowania kodu, należy stosować
znaczące nazwy zmiennych i funkcji.
‒ Dokumentacja do programu wykonana zgodnie z wytycznymi z części III zadania egzaminacyjnego.

*/

class Program
{
    const int DesiredLength = 10;
    static int[] nums = { };

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczby (oddzielone spacją):");
        string? input = Console.ReadLine();

        if(input == null)
        {
            Console.WriteLine("Błąd odczytu");
            return;
        }

        string[] inputSplit = input.Split(" ");

        if(inputSplit.Length != DesiredLength)
        {
            Console.WriteLine($"UWAGA: Egzamin zakłada {DesiredLength} liczb, jednak podałeś {inputSplit.Length}. Kontynuowanie...");
        }

        foreach(string str in inputSplit)
        {
            nums = nums.Append(int.Parse(str)).ToArray();
        }
        
        Console.WriteLine($"Przed sortowaniem: {IntArrayToString(nums)}");
        Sort(nums);
        Console.WriteLine($"Po sortowaniu: {IntArrayToString(nums)}");
    }

    static string IntArrayToString(int[] array)
    {
        string res = "";

        foreach(int n in array)
        {
            res += n + " ";
        }

        return res;
    }

    static void Sort(int[] array)
    {
        if(array.Length == 0)
        {
            return;
        }

        for(int i = 0; i < array.Length; i++) {
            int maxIdx = GetMaxIdx(array, i);
            int max = array[maxIdx];
            int n = array[i];

            array[i] = max;
            array[maxIdx] = n;
        }
    }
    
    static int GetMaxIdx(int[] array, int start = 0)
    {
        int maxI = -1;

        for(int i = start; i < array.Length; i++)
        {
            if(maxI == -1)
            {
                maxI = i;
            }

            int max = array[maxI];
            int n = array[i];

            if(n > max)
            {
                maxI = i;
            }
        }

        return maxI;
    }
}