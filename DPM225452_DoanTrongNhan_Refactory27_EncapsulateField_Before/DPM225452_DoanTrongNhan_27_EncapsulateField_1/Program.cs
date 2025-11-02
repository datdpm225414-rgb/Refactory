class Person
{
    public string name;
}
public class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.name = "Test";
        Console.WriteLine(p.name);
    }
}