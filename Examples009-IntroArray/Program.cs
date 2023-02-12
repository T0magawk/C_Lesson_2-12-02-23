// Создание функций на поиск максимального числа из 9 предложенных
// появление массивов
int Max(int arg1, int arg2, int arg3)//задаем аргументы для сравнения
{
    int result = arg1;
    if(arg1> result) result = arg2;
    if(arg3> result) result = arg3; // функция поиска максимума в тройке
    return result; // вовзращаем результат
}

int[] array = { 12, 32, 43, 24, 95, 62, 17, 58, 39 };  // задаем массив данных
// index        0   1   2   3   4   5   6   7   8 - индексы массива выше

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);

