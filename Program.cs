// Проверяем теорию вероятности на ФонБет)))
Console.Write("Введите количество повторений: ");
int n = Convert.ToInt32(Console.ReadLine()); // Вводим колличество игр
int countLos = 0;       // Колличество игр, где мы все потеряли
int countWin = 0;       // Колличество игр, где мы удвоили начальную сумму
int SumWin = 0;         // Итоговый балланс за введенное кол-во игр
for (int j = 1; j <= n; j++) 
{
    int iMax = 0;       // Номер хода при достижении максимальной суммы
    int MaxCash = 0;    // Максимально достигнутая сумма
    int Cash = 5000;    // Имеющаяся сумма на игру
    int Stavka = 100;
    for (int i = 1; i <= 20; i++) // Цикл игры из 20 ходов
    {
        if (MaxCash < Cash)       // Определяем наибольший выйгрыш в ходе цикла и номер хода
        {
            MaxCash = Cash;
            iMax = i;
        }
        if (Cash <= 0)            // Условие поражения
        {
            Console.WriteLine($"{j}. <<<<<<<<<<<<[you loos on: {i} step]>>>>>>>>>>>>>>>");
            countLos++;
            break;
        }
        if (Cash > 10000)         // Условия победы, удваивание начальной суммы
        {
            Console.WriteLine($"{j}. !!!!!!!!!!!!!!!!!!!!![you WIN on: {i} step]!!!!!!!!!!!!!!!!!!!!!!!!");
            countWin++;
            break;
        }
        if (Cash < Stavka) Stavka = Cash;  // Если ставка привышает бюджет
        int Total = new Random().Next(1, 7) + new Random().Next(1, 7); //Вычисления суммы броска двух костей
        Cash = Cash - Stavka;
        if (Total > 5 && Total < 9) Stavka = Stavka * 2; // Сумма в пределах [5,5..8,5] - поражение
        else                                     // "Иначе" Выйгрыш
        {
            Cash = Cash + Stavka * 17 / 10;
            Stavka = 100;
        }
    }
SumWin = SumWin + Cash - 5000;          // Определяем общий выйгрыш по итогам всех игр
Console.WriteLine($"{j}. Max cash was on '{iMax}' step and was: '{MaxCash}'.");
if (Cash > 0)
    Console.WriteLine($"{j}. Finished cash: {Cash}.");
}
Console.WriteLine($"Finish result: !!{SumWin}!! You loos {countLos} times out of {n}. And WIN {countWin}.");