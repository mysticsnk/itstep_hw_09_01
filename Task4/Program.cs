int[] numbers = { 121, 75, 81 };
Console.WriteLine("--- Numbers ---");
foreach (var number in numbers) 
    Console.WriteLine(number);

int[] sortedNumbers = numbers.OrderByDescending(num => num.ToString().Aggregate(0, (acc, current) => acc + current - 48)).ToArray();
Console.WriteLine("--- Sorted numbers ---");
foreach (var number in sortedNumbers)
    Console.WriteLine(number);
