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


// Пытался автоматизировать процесс и сделать общий случай для , понимаю что это можно реализовать и 
// использование общей одной вычислительной функции напрашивается само собой, но увы, пока не хватило знаний ((
// Получилось немного цикл прикрутить, но дальше сложнее, логика подсказывает что нужно результат цикла как-то
// записать в массив через какие-то преобразователи и далее произвести сравнение элементов массива, примерно такое
// в лекции обьяснялось. В общем еще подумаю. Логику тут сохраню на обозрение, вдруг она правильная и пригодится.

/* 

Console.WriteLine("Придумайте n-значное целое число и введите его: ");
string input1 = Console.ReadLine();
int numberA = int.Parse(input1);

Console.WriteLine("Напишите количество знаков(цифр) из которого состоит это число: ");
string input2 = Console.ReadLine();
int numberB = int.Parse(input2);

int i = 1;

for (i =1; i <= numberB; i++)

if (numberB < 3)
{
    Console.WriteLine("Гав-Гав, нужно переделать, палиндром чувствует себя хорошо лишь в компании 3х и более цифр!");
}
else 
{
       
    int signNumber = numberB - i;

    double stepen = Math.Pow(10, signNumber);
    int x = Convert.ToInt32(stepen);

    int result = ((numberA / x) % 10);
    
    Console.Write(result);

    // Далее нужно получившиеся "отдельные" числа из result направить на сравнение, возможно через массив, но и 
    // математически наверное как-то можно (возможно так же через формулы остатка на деление и пр.)
    // 
   
}

*/