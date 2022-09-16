// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Придумайте целое число и введите его: ");

int numA = int.Parse(Console.ReadLine()!);

if (numA == 0)
{
    Console.WriteLine($"Вы ввели число 0, попробуйте что-нибудь другое");

}
else if (numA > 0)
{

    Console.WriteLine($"По условию задачи мы должны разложить это число {numA} на составляющие и возвести в куб каждую составляющую");
    Console.WriteLine($"Количество составляющих у нас {numA} и их куб равен: ");

    for (int i = 1; i <= numA; i++)

    Console.WriteLine($"{Math.Pow(i, 3)}");

}


//int[] array = Convert.ToInt32(Math.Pow(i,3));

//double[] array = new double[Math.Pow(i,3)];

// Console.WriteLine($"{array[i]}");  