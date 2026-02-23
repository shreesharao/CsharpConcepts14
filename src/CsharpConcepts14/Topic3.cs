namespace CsharpConcepts14;

public static class Topic3
{
    public static void Entry()
    {
        Console.WriteLine("Topic 3. Unbound generic types and nameof");
        Console.WriteLine(nameof(List<>));
        Console.WriteLine(nameof(List<int>));
    }
}
