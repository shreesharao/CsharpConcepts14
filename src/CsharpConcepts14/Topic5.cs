namespace CsharpConcepts14;

public static class Topic5
{
    delegate bool TryParseNew<T>(string number, out T result);
    public static void Entry()
    {
        Console.WriteLine("Topic 5. Simple lambda parameters with modifiers");
        
        var TryParseOld = (string number, out int result) => int.TryParse(number, out result);
        TryParseOld("123", out int number);
        Console.WriteLine(number);

        TryParseNew<int> TryParseNew = (number, out result) => TryParseOld(number, out result);
        TryParseNew("123", out int num);
        Console.WriteLine(num);
    }
}
