// Console.Write("Введите первое число: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// if (numb1==numb2*numb2)
// {
//     Console.WriteLine("Yes!!!");
// }
// else if (numb2==numb1*numb1)
// {
//     Console.WriteLine("Yes!!!");
// }
// else Console.WriteLine("Noooo");
// Задача 2 определение четверти по заданным координатам

// Console.Write("Введите координату Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x==0) { Console.WriteLine("х не должен ровняться нулю");}
// if (y==0) {Console.WriteLine("y не должен ровняться нулю");}
// if (x>0 && y>0) {Console.WriteLine("Ваши координаты ы четверти: I");}
// if (x<0 && y>0) {Console.WriteLine("Ваши координаты ы четверти: II");}
// if (x<0 && y<0) {Console.WriteLine("Ваши координаты ы четверти: III");}
// if (x>0 && y<0) {Console.WriteLine("Ваши координаты ы четверти: IV");}


// Console.Write("Введите большое число: ");
// int count = Convert.ToInt32(Console.ReadLine());
// while (count>999)
// {
//     count/= 10;
// }
// if (count < 100) {Console.WriteLine("Введите число побольше");}
// else 
// {    
//     count = count % 10;
//     Console.WriteLine($"третье число сначала: {count}");
// }

Console.Write("Введите большое число: ");
int count = Convert.ToInt32(Console.ReadLine());
int n=0; // Счетчик для цикла
int dooble = count; // Дублируем заданное число, чтобы не потерять
while (dooble > 9) // 125, 12, 1
{
    dooble/=10;
    n++;            // 1  2   
}
while (n>=0)
{
    int del = Convert.ToInt32(Math.Pow(10,n));// Добавили еще одну переменную, 
                                              //так как степень требует другую систему чисел
    int numb=count/del;     // 125/100 = 1  25/10 = 2   5
    count = count % del;          // 125 100 = 25   5   0 
    Console.Write($"{numb},");         
    n=n-1;                           
}