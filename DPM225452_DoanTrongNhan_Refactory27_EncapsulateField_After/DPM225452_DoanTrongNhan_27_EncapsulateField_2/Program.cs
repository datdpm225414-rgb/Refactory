class Person
{
    private string name;

    public string Name // thuộc tính không phải hàm
    {
        get { return name; }
        set { name = value; }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Test";
        Console.WriteLine(person.Name);
    }
}