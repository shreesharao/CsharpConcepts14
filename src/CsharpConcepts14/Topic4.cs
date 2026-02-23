namespace CsharpConcepts14;

public static class Topic4
{
 public static void Entry()
    {
        Console.WriteLine("Topic 4. Implicit span conversions");
        ReadOnlySpan<char> span = "Hello";
        Console.WriteLine(span);
    }
}
