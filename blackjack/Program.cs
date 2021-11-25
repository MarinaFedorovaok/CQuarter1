﻿// Игра "Blackjack"
// Описание правил игры можно почитать на вот тут

// Значения очков каждой карты: от двойки до десятки — от 2 до 10 соответственно, 
//у туза — 1 или 11 (11 пока общая сумма не больше 21, далее 1), 
// у т. н. картинок (король, дама, валет) — 10.

// Идея решения
// В игре участвуют несколько игроков, для простоты можно взять двух игроков. 
// Каждый игрок по очереди отвечат на вопрос - "нужна ли Вам еще одна карта?".
//  Если ответ утвердительный, то игроку выдается следующая карта из колоды. 
//  Если игрок ответил отрицательно, то у этого игрока больше не спрашиваем. 
//  Когда все игроки отказались от новых карт, то начинается подсчет очков.
//   В результате определяется победитель.

// Для начала надо определиться как мы будем работать с картами. Напомню, в задаче нельзя пользоваться ничем кроме массивов.
//  Также важно понять как производить итоговый подсчет очков у каждого игрока, 
//  то есть надо как-то узнать сколько очков дают за карты, которые находятся на руках у каждого из игроков.

// Сама игра проходит так:

// Создаем колоду карт.
int [] CreateCards(int n)// -метод создает колоду карт в зависмости от количества карт в колоде. 
 //        Итог работы метода - массив
// Значения очков каждой карты: от двойки до десятки — от 2 до 10 соответственно, 
//у туза — 1 или 11 (11 пока общая сумма не больше 21, далее 1), 
// у т. н. картинок (король, дама, валет) — 10.

// Для игры нам необходима перемешанная колода, поэтому надо в случайном порядке перетасовать карты (или сделать какой-то механизм, чтобы менять порядок карт)
int Turn (int playerNum) // принимает номер игрока, делает ход. Выясняет, хочет ли игрок делать ход
// присваивает значение переменным bool wantsCards0 = true;
// bool wantsCards1 = true;
// Возвращает количество очков игрока
// Фаза набора карт игроками. Каждый игрок берет по одной карте, до тех пока не скажет что ему больше карты не нужны. Карты выдаются по одной из перемешанной колоды.
// Фаза подсчета очков. Нам необходимо узнать сколько очков у каждого игрока.
// Определение победителя в этом раунде.

bool oneWantsCards (bool player1, bool player2) // метод определяет, надо ли делать следующий ход

int winner (int score1, int score2) //метод определяет победителя в раунде
// Можно продолжить играть и перейти к следующему раунду (шаг 3).
 //**************************************
 //Материалы для работы:
// Как задать динамический массив:

List<int> col= new();

// Чтобы добавить элемент пишем
col.Add(123);

//Чтобы удалить col.Remove(123);

//Узнать количество элементов : col.Count
int [] cards = CreateCards(36);
int score0 = 0;
int score1 = 0;
bool wantsCards0 = true;
bool wantsCards1 = true;
while oneWantsCards (wantsCards0, wantsCards1)
{
   score0 = Turn (0);
   score1 = Turn (1); 
}
winner (score0, score1);