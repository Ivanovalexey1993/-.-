//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22




Console.WriteLine("Введите 3 числа в столбик:");
int num_A = Convert.ToInt32((Console.ReadLine()));
int num_B = Convert.ToInt32((Console.ReadLine()));
int num_C = Convert.ToInt32((Console.ReadLine()));
int max = num_A;
if (num_B > max)
{
    max = num_B;
}
if (num_C > max)
{
    max = num_C;
}
Console.WriteLine(" Наибольшее из введенных чисел ->" + max);