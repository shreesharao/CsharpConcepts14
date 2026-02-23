using System.Diagnostics;

namespace CsharpConcepts14;

public static class Topic1
{
    public static void Entry()
    {
        Console.WriteLine("Topic 1: Extension members");
        List<int> list = [];
        Console.WriteLine(list.IsEmpty);
        Console.WriteLine(List<int>.ContainsElement(list, 1));
        Console.WriteLine(list.OldWayContainsElement(1));
    }
}


public static class EnumerableExtensions
{
    public static bool OldWayContainsElement<TSource>(this IEnumerable<TSource> elements, TSource element) => elements.Contains(element);

    //New extension keyword
    extension<TSource>(IEnumerable<TSource> source)
    {
        //Instance member
        public bool IsEmpty => !source.Any();

        //static member
        public static bool ContainsElement(IEnumerable<TSource> elements, TSource element) => elements.Contains(element);
    }
}