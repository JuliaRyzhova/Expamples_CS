Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "julia")
{
    Console.WriteLine("Привет, моя дорогая Julia");
}
else
{
    Console.Write("Ну привет, давно не виделись! ");
    Console.WriteLine(username);
}