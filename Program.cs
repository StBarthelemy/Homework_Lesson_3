// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine ("Введите пятизначное число");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers <= 99999)
{
String number = Convert.ToString(numbers);
int[] ResArr = new int[number.Length];
for (int i = 0; i < number.Length; i++)
{    
ResArr[i] = Convert.ToInt32 (number.Substring (i, 1));
}
if (number[0]==number[4] && number[1]==number[3])
{
    Console.WriteLine ($"Число, {number[0]}{number[1]}{number[2]}{number[3]}{number[4]}, является палиндромом");
}
else 
{
    Console.WriteLine ($"Число, {number[0]}{number[1]}{number[2]}{number[3]}{number[4]}, не является палиндромом");
}
}
else
Console.WriteLine ("Некоректное число, пожалуйста введите пятизначное число");
