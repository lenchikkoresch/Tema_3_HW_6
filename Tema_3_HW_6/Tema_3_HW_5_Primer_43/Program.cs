/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetRatio(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно");
        }
    }
    return result;
}


double k1 = GetRatio("Введите коэффициент k1");
double b1 = GetRatio("Введите коэффициент b1");
double k2 = GetRatio("Введите коэффициент k2");
double b2 = GetRatio("Введите коэффициент b2");

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine($"Прямые y = {k1} * x + {b1}, y = {k2} * x + {b2} совпадают");
    
}
if ((k1 == k2) && (b1 != b2))
{
    Console.WriteLine($"Прямые y = {k1} * x + {b1}, y = {k2} * x + {b2} параллельны");
    
}

if ((k1 != k2) && (b1 != b2))
{ 
    double x0 = ((b2 - b1)/(k1 - k2));
    double y0 = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    Console.WriteLine($"Прямые y = {k1} * x + {b1}, y = {k2} * x + {b2} пересекаются в точке ({x0:f2}; {y0:f2})");
}
