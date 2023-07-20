/* **Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] RandomArrDouble(int size, double min, double max)//Метод массива веществ чисел
{
  double[] array = new double[size];
  for (int i = 0; i < array.Length; i++)
  {
    min = double.Parse()
    array[i] = new Random().Next(min, max);
  }
  return array;
}

double[] SumPosNeg(double[] arr1)//Метод суммы положит и отриц значений чз нулевой массив 2х элемент
{
  doubie[] arr2 = new double[2];
  foreach (double element in arr1)//вместо int м.б. - string, double, int[] и т.д.;
  {
    double max = element;
    arr2[0] += element > 0 ? element : 0;//!!упращенная форма записи оператора - IfElse
    arr2[1] += element < 0 ? element : 0;
  }
  return arr2;
}



Console.Clear();
int siz = new Random().Next(4, 11);
int sizA = siz;
double minA = -9.5;
double maxA = 9.52;
double[] arrA = RandomArrDouble(sizA, minA, maxA);
Console.Write($"[{String.Join(", ", arrA)}] ->");

