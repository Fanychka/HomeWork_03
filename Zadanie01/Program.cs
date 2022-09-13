// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Придумайте 5-значное целое число и введите его: ");

int numberA = int.Parse(Console.ReadLine()!);


Console.WriteLine("По условию задачи мы определяем, является ли введенное число палиндромом");
Console.WriteLine($"Ты ввел число: {numberA}");

int numberB = 5; //int.Parse(Console.ReadLine()!);

int count1 = 1, count2 = 2, count3 = 3, count4 = 4, count5 = 5;



    int signNumber1 = numberB - count1;
    int signNumber2 = numberB - count2;
    int signNumber3 = numberB - count3;
    int signNumber4 = numberB - count4;
    int signNumber5 = numberB - count5;

    double stepen1 = Math.Pow(10, signNumber1);
    double stepen2 = Math.Pow(10, signNumber2);
    double stepen3 = Math.Pow(10, signNumber3);
    double stepen4 = Math.Pow(10, signNumber4);
    double stepen5 = Math.Pow(10, signNumber5);

    int x1 = Convert.ToInt32(stepen1);
    int x2 = Convert.ToInt32(stepen2);
    int x3 = Convert.ToInt32(stepen3);
    int x4 = Convert.ToInt32(stepen4);
    int x5 = Convert.ToInt32(stepen5);

    int result1 = numberA / x1 % 10;
    int result2 = numberA / x2 % 10;
    int result3 = numberA / x3 % 10;
    int result4 = numberA / x4 % 10;
    int result5 = numberA / x5 % 10;


if (result1 == result5 && result2 == result4)
{
    
    Console.WriteLine("Поздравляю! Число которое ты ввел ЯВЛЯЕТСЯ ПАЛИНДРОМОМ!");
} 
else
{
    Console.WriteLine($"Увы, но {numberA} НЕ ПАЛИНДРОМОМ!");
}
