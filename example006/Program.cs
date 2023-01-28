Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, Маруся");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}