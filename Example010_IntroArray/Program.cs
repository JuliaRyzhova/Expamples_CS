// Использование массивов

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; //Примем, что максимум это arg1
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индексы эл-в 0  1   2   3   4   5    6    7   8
int[] array = {13, 2, 73, 543, 5, 665, 712, 88, 91};

// Как можно обратиться к элементу массиву и присвоить ему 
// новое значение
//array [0] = 12;
//Console.WriteLine(array[0]);

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
