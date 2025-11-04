using System.Reflection.Metadata.Ecma335;

class Program
{
    public static void Main(string[] args) {
        Console.WriteLine("Co chcesz zrobić?");
        Console.WriteLine("1) Obliczyć dane koła");
        Console.WriteLine("2) Obliczyć dane prostokąta");

        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                RunCircle();
                break;
            case "2":
                RunRect();
                break;
            default:
                Console.WriteLine("co");
                break;
        }
    }

    static void RunCircle()
    {
        Console.Write("Promień: ");
        double r = Double.Parse(Console.ReadLine()!);

        Circle circ = new Circle(r);

        Console.WriteLine(circ.ToString());
        Console.WriteLine($"Pole: {circ.GetArea()}");
        Console.WriteLine($"Obwód: {circ.GetOblast()}");
    }

    static void RunRect()
    {
        Console.Write("Szerokość: ");
        double w = Double.Parse(Console.ReadLine()!);

        Console.Write("Wysokość: ");
        double h = Double.Parse(Console.ReadLine()!);

        Rect rect = new Rect(w, h);

        Console.WriteLine(rect.ToString());
        Console.WriteLine($"Pole: {rect.GetArea()}");
        Console.WriteLine($"Obwód: {rect.GetOblast()}");
    }
}

class Rect
{
    double width;
    double height;

    public Rect(double w, double h)
    {
        width = w;
        height = h;
    }

    public double GetArea()
    {
        return width * height;
    }

    public double GetOblast()
    {
        return 2 * width + 2 * height;
    }

    public override string ToString()
    {
        return $"Prostokąt [{width}, {height}]";
    }
}

class Circle
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    } 

    public double GetArea()
    {
        return double.Pi * Math.Pow(radius, 2);
    }
    public double GetOblast() {
        return 2 * double.Pi * radius;
    }

    public override string ToString()
    {
        return $"Koło [{radius}]";
    }
}
