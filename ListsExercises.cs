namespace HelloWorld;

class ListsExercises
{
    public static void PrintThreeSmallestNumbers()
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

    public static void GatherNumbers()
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

    public static void GiveMeAFiveNumbers()
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

    public static void ReverseName()
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

    public static void LikesCounter()
    {
        var friends = EnterData("Put your friends name or put nothing to end program");
        var isNullOrEmpty = friends?.Any() != true;

        if (isNullOrEmpty)
        {
            return;
        }

        if (friends.Count == 1)
        {
            Console.WriteLine((string)"{0} likes your post", (object?)friends[0]);
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
}