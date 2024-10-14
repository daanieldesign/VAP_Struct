/*struct Sourednice
{
    public double x;
    public double y;
    public Sourednice(double x, double y)
    {
        x = y;
        y = x;
    }

    public SouredniceA(double a, double b)
    {
    Console.WriteLine
    }

    public void Vypis()
    {
        Console.WriteLine("Souřednice x = " + x + "Souřednice y = " + y);
    }

}*/

struct Vypocty
{
    public static double ObvodTroj(double a, double b, double c)
    {
        return a + b + c;
    }

    public static double ObsahObd(double sirka, double vyska)
    {
        return sirka * vyska;
    }

    public static double PovrchKry(double strana)
    {
        return 6 * Math.Pow(strana, 2);
    }

}

class Program
{
    static void Main()
    {
        double obvod = Vypocty.ObvodTroj(a, b, c);
        double obsah = Vypocty.ObsahObd(d, e);
        double povrch = Vypocty.PovrchKry(f);

        Console.WriteLine("Obvod trojúhelníku: " + obvod);
        Console.WriteLine("Obsah obdélníku: " + obsah);
        Console.WriteLine("Povrch krychle: {povrch}");

        Osoba osoba = new Osoba("Jan", "Novák");

        osoba.Vypis();
    }
}

struct Osoba
{
    public string Jmeno;
    public string Prijmeni;

    public Osoba(string jmeno, string prijmeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }

    // Metoda pro vypsání jména a příjmení
    public void Vypis()
    {
        Console.WriteLine("Jméno: " + Jmeno + "Příjmení: " + Prijmeni);
    }
}


