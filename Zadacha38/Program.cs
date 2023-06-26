/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i] + " ");
}

Console.WriteLine();

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным значением равна {max - min}");
