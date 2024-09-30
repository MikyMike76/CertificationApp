using CertificationApp;

Console.WriteLine("Hello! Welcome to the app assessing your physical activity!");
Console.WriteLine();

Console.Write("What's your weight in kilograms? ");
var weight = Console.ReadLine();
try
{
    Trainee.AddWeight(weight);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("What's your weight in kilograms? ");
        weight = Console.ReadLine();
        try
        {
            Trainee.AddWeight(weight);
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!float.TryParse(weight, out float result));
}


Console.Write("What's your age in years? ");
var age = Console.ReadLine();
try
{
    Trainee.AddAge(age);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("What's your age in years? ");
        age = Console.ReadLine();
        try
        {
            Trainee.AddAge(age);
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(age, out int result));
}
Trainee trainee = new Trainee(Trainee.AddWeight(weight), Trainee.AddAge(age));

Console.WriteLine("Now provide the details of your training:");
Console.WriteLine();
Console.Write("Distance you've ridden: ");
var distance = Console.ReadLine();
try
{
    Trainee.AddDistance(distance);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("Distance you've ridden: ");
        distance = Console.ReadLine();
        try
        {
            Trainee.AddDistance(distance);
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!float.TryParse(distance, out float result));
}
Console.WriteLine();
Console.Write("How many minutes did it last: ");
var timeOfRide = Console.ReadLine();
try
{
    Trainee.AddTimeOfRide(timeOfRide);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("How many minutes did it last: ");
        timeOfRide = Console.ReadLine();
        try
        {
            Trainee.AddTimeOfRide(timeOfRide);
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(timeOfRide, out int result));
}
Console.WriteLine();
Console.Write("Your average heart rate: ");
var HRavg = Console.ReadLine();
try
{
    Trainee.AddHRavg(HRavg);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("Your average heart rate: ");
        HRavg = Console.ReadLine();
        try
        {
            Trainee.AddHRavg(HRavg);
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(HRavg, out int result));
}
bool HRavgRangeOk = Calculations.HRavgRangeOk(trainee.HRMax, Trainee.AddHRavg(HRavg)); // ukaże się info, czy HRavg w normie.
trainee.KcalBurnt(Trainee.AddDistance(distance), Trainee.AddTimeOfRide(timeOfRide), trainee.Weight); // ukaże się informacja o spalonych kcal i zapyta czy chcemy zapisać wynik
var statistics = trainee.GetStatistics();
Console.WriteLine($"{statistics.MaxValue:N2}");
Console.WriteLine($"{statistics.MinValue:N2}");
Console.WriteLine($"{statistics.Average:N2}");