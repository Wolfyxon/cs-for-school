class Program
{
    static void Main(String[] args)
    {
        Film film = new Film("Pięć Koszmarnych Nocy");

        film.SetTytul("Pięć Koszmarnych Nocy 2");
        Console.WriteLine($"tytuł: {film.GetTytul()} wypożyczenia: {film.GetWypozyczenia()}");
        
        Console.Write($"Przed inkrementacją: {film.GetWypozyczenia()} ");
        film.Inkrementuj();
        Console.WriteLine($"po inkrementacji: {film.GetWypozyczenia()}");
    }
}

class Film
{
    private String _tytul;
    private int _wypozyczenia;

    public Film(String tytul)
    {
        this._tytul = tytul;
        this._wypozyczenia = 0;
    }

    public void Inkrementuj()
    {
        this._wypozyczenia += 1;
    }

    public void SetTytul(String tytul)
    {
        this._tytul = tytul;
    }

    public string GetTytul()
    {
        return this._tytul;
    }

    public int GetWypozyczenia()
    {
        return this._wypozyczenia;
    }
}