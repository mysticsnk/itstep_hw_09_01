namespace Task1.Utils;
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
        return from firm in firms select firm;
    }

    public static IEnumerable<Firm> GetAllFoodFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.Name.Contains("Food") select firm;
    }
    
    public static IEnumerable<Firm> GetAllMarketingFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.BusinessProfile == Profile.Marketing select firm;
    }
    
    public static IEnumerable<Firm> GetAllMarketingOrItFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.BusinessProfile == Profile.Marketing || firm.BusinessProfile == Profile.It select firm;
    }
    
    public static IEnumerable<Firm> GetAllFirmsWithMoreThan100Workers(this List<Firm> firms)
    {
        return from firm in firms where firm.WorkerAmount > 100 select firm;
    }
    
    public static IEnumerable<Firm> GetAllFirmsWithBetween100And300Workers(this List<Firm> firms)
    {
        return from firm in firms where firm.WorkerAmount < 300 && firm.WorkerAmount > 100 select firm;
    }
    
    public static IEnumerable<Firm> GetAllLondonFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.Address.Contains("London") select firm;
    }
    
    public static IEnumerable<Firm> GetAllWhiteDirectorFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.DirectorName.Split(' ')[1] == "White" select firm;
    }
    
    public static IEnumerable<Firm> GetAllOldFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.CreationDate < DateTime.Now.AddYears(-2) select firm;
    }
    
    public static IEnumerable<Firm> GetAll123DaysOldFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.CreationDate == DateTime.Now.AddDays(-123) select firm;
    }

    public static IEnumerable<Firm> GetAllBlackDirectorAndWhiteNameFirms(this List<Firm> firms)
    {
        return from firm in firms where firm.DirectorName.Split(' ')[1] == "Black" && firm.Name.Contains("White") select firm;
    }
}