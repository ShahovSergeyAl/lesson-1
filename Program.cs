Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "сергей")
{
    Console.WriteLine("Привет, красавчик");
}
else
{
    Console.Write("Че надо, ");
    Console.WriteLine(username);
}