// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n;
Console.WriteLine("ВВедите число N");
n = Convert.ToInt32(Console.ReadLine());
int index = 1;
int kub = 0;
while (index <= n)
{
    kub = index*index*index;
    Console.Write(kub + " ");
    index++;
}
