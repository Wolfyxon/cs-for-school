/*
 Założenia aplikacji:
‒ Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub
C#, lub Java, lub Python
‒ Implementacja algorytmu w pełni zgodna z przedstawionym na schemacie algorytmem
‒ Liczby a i b należą do zbioru liczb całkowitych dodatnich (odpowiedni typ lub kontrola poprawności
wpisanej liczby)
‒ Szukanie NWD zaimplementowane w funkcji o dwóch argumentach i zwracanej wartości
największego wspólnego dzielnika. Funkcja nie może zawierać operacji wejścia - wyjścia
‒ Program główny testuje działanie funkcji i zawiera operacje wejścia - wyjścia
‒ Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy
stosować nazwy zmiennych zgodne z nazwami zastosowanymi na schemacie blokowym, pozostałe
nazwy muszą być znaczące
‒ Do kodu należy dołączyć dokumentację, która została opisana w części III zadania egzaminacyjnego.
 */

class Program
{
    /**********************************************
    nazwa funkcji: Main
    opis funkcji: Punkt startowy programu
    parametry:  args - Parametry wejściowe programu
    zwracany typ i opis: brak
    autor: 1234567890
    ***********************************************/
    public static void Main(String[] args) 
    {
        Console.Write("Podaj A: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Podaj B: ");
        int b = int.Parse(Console.ReadLine()!);

        int nwd = Nwd(a, b);

        Console.WriteLine($"NWD wynosi: {nwd}");
    }

    /**********************************************
    nazwa funkcji: Nwd
    opis funkcji: Oblicza największy wspólny dzielnik dwóch liczb
    parametry:  a – Pierwsza liczba
                b – Druga liczba
    zwracany typ i opis: int - największy wspólny dzielnik a i b
    autor: 1234567890
    ***********************************************/
    static int Nwd(int a, int b)
    {
        while(a != b)
        {
            if(a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }

        return a;
    }
}