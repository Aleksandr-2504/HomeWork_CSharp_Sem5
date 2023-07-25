/* **Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

// 1 вариант решения(мой):

double[] RandomArrDouble(int size, double min, double max)//Метод массива веществ чисел случ
{
  double[] array = new double[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = min + (new Random().NextDouble()) * max;
  }
  return array;
} 

double[] ArrDouble(string stringArray) //метод преобразования строки в массив веществен чисел
{
  string[] nums = stringArray.Split(" ");
  double[] resdouble = new double[nums.Length];
  for (int i = 0; i < nums.Length; i++)
  {
    //resdouble[i] = double.Parse(nums[i]);
    resdouble[i] = Convert.ToDouble(nums[i]);
  }
  return resdouble;
}

double[] MaxMinDiff(double[] arr1)//Метод суммы положит и отриц значений чз нулевой массив 
//3х элементов, где первый - max, второй - min, третий - разница му max и min .
{
  double[] arr2 = new double[3];
  double max = arr2[0];
  double min = arr2[1];
  foreach (double element in arr1)//вместо int м.б. - string, double, int[] и т.д.;
  {
    arr2[0] = element >= max ? element : max;//!!упращенная форма записи оператора - IfElse
    arr2[1] = element < min ? element : min;
  }
  arr2[2] = (arr2[0] - arr2[1]);
  return arr2;
}


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
double[] arr3 = ArrDouble(elements);

//double[] arr4 = MaxMinDiff(arr3);
Console.Write($"[{String.Join(", ", arr3)}]");
//Console.Write($"[{String.Join(", ", RandomArrDouble(sizeA, minA, maxA))}] => "+
//$"{arr4[0]} - {arr4[1]} = {(arr4[0] - arr4[1])}");


// ***************************
/* 2 вариант решения:
Console.Clear();

double[] ArrDouble(int sizeArray)
{
  double[] resdouble = new double[sizeArray];
  Console.WriteLine("Введите элементы массива : ");
  for (int i = 0; i < resdouble.Length; i++)
  {
    resdouble[i] = Convert.ToDouble(Console.ReadLine());
  }
  return resdouble;
}

double MaxMinDiff(double[] array)//Метод суммы положит и отриц значений чз нулевой массив 2х элемент
{
  double max = array[0];
  double min = array[1];

  for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
  }

  return max - min;
}

Console.Write("Сколько элементов массива вы хотите ввести ? : ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] array = ArrDouble(sizeArray);

Console.WriteLine("Разница составляет : " + MaxMinDiff(array));
*/
//*************************** 

