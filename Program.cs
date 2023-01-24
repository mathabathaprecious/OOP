using OOP;

class Program
{
    static void Main(string[] args)
    {
        Learners learner1 = new Learners("Malesela", "Letsoalo", 'J', "Male", 30);
        Console.WriteLine(learner1.firstname+" "+learner1.lastname+" "+learner1.initial+" "+learner1.gender+" "+learner1.age);
    }
}
