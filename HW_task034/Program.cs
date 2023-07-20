/* **Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] RandomArr(int size, int min, int max)//Метод заполнения массива
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}
int NumberEven(int[] array)
{
  int count = 0;
  foreach (int el in array)
  {
    count += (el % 2) == 0 ? 1 : 0;
  }
  return count;
}

Console.Clear();
int siz = new Random().Next(4, 11);
int sizA = siz;
int minA = 100;
int maxA = 999;
int[] arrA = RandomArr(sizA, minA, maxA);
Console.Write($"[{String.Join(", ", arrA)}] -> {NumberEven(arrA)}");