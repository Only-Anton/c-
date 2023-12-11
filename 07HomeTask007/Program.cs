//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.
//-------------------------------------------------------------------------
// string ShowMeNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return start + " " + ShowMeNumbers(start + 1, end);
// }
// Console.Write("Введите первое число: ");
// int firstNumb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumb = Convert.ToInt32(Console.ReadLine());
// int start = firstNumb;
// int end =  secondNumb;
// if (firstNumb > secondNumb)
// {
//     start = secondNumb;
//     end = firstNumb;
// }
// if ( start < 1 ) start = 1; // 

// Console.WriteLine($"Натуральные числа в диапазоне от {firstNumb} до {secondNumb} = {ShowMeNumbers(start, end)}");

//--------------------------------------------------------------------------
// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//--------------------------------------------------------------------------

// ulong UseAkkermansFunction(int N, ulong M)
// {
// //    if (N == 1) return M + 2 ; // думал сократит и ускорит, но увы нет((
//     if (N == 0) return M + 1 ;
//     else if (M == 0) return UseAkkermansFunction (N-1, 1); 
//     else return  UseAkkermansFunction(N - 1, UseAkkermansFunction(N, M-1));
// }
// Console.Write("Введите первое неотрицательное число: ");
// int firstNumb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе неотрицательное число: ");
// ulong secondNumb = ulong.Parse(Console.ReadLine()!);
// Console.WriteLine($"Функция Аккермана: {UseAkkermansFunction(firstNumb, secondNumb)}");

//--------------------------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
//--------------------------------------------------------------------------

string UnfoldArray(int[] arr, int length)
{
    if (length == 0) return arr[0].ToString();
    return arr[length] + " " + UnfoldArray(arr, length - 1);
}
void GiveMeArray(int[] array)    // Метод заполнения массива рандомом
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(0, 21); 
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray  = new int[length];
GiveMeArray(newArray);
Console.WriteLine($"То, что было:  [{string.Join( " ", newArray)}]");
Console.WriteLine($"То, что стало: [{UnfoldArray(newArray, length -1)}]");