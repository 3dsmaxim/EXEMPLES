int count =0;
int time = 0;


Console.WriteLine("**Задача** сколько раз собака сбегает от одног своего  друга ко второму другу, пока друзья Шарика идут на встречу.");
Console.Write("Ввдите дистанцию: ");
string distance = Console.ReadLine();

Console.Write("Скорость первого друга: ");
string FirstFriandSpeed = Console.ReadLine();

Console.Write("Скорость второго друга: ");
string SecondFriandSpeed = Console.ReadLine();

Console.Write("Скорость дружелюбного пса Шарика: ");
string DogSpeed = Console.ReadLine();

Console.Write("Укажите цифрой, от кого из друзей начал бежать Шарик, цифра 1 - это первый друг, цифра 2 -второй дрруг пса: ");
string Friand = Console.ReadLine();


while (distance > 10)
{
    if (Friand == 1)
    {
        time = distance / (FirstFriandSpeed + DogSpeed);
        Friand = 2;
    }
    else 
    {
        time = distance / (SecondFriandSpeed + DogSpeed);
        Friand = 1;