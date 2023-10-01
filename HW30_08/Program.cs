// See https://aka.ms/new-console-template for more information
long inhabitantPiter = 5598486;
long inhabitantMosckow = 13015126;
long res = inhabitantMosckow - inhabitantPiter;
Console.WriteLine($"В москве больше жителей на {res}");

//Вторая задача.
decimal incomeYear = 260548.56895m;
decimal incomeMonth = incomeYear / 12;
decimal Ndfl = incomeMonth / 100 * 13;
decimal incomeMonthNdfl = incomeMonth - Ndfl;
Console.WriteLine($"Работник зарабатывает в месяц {incomeMonth:F5} а с НДФЛ {incomeMonthNdfl:F5}");
