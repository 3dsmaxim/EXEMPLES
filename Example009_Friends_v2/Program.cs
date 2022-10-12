int count =0;
int time = 0;


Console.WriteLine("**Задача** сколько раз собака сбегает от одног своего  друга ко второму другу, пока друзья Шарика идут на встречу.");
Console.Write("Ввдите дистанцию: ");
string distanceW = Console.ReadLine();


Console.Write("Скорость первого друга: ");
string FirstFriandSpeedW = Console.ReadLine();


Console.Write("Скорость второго друга: ");
string SecondFriandSpeedW = Console.ReadLine();


Console.Write("Скорость дружелюбного пса Шарика: ");
string DogSpeedW = Console.ReadLine();


Console.Write("Укажите цифрой, от кого из друзей начал бежать Шарик, цифра 1 - это первый друг, цифра 2 -второй дрруг пса: ");
string FriandW = Console.ReadLine();

int distance = Int32.Parse(distanceW);
int FirstFriandSpeed = Int32.Parse(FirstFriandSpeedW);
int SecondFriandSpeed = Int32.Parse(SecondFriandSpeedW);
int DogSpeed = Int32.Parse(DogSpeedW);
int Friand = Int32.Parse(FriandW);







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
    }
    distance = distance - (FirstFriandSpeed + SecondFriandSpeed) * time;
    count++;
}
Console.Write("Шарик сбегад туда сюда ");
Console.Write(count);
Console.WriteLine(" раз.");