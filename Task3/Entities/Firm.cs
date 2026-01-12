namespace Task3.Entities;

public enum Profile
{
    Marketing,
    It,
    Advertising
}

public class Firm
{
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
    public Profile BusinessProfile { get; set; }
    public string DirectorName { get; set; }
    public string Address { get; set; }

    public List<Worker> Workers { get; set; } = new List<Worker>();
    
    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Creation Date: {CreationDate}");
        Console.WriteLine($"BusinessProfile: {BusinessProfile}");
        Console.WriteLine($"DirectorName: {DirectorName}");
        Console.WriteLine($"Address: {Address}");
        foreach (var worker in Workers)
            worker.Print();
        Console.WriteLine("--------------------------");
    }
}