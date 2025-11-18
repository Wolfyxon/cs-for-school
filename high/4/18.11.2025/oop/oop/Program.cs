/*
Utwórz klasę Uczen, która będzie zawierać:

    pola: imie, nazwisko, sredniaOcen,
    konstruktor ustawiający wszystkie pola,
    metodę WyswietlInformacje(), która wypisze dane ucznia w formacie:Uczeń: Jan Kowalski, średnia ocen: 4.5

W metodzie Main() utwórz dwóch uczniów i wywołaj dla nich metodę WyswietlInformacje().
Napisz klasę Zwierze, która będzie posiadała:

    pola: gatunek, wiek,
    konstruktor przyjmujący wartości pól,
    metodę DajGlos(), która wypisze komunikat:Pies ma 5 lat i szczeka: Hau hau!

W metodzie Main() utwórz dwa obiekty klasy Zwierze (np. pies, kot) i wywołaj metodę DajGlos() dla każdego.
*/

class Program
{
    public static void Main(String[] args)
    {
        Uczen u1 = new Uczen("Fryderyk", "Fazniedźwiedź", 0.87);
        Uczen u2 = new Uczen("Grzegorz", "Swoboda", 1.7);

        u1.WyswietlInformacje();
        u2.WyswietlInformacje();
    }
}

class Uczen
{
    String imie;
    String nazwisko;
    double sredniaOcen;

    public Uczen(string imie, string nazwisko, double sredniaOcen)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.sredniaOcen = sredniaOcen;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"{imie} {nazwisko}, średnia ocen: {sredniaOcen}");
    }
}
