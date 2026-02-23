namespace CsharpConcepts14;

public static class Topic7
{
    public static void Entry()
    {
        Console.WriteLine("Topic 7. Partial constructors and events");

        var topic7A = new Topic7A();
        Console.WriteLine(topic7A.MyProperty);

        topic7A.SomeEvent += (sender, e) => Console.WriteLine($"Event {e} fired");

        topic7A.Raise();
    }
}

public partial class Topic7A
{
    public int MyProperty { get; }
    public partial Topic7A();
    public partial event EventHandler SomeEvent;
}

public partial class Topic7A
{
    public partial Topic7A()
    {
        MyProperty = 1;
    }
    private EventHandler? _events;
    public partial event EventHandler SomeEvent
    {
        add { _events += value; }
        remove { _events -= value; }
    }
    public void Raise()
    {
        _events?.Invoke(sender: this, e: EventArgs.Empty);
    }
}
