using CertificationApp;

Console.WriteLine("Hello! Welcome to the app assessing your physical activity!");
Console.WriteLine();

Console.Write("What's your weight in kilograms? ");
var weight = Console.ReadLine();
float weightConverted = 0;
try
{
    if (float.TryParse(weight, out float resultWeight))
    {
        weightConverted = resultWeight;
    }
    else
    {
        throw new Exception("Invalid weight value. Use only digits. Use ',' when inputting partial value.");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    do
    {
        Console.Write("What's your weight in kilograms? ");
        weight = Console.ReadLine();
        try
        {
            if (float.TryParse(weight, out float resultWeight1))
            {
                weightConverted = resultWeight1;
            }
            else
            {
                throw new Exception("Invalid weight value. Use only digits. Use ',' when inputting partial value.");
            }
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!float.TryParse(weight, out float resultWeight));
}

Console.Write("What's your age in years? ");
var age = Console.ReadLine();
int ageConverted = 0;
try
{
    if (int.TryParse(age, out int resultAge))
    {
        ageConverted = resultAge;
    }
    else
    {
        throw new Exception("Invalid age value. Use only integers. Partial values are not allowed.");
    }
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
            if (int.TryParse(age, out int resultAge1))
            {
                ageConverted = resultAge1;
            }
            else
            {
                throw new Exception("Invalid age value. Use only integers. Partial values are not allowed.");
            }
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(age, out int resultAge));
}

Console.WriteLine("Now provide the details of your training:");
Console.WriteLine();
Console.Write("Distance you've ridden: ");
var distance = Console.ReadLine();
float distanceConverted = 0;
try
{
    if (float.TryParse(distance, out float resultDistance))
    {
        distanceConverted = resultDistance;
    }
    else
    {
        throw new Exception("Invalid distance value. Use only digits. Use ',' when inputting partial value.");
    }
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
            if (float.TryParse(distance, out float resultDistance1))
            {
                distanceConverted = resultDistance1;
            }
            else
            {
                throw new Exception("Invalid distance value. Use only digits. Use ',' when inputting partial value.");
            }
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!float.TryParse(distance, out float resultDistance));
}
Console.WriteLine();
Console.Write("How many minutes did it last: ");
var timeOfRide = Console.ReadLine();
int timeOfRideConverted = 0;
try
{
    if (int.TryParse(timeOfRide, out int resultTimeOfRide))
    {
        timeOfRideConverted = resultTimeOfRide;
    }
    else
    {
        throw new Exception("Invalid Time of Ride value. Use only integers. Partial values are not allowed.");
    }
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
            if (int.TryParse(timeOfRide, out int resultTimeOfRide1))
            {
                timeOfRideConverted = resultTimeOfRide1;
            }
            else
            {
                throw new Exception("Invalid Time of Ride value. Use only integers. Partial values are not allowed.");
            }
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(timeOfRide, out int resultTimeOfRide));
}
Console.WriteLine();
Console.Write("Your average heart rate: ");
var HRavg = Console.ReadLine();
int HRavgConverted = 0;
try
{
    if (int.TryParse(HRavg, out int resultHRavg))
    {
        HRavgConverted = resultHRavg;
    }
    else
    {
        throw new Exception("Invalid HR-average value. Use only integers. Partial values are not allowed.");
    }
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
            if (int.TryParse(HRavg, out int resultHRavg1))
            {
                HRavgConverted = resultHRavg1;
            }
            else
            {
                throw new Exception("Invalid HR-average value. Use only integers. Partial values are not allowed.");
            }
        }
        catch (Exception ex1)
        {
            Console.WriteLine(ex.Message);
        }
    }
    while (!int.TryParse(HRavg, out int resultHRavg));
}
Trainee trainee = new Trainee(weightConverted, ageConverted, timeOfRideConverted, distanceConverted);

bool CheckAverageHR = Calculations.CheckAverageHR(trainee.HRMax, HRavgConverted); // ukaże się info, czy HRavg w normie.
trainee.CountKcalBurnt(trainee.Distance, trainee.TimeOfRide, trainee.Weight); // ukaże się informacja o spalonych kcal i zapyta czy chcemy zapisać wynik
var statistics = trainee.GetStatistics();
Console.WriteLine($"{statistics.MaxValue:N2}");
Console.WriteLine($"{statistics.MinValue:N2}");
Console.WriteLine($"{statistics.Average:N2}");