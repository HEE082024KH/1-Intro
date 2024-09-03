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
        Console.WriteLine("Hei " + navn);
        // Char typen, tar en bestemt bokstav
        char a = '@';
        Console.WriteLine(a);

        string[] myStringArray = {"Hello", "C#", "Array!"};
        for(int i = 0; i < myStringArray.Length; i++) {
                Console.WriteLine(myStringArray[i]);
           };

        List<int> myNumbers = new List<int>();
        myNumbers.Add(1);
        myNumbers.Add(2);
        myNumbers.Add(3);
        foreach(int numbers in myNumbers) {
        Console.WriteLine(numbers);
        }

        string? greeting = Console.ReadLine();
        switch(greeting) {
            case "Hei":
                Console.WriteLine("Hei Terminal!");
                break;
            case "Hade":
                Console.WriteLine("Snakkes");
                break;
            default:
                Console.WriteLine("Alrighty");
                break;
        }

        // Henter variabel utenfra main scope
        Console.WriteLine(myInt);
    }

    // Må legge til static, for å kunne hentes inn i main scope
    static int myInt = 5;
}
