Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Уа, это же МАША!");
}
else
{
    Console.Write("Нахер иди, ");
    Console.Write(username);
    Console.WriteLine(", где МАША!!!");
}