/* **Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
*/

int[] RandomArr(int size, int min, int max)//Метод заполнения массива случ числами
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

int SumElement(int[] arrSum)//Метод расчета суммы значений эл-ов массива нечетных индексов 
{
  int sumInd = 0;
  for (int i = 1; i < arrSum.Length; i++)
  {
    sumInd += (i % 2) != 0 ? arrSum[i] : 0; 
  }
  return sumInd;
}

Console.Clear();
int siz = new Random().Next(4, 11);
int sizA = siz;
int minA = -10;
int maxA = 10;
int[] arrA = RandomArr(sizA, minA, maxA);
Console.Write($"[{String.Join(", ", arrA)}] -> {SumElement(arrA)}");

