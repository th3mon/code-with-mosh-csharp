namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // DivisibleByThree();
        // NumberOrExit();
        // CountFactorial();
        // GuessTheNumber();

        // LikesCounter();
        // ReverseName();
        // GiveMeAFiveNumbers();
        // GatherNumbers();
        PrintThreeSmallestNumbers();
    }

    private static void PrintThreeSmallestNumbers()
    {
        const string ERROR_MESSAGE = "Invalid List";

        Console.WriteLine("Give me numbers separated by comma");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(ERROR_MESSAGE);
            return;
        }

        var parts = input.Split(',');
        var numbers = new List<int>();

        foreach (var part in parts)
        {
            if (int.TryParse(part.Trim(), out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine(ERROR_MESSAGE);
                return;
            }
        }

        if (numbers.Count < 5)
        {
            Console.WriteLine(ERROR_MESSAGE);
            return;
        }

        var smallestNumbers = numbers.OrderBy(n => n).Take(3);

        Console.WriteLine(string.Join(", ", smallestNumbers));
    }

    private static void GatherNumbers()
    {
        var exitCommand = "quit";
        var numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Give me a number or put (Quit)");
            var input = Console.ReadLine();

            if (input?.ToLower() == exitCommand)
            {
                Console.WriteLine(string.Join(", ", numbers.Distinct()));

                break;
            }

            var isValid = int.TryParse(input, out var number);

            if (isValid)
            {
                numbers.Add(number);
            }
        }
    }

    private static void GiveMeAFiveNumbers()
    {
        var counter = 0;
        var numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Give me a number ({0})", counter + 1);
            var input = Console.ReadLine();

            if (!IsExist(numbers, input))
            {
                int.TryParse(input, out var number);
                numbers.Add(number);

                if (counter >= 4)
                {
                    break;
                }

                counter++;
            }
        }

        numbers.Sort();
        Console.WriteLine(string.Join(", ", numbers));
    }

    private static bool IsExist(List<int> numbers, string? input)
    {
        var isValid = int.TryParse(input, out var number);

        if (isValid)
        {
            var index = numbers.IndexOf(number);

            if (index != -1)
            {
                Console.WriteLine("The number {0} exists. Put anoter one, please.", number);

                return true;
            }
        }

        return false;
    }

    private static void ReverseName()
    {
        Console.WriteLine("Give me your name");
        var name = Console.ReadLine();

        if (name != null)
        {
            var nameAsArray = new char[name.Length];
            var length = name.Length;

            for (int i = 0; i < length; i++)
            {
                nameAsArray[i] = name[i];
            }

            var reversed = nameAsArray.Reverse();

            Console.WriteLine(string.Join("", reversed));
        }
    }

    private static void LikesCounter()
    {
        var friends = EnterData("Put your friends name or put nothing to end program");
        var isNullOrEmpty = friends?.Any() != true;

        if (isNullOrEmpty)
        {
            return;
        }

        if (friends.Count == 1)
        {
            Console.WriteLine("{0} likes your post", friends[0]);
        }
        else if (friends.Count == 2)
        {
            Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
        }
        else
        {
            Console.WriteLine(
                "{0}, {1} like your post and {2} others like your post",
                friends[0],
                friends[1],
                friends.Count - 2
            );
        }
    }

    private static List<string> EnterData(string message)
    {
        var exitCommand = "";
        var data = new List<string>();

        while (true)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (input == exitCommand)
            {
                break;
            }

            data.Add(input);
        }

        return data;
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

            if (isValid)
                sum += number;
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
