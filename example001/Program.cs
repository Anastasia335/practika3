// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int a;
string aText;
 Console.WriteLine("Введите пятизначное число");
a = Convert.ToInt32(Console.ReadLine());
aText = Convert.ToString(a);
 if ((aText[0]== aText[4])&& (aText[1] == aText[3]))
 {
    Console.WriteLine("Введенное число является палиндромом");
 }
 else
 {
    Console.WriteLine("Введенное число не является палиндромом");
 }
