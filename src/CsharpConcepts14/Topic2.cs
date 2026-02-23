namespace CsharpConcepts14;

public static class Topic2
{
    public static void Entry()
    {
        Console.WriteLine("Topic2: Null-conditional assignment");
        Topic2A? topic2A = null;

        //Null-conditional assignment
        topic2A?.MyProperty = "Hello";

        topic2A?.Strings?[0] = "Hello";
        Console.WriteLine(topic2A?.MyProperty ?? "Accessing null property");

    }
}

public class Topic2A
{
    public string? MyProperty { get; set; }
    public string[]? Strings { get; set; }
}
