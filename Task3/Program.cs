using Task3.Entities;
using Task3.Utils;

var firms = new List<Firm>
{
    new Firm
    {
        Name = "White Food Marketing",
        CreationDate = DateTime.Now.AddYears(-3),
        BusinessProfile = Profile.Marketing,
        DirectorName = "John White",
        Address = "London, Baker Street 10",
        Workers =
        {
            new Worker
            {
                Name = "Lionel Smith",
                Position = "Manager",
                Phone = "231234567",
                Email = "director@whitefood.com",
                Salary = 5000
            },
            new Worker
            {
                Name = "Anna Brown",
                Position = "Designer",
                Phone = "451234567",
                Email = "anna@whitefood.com",
                Salary = 3200
            }
        }
    },

    new Firm
    {
        Name = "IT Solutions Hub",
        CreationDate = DateTime.Now.AddYears(-5),
        BusinessProfile = Profile.It,
        DirectorName = "Michael Brown",
        Address = "London, Silicon Road 42",
        Workers =
        {
            new Worker
            {
                Name = "David Wilson",
                Position = "Manager",
                Phone = "239876543",
                Email = "di.wilson@ithub.com",
                Salary = 6000
            },
            new Worker
            {
                Name = "Lionel Adams",
                Position = "Developer",
                Phone = "789456123",
                Email = "lionel@ithub.com",
                Salary = 4500
            }
        }
    },

    new Firm
    {
        Name = "Global Food Advertising",
        CreationDate = DateTime.Now.AddYears(-10),
        BusinessProfile = Profile.Advertising,
        DirectorName = "James Wilson",
        Address = "Rome, Via Roma 25",
        Workers =
        {
            new Worker
            {
                Name = "Diana Green",
                Position = "Manager",
                Phone = "231119999",
                Email = "di.green@globalfood.com",
                Salary = 7000
            },
            new Worker
            {
                Name = "Mark Taylor",
                Position = "Copywriter",
                Phone = "991234567",
                Email = "mark@globalfood.com",
                Salary = 2800
            }
        }
    }
};

var allWorkers = firms[0].GetAllWorkers();
Console.WriteLine("===== ALL WORKERS =====");
allWorkers.Print();

var privilegedWorkers = firms[2].GetAllWorkersWithSalaryBiggerThan(3000);
Console.WriteLine("===== SALARY BIGGER THAN 3000 WORKERS =====");
privilegedWorkers.Print();

var managers = firms.GetAllManagers();
Console.WriteLine("===== MANAGERS =====");
managers.Print();

var workersWithPhoneNumberStartingWith23 = firms[2].GetAllWorkersWithPhoneNumberStartingWith23();
Console.WriteLine("===== WORKERS WITH PHONE NUMBER STARTING WITH 23 =====");
workersWithPhoneNumberStartingWith23.Print();

var workersWithEmailStartingWithdi = firms[2].GetAllWorkersWithEmailStartingWithdi();
Console.WriteLine("===== WORKERS WITH EMAIL STARTING WITH di =====");
workersWithEmailStartingWithdi.Print();

var lionels = firms[1].GetAllLionels();
Console.WriteLine("===== LIONELS =====");
lionels.Print();