// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).

Console.Clear();

Console.WriteLine("Введите точку b1: ");
double dotB1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите точку k1: ");
double dotK1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите точку b2: ");
double dotB2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите точку k2: ");
double dotK2 = Convert.ToInt64(Console.ReadLine());

// Здесь могла бы быть функция, но я не понял как --------------------------------------

    double x = 0;
    double y = 0;
    x = (dotB2 - dotB1)/(dotK1 - dotK2);
    y = dotK1*(dotB2 - dotB1)/(dotK1 - dotK2)+dotB1;

    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine($"Точка пересечения двух прямых b1 = {dotB1}, k1 = {dotK1}, b2 = {dotB2}, k2 = {dotK2} -> ({x}; {y}).");





