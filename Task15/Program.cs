/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void WeekDays (int weekday)  // метод определяет, является ли число днем недели
{
    if (weekday > 7 )    // проверка, что число может быть днем недели
    Console.WriteLine($"Введенное число {weekday} не является днем недели");
    else
    if (weekday == 6 || weekday == 7 )
    Console.WriteLine($"Введенное число {weekday} является выходным днем");
    else Console.WriteLine($"Введенное число {weekday} не является выходным днем");
}

Console.WriteLine("input number: "); //ввод пользователя
int user_day = Convert.ToInt32(Console.ReadLine());
WeekDays(user_day);