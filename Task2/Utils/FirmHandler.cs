namespace Task2.Utils;
using Task1.Entities;

public static class FirmHandler
{
    public static void Print(this IEnumerable<Firm> firms)
    {
        foreach (var firm in firms)
            firm.Print();
        Console.WriteLine();
    }
    
    public static IEnumerable<Firm> GetAllFirms(this List<Firm> firms)
    {
        return firms;
    }

    public static IEnumerable<Firm> GetAllFoodFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.Name.Contains("Food"));
    }
    
    public static IEnumerable<Firm> GetAllMarketingFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.BusinessProfile ==  Profile.Marketing);
    }
    
    public static IEnumerable<Firm> GetAllMarketingOrItFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.BusinessProfile ==  Profile.Marketing || f.BusinessProfile == Profile.It);
    }
    
    public static IEnumerable<Firm> GetAllFirmsWithMoreThan100Workers(this List<Firm> firms)
    {
        return firms.Where(f => f.WorkerAmount > 100);
    }
    
    public static IEnumerable<Firm> GetAllFirmsWithBetween100And300Workers(this List<Firm> firms)
    {
        return firms.Where(f => f.WorkerAmount > 100 && f.WorkerAmount < 300);
    }
    
    public static IEnumerable<Firm> GetAllLondonFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.Address.Contains("London"));
    }
    
    public static IEnumerable<Firm> GetAllWhiteDirectorFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.DirectorName.Split(' ')[1] == "White");
    }
    
    public static IEnumerable<Firm> GetAllOldFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.CreationDate > DateTime.Now.AddYears(-2));
    }
    
    public static IEnumerable<Firm> GetAll123DaysOldFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.CreationDate == DateTime.Now.AddDays(123));
    }

    public static IEnumerable<Firm> GetAllBlackDirectorAndWhiteNameFirms(this List<Firm> firms)
    {
        return firms.Where(f => f.DirectorName.Split(' ')[1] == "Black" && f.Name.Contains("White"));
    }
}