/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите 5  чисел через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // считываем строку с консоли и получаем из этой строки массив

int count = 0;
void NumbersGreaterThanZero(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
        {
            count++;
        }
    Console.Write($"Количество цифр больше нуля: {count}");
}
NumbersGreaterThanZero(arr);