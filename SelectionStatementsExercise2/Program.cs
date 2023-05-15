namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I dislike Math!");
                    break;
                case "biology":
                    Console.WriteLine("I love Biology!");
                    break;
                case "history":
                    Console.WriteLine("I enjoy history.");
                    break;
                case "english":
                    Console.WriteLine("English is okay.");
                    break;
                case "physics":
                    Console.WriteLine("Physics isn't my favorite.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
        }
    }
}