// * GameInit() - метод, который задает все исходные значения в вашей игре.
// * MakeMove() - ходы, задаются этим методом.
// * RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
// * CheckNumber(int PlayesrNumber, int SecretNumber)
// * GameOver(bool winner) - 
// int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число.
// int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам.
// bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо false. true если пользователь угадал число и игру надо остановить, false, если пользователь не угадал.
int GameInit() //метод получает исходные данные и хранит секретное число
{
    int[] inputData = new int[2];
    Console.WriteLine("Привет! Введи интервал чисел и количество попыток, я загадаю число из этого интервала, а тебе нужно будет его угадать");
    Console.WriteLine("Введи начало интервала: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи конец интервала: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int res = new Random().Next(min, max);  //запоминает секретное число
    return res;
}
int AscMethod() //метод хранит число игрока
{
    Console.WriteLine("Bведи свое предположение: ");
    int PlayesrNumber = Convert.ToInt32(Console.ReadLine());
    return PlayesrNumber;
}
int MakeMove(int count) // метод делает ход и проверяет, хранит ответ/ исходные данные - количество попыток
{
    int SecretNumber = GameInit();
    while (count >= 0)
    {
        int PlayesrNumber = AscMethod();
        if (PlayesrNumber > SecretNumber)
        {
            Console.WriteLine("Загаданное число меньше введенного");
            count--;
        }
        else
        {
            if (PlayesrNumber < SecretNumber)
            {

                Console.WriteLine("Загаданное число больше введенного");
                count--;
            }
            else
            {
                Console.WriteLine("Победа!");
                return SecretNumber;
            }
        }
    }
    Console.WriteLine("В этот раз не получилось");
    return SecretNumber;
}

Console.WriteLine(MakeMove(3));

