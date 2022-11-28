Console.Write("Введите число: ");
// Для того чтобы ввести в консоли в переменную целое число, конвертировали значение, т.к команда ReadLine позволяет вносить только string.
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write("Частное равно: ");
Console.Write(A / B);