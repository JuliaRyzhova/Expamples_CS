double Factorial(int number) // int не может хранить такие большие числа
// поэтому случается переполнение типа. Можно изменить тип на double
{
    if (number == 1) return 1;
    else return number* Factorial(number -1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Factorial {i} {Factorial(i)}");
}
