// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество чисел: ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());
int[] arr = UserNumbersInput(amountNumbers);
Console.WriteLine($"Число элементов больше нуля -> {AboveZeroCount(arr)}");

int[] UserNumbersInput(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int AboveZeroCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}


