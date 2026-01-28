namespace _04_Lists;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run;
    }

    internal void Run()
    {
        double[] prijzen = new double[] { 0, 99, 5.60, 10.11 };

        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu" };

        Formulier[] formulieren = new Formulier[2];
    }

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }
}