using CertificationApp;

Console.WriteLine("Witamy w programie oceniającym Twój wysiłek fizyczny");
Console.WriteLine();
Console.Write("Ile ważysz w kg? ");
float weight = float.Parse(Console.ReadLine());
Console.Write("Ile masz lat? ");
int age = Convert.ToInt16 (Console.ReadLine());
Trainee trainee = new Trainee(weight, age);
//Console.WriteLine("Czy chcesz zapisać te dane na danym urządzeniu, aby nie wpisywać za każdym razem od nowa?");
//Console.WriteLine();
//Console.WriteLine("Wpisz yes jeśli chcesz zapisać albo wciśnij Enter, jeśli nie chcesz zapisywać danym");
//string savePerson = Console.ReadLine();
//if (savePerson == "yes")
//{
//    // zapisać
//}
//else
//{
//    // nie zapisać
//}
Console.WriteLine("Teraz podaj wyniki dzisiejszego treningu");
Console.WriteLine();
Console.Write("Jaki dystans pokonałeś w km: ");
float distance = float.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Ile czasu trwał trening w minutach: ");
int timeOfRide = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine();
Console.Write("Podaj średnie tętno: ");
Console.WriteLine();
int HRavg = Convert.ToInt16 (Console.ReadLine());
bool HRavgRangeOk = Calculations.HRavgRangeOk(trainee.HRMax, HRavg); // ukaże się info, czy HRavg w normie.
trainee.KcalBurnt(distance, timeOfRide, trainee.Weight); // ukaże się informacja o spalonych kcal.

//Console.WriteLine();
//Console.WriteLine("Czy chcesz zapisać te dane na danym urządzeniu, aby nie wpisywać za każdym razem od nowa?");
//Console.WriteLine();
//Console.WriteLine("Wpisz yes jeśli chcesz zapisać albo wciśnij Enter, jeśli nie chcesz zapisywać danym");
//string saveTraining = Console.ReadLine();
//if (saveTraining == "yes")
//{
//    // zapisać
//}
//else
//{
//    // nie zapisać
//}
