namespace _01_functions;

class Program
{
    static void Main(string[] args) // deze function
    {
        Program program = new Program(); //program, string
        program.Run();

    }

    void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        Vraag1();
    }

    internal void Vraag1()
    {
        Console.WriteLine("How long do you think you would survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();
        Console.WriteLine("You answered: " + antwoord);
    }
}
