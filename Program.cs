// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]) Console.WriteLine($"Ваше число: {number} - палиндром.");
  else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

Console.Clear();
Console.Write("Введите пятизначное число ");
string a_str = Console.ReadLine();
int length = a_str.Length;
Console.WriteLine();

if (length<5) Console.Write($"В числe {a_str} меньше пяти знаков");
else if (length>5) Console.Write($"В числe {a_str} больше пяти знаков");
else
{
      CheckingNumber(a_str);
}