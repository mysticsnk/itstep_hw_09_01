int[] numbers = { 121, 75, 81 };
Console.WriteLine("--- Numbers ---");
foreach (var number in numbers) 
    Console.WriteLine(number);

int[] sortedNumbers = { 0 };

Console.WriteLine("How do you want to sort these numbers by their digit sums?");
Console.WriteLine("1 -- Ascending");
Console.WriteLine("2 -- Descending");
int userChoice = Convert.ToInt32(Console.ReadLine());

switch (userChoice)
{
    case 1:
        sortedNumbers = numbers.OrderBy(num => num.ToString().Aggregate(0, (acc, current) => acc + current - 48)).ToArray();
        break;
    case 2:
        sortedNumbers = numbers.OrderByDescending(num => num.ToString().Aggregate(0, (acc, current) => acc + current - 48)).ToArray();
        break;
    default:
        Console.WriteLine("Invalid choice");
        Environment.Exit(0);
        break;
}

Console.WriteLine("--- Sorted numbers ---");
foreach (var number in sortedNumbers)
    Console.WriteLine(number);
