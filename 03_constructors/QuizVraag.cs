namespace _03_constructors;

class QuizVraag
{
    internal string vraag;
    internal string antwoord;

    internal QuizVraag (string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
    
    internal void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");
    }
}