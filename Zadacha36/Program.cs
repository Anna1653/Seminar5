/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int a = 0;

for (int i = 0; i < array.Length; i++)
{
   if (i % 2 != 0) 
   {
    a = a + array[i];
   }
}
Console.Write($"Cумма элементов, стоящих на нечётных позициях массива составляет {a}");