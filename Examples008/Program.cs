// Создание функций на поиск максимального числа из 9 предложенных
// вводим функцию и аргументы
int Max(int arg1, int arg2, int arg3)//задаем аргументы для сравнения
{
    int result = arg1;
    if(arg1> result) result = arg2;
    if(arg3> result) result = arg3; // функция поиска максимума в тройке
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 134;
int b2 = 23;
int c2 = 354;
int a3 = 154;
int b3 = 220;
int c3 = 39;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)) - можно и так сделать
