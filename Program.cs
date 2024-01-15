//int Moscow = 13015126;
//int Piter = 5598486;
//int Difference=((Piter % 10000 / 1000) - (Moscow % 10000 / 1000));

//Console.WriteLine($"В Москве меньше жителей на {Difference} тысячи");

double Year = 260548.56895;
double Month = Year / 12;
double WithNds = (Year / 12) - (Year / 12) / 100 * 13;

Console.WriteLine($"Работник зарабатывает в месяц {Month:F2}");
Console.WriteLine($"Работник зарабатывает в месяц с вычетом НДФЛ {WithNds:F2}");