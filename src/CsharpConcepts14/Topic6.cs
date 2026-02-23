namespace CsharpConcepts14;

public static class Topic6
{
    public static void Entry()
    {
        Console.WriteLine("Topic 6. The field keyword");
        var topic6A = new Topic6A
        {
            MyProperty = "Hello"
        };
        Console.WriteLine(topic6A.MyProperty);
    }
}

public class Topic6A
{
    //This is to avoid warning of making MyProperty static property.
    private readonly string prefix = "Mr.";
    public string? MyProperty
    {
        get => field;
        set => field = prefix + value ?? throw new ArgumentNullException(nameof(MyProperty));
    }
}