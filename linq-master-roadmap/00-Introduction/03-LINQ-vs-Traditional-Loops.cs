namespace LinqMasterRoadmap.Introduction;

internal static class LinqVsTraditionalLoops
{
    public static void Run()
    {
        Console.WriteLine("=== LINQ vs Traditional Loops ===\n");
        TraditionalLoopExample();
        LinqExample();

    }

    // --------------------------------------------
    // Example 1. Traditional Imperative Approach
    // --------------------------------------------

    private static void TraditionalLoopExample()
    {
        var numbers = new[] { 5, 12, 8, 20, 3, 18 };
        var results = new List<int>();

        foreach (var number in numbers)
        {
            if (number > 10)
            {
                result.Add(number);
            }

        }
        Console.WriteLine("Traditional Loop Result:")
        foreach (var number in results)
        {
            Console.Write(number);
        }

        Console.WriteLine();


    }

    // --------------------------------------------
    // Example 2. LINQ Declarative Approach
    // --------------------------------------------
    private static void LinqExample()
    {
        var numbers = new[] { 5, 12, 8, 20, 3, 18 };

        var results = numbers.Where(numbers => numbers > 10)


        Console.WriteLine("LINQ Result");
        foreach (var number in results)
        {
            Console.Write(number);

        }
    } 
}
