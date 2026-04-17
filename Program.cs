namespace HelloWorld;

using static System.Math;

class Program
{
    static void Main(string[] args)
    {
        // DivisibleByThree();
        // NumberOrExit();
        // CountFactorial();
        // GuessTheNumber();
    }

    private static void DivisibleByThree()
    {
        var numbersLength = 100;
        var counter = 0;
        
        for (int i = 0; i < numbersLength; i++) 
        {
            if (i % 3 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("Divisible by three result: {0}", counter);
    }

    private static void NumberOrExit()
    {
        var exitWord = "ok";
        var sum = 0;

        while (true)
        {
            Console.WriteLine("Put a number or type 'ok' to exit");
            var input = Console.ReadLine();
            var isValid = int.TryParse(input, out var number);
            
            if (isValid) sum += number;
            if (input == exitWord)
            {
                break;
            }
        }

        Console.WriteLine("The sum is: {0}", sum);
    }

    private static void CountFactorial()
    {
        Console.WriteLine("Enter a number:");
        var input = Console.ReadLine();
        var result = 1;
        var isValid = int.TryParse(input, out var number);

        // for (int i = number; i > 0; i--)
        // {
        //    result *= i;
        // }

        var j = number;
        while (j > 0)
        {
            result *= j;
            j--;
        }
        
        Console.WriteLine("The result is: {0}", result);
    }
    
    private static void GuessTheNumber()
    {
        var random = new Random();
        var number = random.Next(1, 10);
        var chances = 4;

        while (chances > 0) 
        {
            Console.WriteLine("Guess a number between 1 and 10");
            var isValid = int.TryParse(Console.ReadLine(), out var guess);

            if (isValid && guess == number)
            {
                Console.WriteLine("You are correct!\nThe number is {0}", number);
                break;
            }
            
            chances--;
        }
        
        if (chances == 0)
            Console.WriteLine("You loose!");
    }
}