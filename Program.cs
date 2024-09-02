namespace _1_Intro;

class Program
{
    static void Main(string[] args)
    {
        // String datatype variabel
        string helloWorld = "Hello, World!";
        // Integer variabel
        int myNumber = 10;
        // Desimaltall/double variabel
        double myDecimal = 10.25;

        // Bruker Console klassen til å skrive ut til terminalen
        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber);
        Console.WriteLine(myDecimal);

        // Skriver ut en melding til brukerne
        Console.WriteLine("Hei, hva heter du?");
        // String variabel navn holder på verdien vi gir til konsollen
        string? navn = Console.ReadLine();
        // Skriver ut en liten melding + navnet som er gitt til konsollen
        Console.WriteLine("Hei" + navn);
        // Char typen, tar en bestemt bokstav
        char a = 'A';
        Console.WriteLine(a);
    }
}
