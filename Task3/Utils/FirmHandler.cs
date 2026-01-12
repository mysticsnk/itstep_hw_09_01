namespace Task3.Utils;
using Task3.Entities;

public static class FirmHandler
{
    public static List<Worker> GetAllWorkers(this Firm f)
    {
        return f.Workers;
    }
    
    public static List<Worker> GetAllWorkersWithSalaryBiggerThan(this Firm f, int s)
    {
        return f.Workers.Where(w => w.Salary > s).ToList();
    }
    
    public static List<Worker> GetAllManagers(this List<Firm> firms)
    {
        return firms.SelectMany(f => f.Workers).Where(w => w.Position.Contains("Manager")).ToList();
    }

    public static List<Worker> GetAllWorkersWithPhoneNumberStartingWith23(this Firm f)
    {
        return f.Workers.Where(w => w.Phone.StartsWith("23")).ToList();
    }

    public static List<Worker> GetAllWorkersWithEmailStartingWithdi(this Firm f)
    {
        return f.Workers.Where(w => w.Email.StartsWith("di")).ToList();
    }

    public static List<Worker> GetAllLionels(this Firm f)
    {
        return f.Workers.Where(w => w.Name.StartsWith("Lionel")).ToList();
    }

    public static void Print(this IEnumerable<Worker> workers)
    {
        foreach(var worker in workers)
            worker.Print();
    }
}