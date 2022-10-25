// Сортировка массива

int [] arr = {1, 5,  4, 3, 2, 6, 7, 1, 1};

void PrintArray (int [] array) // метод, выводящий массив на печать
{
    int count = array.Length;  // длина массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //не забываем пробел
    }
    Console.WriteLine();
}

void SelectionSort (int [] array) // Метод, сортирующий массив от мин к макс
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // примем, что мин(рабочий) это первый эл-т 
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i]; // временному эл-ту присваиваем значение первого эл-та
        array[i] = array[minPosition]; // в первый эл-т кладем найденный минимум
        array[minPosition] = temporary; // в осободишийся эл-т перемещаем тот, что у нас был певым (рабочим)
    }
}


SelectionSort(arr);
PrintArray(arr);