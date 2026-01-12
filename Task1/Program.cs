using Task1.Entities;
using Task1.Utils;


List<Firm> firms = new List<Firm>
{
    new Firm
    {
        Name = "White Food Marketing",
        CreationDate = DateTime.Now.AddYears(-3),
        BusinessProfile = Profile.Marketing,
        DirectorName = "John White",
        WorkerAmount = 250,
        Address = "London, Baker Street 10"
    },

    new Firm
    {
        Name = "Black Advertising Group",
        CreationDate = DateTime.Now.AddYears(-1),
        BusinessProfile = Profile.Advertising,
        DirectorName = "Emily Black",
        WorkerAmount = 80,
        Address = "New York, Madison Avenue 5"
    },

    new Firm
    {
        Name = "IT Solutions Hub",
        CreationDate = DateTime.Now.AddYears(-5),
        BusinessProfile = Profile.It,
        DirectorName = "Michael Brown",
        WorkerAmount = 500,
        Address = "London, Silicon Road 42"
    },

    new Firm
    {
        Name = "Food Marketing Corp",
        CreationDate = DateTime.Now.AddDays(-123),
        BusinessProfile = Profile.Marketing,
        DirectorName = "Sarah Green",
        WorkerAmount = 120,
        Address = "Berlin, Central Platz 3"
    },

    new Firm
    {
        Name = "White IT Services",
        CreationDate = DateTime.Now.AddYears(-4),
        BusinessProfile = Profile.It,
        DirectorName = "Robert Black",
        WorkerAmount = 300,
        Address = "London, Tech Avenue 7"
    },

    new Firm
    {
        Name = "Small Marketing Studio",
        CreationDate = DateTime.Now.AddMonths(-6),
        BusinessProfile = Profile.Marketing,
        DirectorName = "Anna White",
        WorkerAmount = 15,
        Address = "Paris, Rue de Code 9"
    },

    new Firm
    {
        Name = "Global Food Advertising",
        CreationDate = DateTime.Now.AddYears(-10),
        BusinessProfile = Profile.Advertising,
        DirectorName = "James Wilson",
        WorkerAmount = 1000,
        Address = "Rome, Via Roma 25"
    }
};


var allFirms = firms.GetAllFirms();
Console.WriteLine("===== ALL FIRMS =====");
allFirms.Print();

var foodFirms = firms.GetAllFoodFirms();
Console.WriteLine("===== FOOD FIRMS =====");
foodFirms.Print();
    
var marketingFirms = firms.GetAllMarketingFirms();
Console.WriteLine("===== MARKETING FIRMS =====");
marketingFirms.Print();

var marketingOrItFirms = firms.GetAllMarketingOrItFirms();
Console.WriteLine("===== MARKETING OR IT FIRMS =====");
marketingOrItFirms.Print();

var moreThan100WorkerFirms = firms.GetAllFirmsWithMoreThan100Workers();
Console.WriteLine("===== MORE THAN 100 WORKER FIRMS =====");
moreThan100WorkerFirms.Print();

var between100And300WorkerFirms = firms.GetAllFirmsWithBetween100And300Workers();
Console.WriteLine("===== BETWEEN 100 AND 300 WORKER FIRMS =====");
between100And300WorkerFirms.Print();

var londonFirms = firms.GetAllLondonFirms();
Console.WriteLine("===== LONDON FIRMS =====");
londonFirms.Print();

var whiteDirectorFirms = firms.GetAllWhiteDirectorFirms();
Console.WriteLine("===== WHITE DIRECTOR FIRMS =====");
whiteDirectorFirms.Print();

var oldFirms = firms.GetAllOldFirms();
Console.WriteLine("===== OLD FIRMS =====");
oldFirms.Print();

var cool123Firms = firms.GetAll123DaysOldFirms();
Console.WriteLine("===== COOL 123 FIRMS =====");
cool123Firms.Print();

var blackDirectorAndWhiteNameFirms = firms.GetAllBlackDirectorAndWhiteNameFirms();
Console.WriteLine("===== BLACK DIRECTOR AND WHITE NAME FIRMS =====");
blackDirectorAndWhiteNameFirms.Print();