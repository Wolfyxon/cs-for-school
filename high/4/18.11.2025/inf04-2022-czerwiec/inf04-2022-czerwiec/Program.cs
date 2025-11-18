
/*
Napisz program implementujący algorytm przeszukiwania tablicy z wartownikiem. Opis algorytmu znajduje
się w ramce.

By odnaleźć element x podejmiemy następujące kroki:
1. na końcu tablicy (pod indeksem n+1) wstawimy szukany element x - będzie to nasz wartownik,
w przypadku, gdy nie znajdziemy go nigdzie indziej w tablicy, zabezpieczy nas on przed wyjściem
poza tablicę,
2. przejdziemy po kolejnych elementach tablicy, tak długo aż nie znajdziemy szukanego elementu,
3. w momencie znalezienia szukanego elementu x sprawdzamy, który jest to element tablicy? Jeżeli
jest to ostatni element tablicy (n+1) to trafiliśmy na naszego wartownika i oznacza to, że w tablicy
nie było szukanego elementu x, w przeciwnym razie element x został odnaleziony.

Założenia do programu:
‒ Program wykonywany w konsoli.
‒ Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku
egzaminacyjnym: C++ lub C#, lub Java, lub Python.
‒ Przeszukiwana jest minimum 50 elementowa tablica liczb całkowitych wypełniona wartościami
pseudolosowymi z zakresu od 1 do 100.
‒ Wyszukiwane jest pierwsze wystąpienie elementu w tablicy.
‒ Wypełnianie tablicy i przeszukiwanie jest realizowane w oddzielnych funkcjach / metodach. Funkcja
przeszukująca zwraca indeks odnalezionego elementu.
‒ Wartość do wyszukania jest pobierana z klawiatury.
‒ Po przeszukaniu tablicy na ekranie wyświetlana jest zawartość tablicy (liczby oddzielone przecinkami)
oraz indeks, pod którym odszukano wartość lub w przypadku jej braku – stosowny komunikat.
‒ Program powinien podejmować zrozumiałą komunikację z użytkownikiem, dane wprowadzane
i wyprowadzane powinny być opatrzone zrozumiałym opisem.
‒ Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy
stosować znaczące nazwy zmiennych i funkcji.
‒ Program główny powinien zawierać test działania aplikacji.
*/

using System.Security.Cryptography;

class Program
{
    /*
        ******************************************************
        nazwa funkcji: Main
        argumenty: args - String[], argumenty startowe dla programu
        typ zwracany: brak
        informacje: Początkowy punkt programu
        autor: 1234567890
        *****************************************************
    */
    public static void Main(String[] args)
    {
        RunTests();

        int[] randomArray = GetRandomArray(50);
        
        Console.Write("Podaj szukaną liczbę: ");

        int searchedValue = int.Parse(Console.ReadLine()!);
        int index = IndexOf(randomArray, searchedValue);

        Console.WriteLine("Zawartość tablicy:");
        PrintArray(randomArray);

        if(index != -1)
        {
            Console.WriteLine($"Wartość jest na pozycji: {index}");
        } else
        {
            Console.WriteLine("Tablica nie zawiera szukanej wartości");
        }

    }

    /*
        ******************************************************
        nazwa funkcji: IndexOf
        argumenty: array - int[], tablica gdzie ma być szukana wartość
                   value - int, szukana wartość
        typ zwracany: int, indeks szukanej wartości lub -1 gdy jej nie ma w tablicy
        informacje: Funkcja szukająca indeks danej wartości w podanej tablicy
        autor: 1234567890
        *****************************************************
    */
    public static int IndexOf(int[] array, int value)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == value) {
                return i;
            }
        }

        return -1;
    }

    /*
        ******************************************************
        nazwa funkcji: PrintArray
        argumenty: array - int[], tablica do wypisania
        typ zwracany: brak
        informacje: Funkcja wypisująca elementy tablicy
        autor: 1234567890
        *****************************************************
    */
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }

        }
        
        Console.WriteLine();
    }

    /*
        ******************************************************
        nazwa funkcji: IndexOf
        argumenty: len - uint, porządana długość tablicy
        typ zwracany: int[], wygenerowana tablica
        informacje: Funkcja generująca tablicę losowych liczb
        autor: 1234567890
        *****************************************************
    */
    public static int[] GetRandomArray(uint len)
    {
        int[] array = new int[len];

        for(uint i = 0; i < len; i++)
        {
            array[i] = RandomNumberGenerator.GetInt32(1, 100);
        }

        return array;
    }
    /*
    ******************************************************
    nazwa funkcji: TestIndexOf
    argumenty: array - int[], testowa  tablica
               value - int, szukana wartość
               expectedIndex - int, oczekiwany indeks na którym będzie wartość
               testId - uint, numer testu
    typ zwracany: brak
    informacje: Funkcja sprawdzająca poprawne działanie funkcji IndexOf
    autor: 1234567890
    *****************************************************
*/
    public static void TestIndexOf(int[] array, int value, int expectedIndex, uint testId)
    {
        int index = IndexOf(array, value);

        if (index != expectedIndex)
        {
            Console.WriteLine($"Test {testId}: BŁĄD. Oczekiwano {expectedIndex}, otrzymano {index}");
            Environment.Exit(1);
        }
    }

    /*
        ******************************************************
        nazwa funkcji: RunTests
        argumenty: brak
        typ zwracany: brak
        informacje: Funkcja sprawdzająca poprawne działanie programu
        autor: 1234567890
        *****************************************************
    */
    public static void RunTests()
    {
        TestIndexOf([0, 3, 5], 10, -1, 1);
        TestIndexOf([1, 3, 2], 1, 0, 2);
        TestIndexOf([8, 9, 9], 9, 1, 3);

        Console.WriteLine("Testy zakończone poprawnie");
    }
}