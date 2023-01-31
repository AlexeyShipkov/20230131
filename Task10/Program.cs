﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int Digits (int number) // метод вычичисления десятков трехзначного числа
{
    int dec = number/10%10;// вычисление десятков
    return dec;
}
Console.WriteLine("input 3 digits number: "); //ввод пользователя
int user_number = Convert.ToInt32(Console.ReadLine());
int result;
if (user_number >99 && user_number <1000)  //проверка, что число трехзначное
{
    result = Digits(user_number);
    Console.WriteLine($"The middle digit is {result}");  //вывод результата
}
else
Console.WriteLine("ERROR, entered not 3 digits number");  // вывод сообщания об ошибке, если чимсло не трехзачное