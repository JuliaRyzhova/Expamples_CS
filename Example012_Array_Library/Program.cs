
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

int [] array = new int [10]; // new int [10] - оператор создающий новый массив из 10 эл-ов

FillArray(array); // метод, заполняющий массив
PrintArray(array); //метод, выводящий массив на печать


