// ЗАДАЧА №19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да 
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberMass = Convert.ToString(number);
if (numberMass.Length == 5)
{
    if (numberMass[0] == numberMass[4])
    {
        if (numberMass[1] == numberMass[3])
        {
            Console.WriteLine("Да");
        }
        else Console.WriteLine("Нет");
    }
    else Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число:");
}