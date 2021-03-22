using System;

namespace AuthorProblem
{
    [Author("Az")]
    [Author("Ti")]
    [Author("Nie")]
    public class StartUp
    {
        [Author("Otnovo az")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }
    }
}
