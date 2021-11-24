// GameInit() - метод, который задает все исходные значения в вашей игре.
// * MakeMove() - ходы, задаются этим методом.
Console.WriteLine("Привет! Введи интервал чисел и количество попыток, я загадаю число из этого интервала, а тебе нужно будет его угадать");
Console.WriteLine("Введи начало интервала: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи конец интервала: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество попыток: ");
int countMax = Convert.ToInt32(Console.ReadLine());

int SecretNumber = new Random().Next(min, max);
int AscMethod()
{
    Console.WriteLine("Bведи свое предположение: ");
    int PlayesrNumber = Convert.ToInt32(Console.ReadLine());
    return PlayesrNumber;
}
Console.WriteLine(SecretNumber);
void MakeMove()
{
    while (countMax >= 0)
    {
        int PlayesrNumber = AscMethod();
        if (PlayesrNumber > SecretNumber)
        {
            Console.WriteLine("Загаданное число меньше введенного");
            countMax = countMax - 1;
        }
        else

        {
            if (PlayesrNumber < SecretNumber)
            {

                Console.WriteLine("Загаданное число больше введенного");
                countMax--;
            }
            else
            {
                Console.WriteLine("Победа!");
                return;
            }
        }
    }
    Console.WriteLine("В этот раз не получилось");
}
// void GameOver(int )
// {
//     if (AscMethod() == SecretNumber) Console.WriteLine("Победа!");
//     else
//     {
//         Console.WriteLine("В этот раз не получилось");
//     }
// }
MakeMove();
// * RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
// * CheckNumber(int PlayesrNumber, int SecretNumber)
// * GameOver(bool winner) - 