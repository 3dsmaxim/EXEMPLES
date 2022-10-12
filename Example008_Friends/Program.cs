int count =0;
int time = 0;

int distance = 10000;

int FirstFriandSpeed = 1;

int SecondFriandSpeed = 2;

int DogSpeed = 5;

int Friand = 2;


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