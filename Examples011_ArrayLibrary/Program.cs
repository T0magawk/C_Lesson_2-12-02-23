void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); // кладем в индекс массива рандомное число из диапазона 1-10
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10]; // задаем новый массив из 10 элементов.Можно сделать пользовательский ввод длины массива

FillArray(array); // запускаем создание массива по ранее написанному алгоритму
PrintArray(array);// вывод массива в терминал
 
