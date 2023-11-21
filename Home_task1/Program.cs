// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Большее из двух чисел

// Console.Write("firstNumber: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("secondNumber: ");
// int second = Convert.ToInt32(Console.ReadLine());
// if (first == second)
// {
//     Console.WriteLine("Ваши числа равны");
// } 
// if (first>second)
// {
//     Console.WriteLine($"Первое число: {first}, больше чем второе число: {second}");
// }
// if (first<second)
// {
//     Console.WriteLine($"Первое число: {first}, меньше чем второе число: {second}");
//Большее из трех чисел.

// Console.Write("firstNumber: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("secondNumber: ");
// int second = Convert.ToInt32(Console.ReadLine());
// Console.Write("thirdNumber: ");
// int third = Convert.ToInt32(Console.ReadLine());
// int max = first;
// if (max < second)
// {
//     max = second;
// } 
// if (max < third)
// {
//     max = third;
// }
//     Console.WriteLine($"Максимальное число: {max}");

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb % 2 == 0)
{
    Console.WriteLine($"Введеное вами число: {numb} - четное");
}
else Console.WriteLine ($"Введеное вами число: {numb} - нечетное");