/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

// Преобразуем числа в массив
int [] GreatArray()
{
Console.WriteLine("Введите массив из M чисел, разделенных пробелами, запятыми или точками");
string text = Console.ReadLine()!;
char[] spearator = new char[] { ',','.',' '};
string[] splitArray = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
int count =  splitArray.Length;
int n = count;
int[] arr = new int[n];
int resultNumber = 0;

for (int i = 0; i < count; i++)
{
  if (int.TryParse(splitArray[i], out resultNumber))
  {
    arr[i] = resultNumber;
  }
  else
  {
    Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
      }
      }
      return arr;
}

      
// Печатаем массив
void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     Console.Write($"{arr[i]}, ");   
    }
}


int PositiveArr (int [] array)
{
    int k=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            k=k+1;
        }
    }

    return k;
}

int [] b = GreatArray();
PrintArray(b);
int posArr = PositiveArr (b);
Console.WriteLine($"Пользователь ввел {posArr} чисел больше нуля");
