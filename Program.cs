namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // ControlFlow.DivisibleByThree();
        // ControlFlow.NumberOrExit();
        // ControlFlow.CountFactorial();
        // ControlFlow.GuessTheNumber();

        // ListsExercises.LikesCounter();
        // ListsExercises.ReverseName();
        // ListsExercises.GiveMeAFiveNumbers();
        // ListsExercises.GatherNumbers();
        // ListsExercises.PrintThreeSmallestNumbers();
    }

    private static void PrintList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void PrintCollection<T>(T[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
