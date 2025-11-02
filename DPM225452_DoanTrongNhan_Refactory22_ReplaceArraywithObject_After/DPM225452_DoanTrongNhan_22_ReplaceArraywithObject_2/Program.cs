public class Performance
{
    public string name {  get; set; }
    public string wins { get; set; }
    public void SetName(string n)
    {
        name = n;
    }
    public void SetWins (string n)
    {
        wins = n;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Performance row = new Performance();
        row.SetName("Liverpool");
        row.SetWins("15");
        Console.WriteLine("Name: " + row.name + ", wins: " + row.wins);
    }
}
