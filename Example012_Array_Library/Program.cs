// Создаем метод заполняющий массив путем рандомного подбора чисел.
// Создаем метод выводящий созданный массив
// Находим индекс искомого числа
/*
void FillArray(int [] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int [] col)
{
    int count = col.Length; //обозначили кол-во эл-ов массива
    int position = 0; // тот же индекс, просто чтобы не повторятся обозначили как position
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искомого числа нет в массиве, то вернет значение индекса -1. Если оставить 0, то это неправильно.

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // new int [10] - оператор создающий новый массив из 10 эл-ов

FillArray(array); // метод, заполняющий массив
PrintArray(array); //метод, выводящий массив на печать

Console.WriteLine( );

int pos = IndexOf(array, 14); // вводим переменную, которая выводит результат метода IndexOf
Console.WriteLine(pos);
*/