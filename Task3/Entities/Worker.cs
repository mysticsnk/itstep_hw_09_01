namespace Task3.Entities;

public class Worker
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Salary { get; set; }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine();
    }
}