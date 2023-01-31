﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int DigitLength (int number) // метод вычисления третьей цифры
{
int digits = 0; // кол-во цифр в числе
int thirdNum = number;

while (number > 0)  // вычисление длины числа
{
  digits++;
  number = number/10;
}
    thirdNum = (thirdNum/Convert.ToInt32(Math.Pow(10,digits-3)))%10;// вычисление третьей цифры, 
    //сначала делим на 10 в степени количество цифр минус три, получаем число из первых трех цифр
    //затем получаем отстаток от деления на 10
return thirdNum;
}

Console.WriteLine("input number: "); //ввод пользователя
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(DigitLength(user_number));




