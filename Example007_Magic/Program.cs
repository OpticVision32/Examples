Console.Clear();
// Выставили курсор по координатам отступов количество символов слева (10), количество строк (4) строки считаются от нулевой.
// Console.SetCursorPosition(10, 4);
// Символ который будет показан по координатам выставленным в предыдущей строке
// Console.WriteLine("*");


// Создаём три точки
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

//Задаем две точки

int x = xa, y = xb;

//Задаем count для выхода из цикла

int count = 0;

while (count < 10000)
{
    // Генерируем сдучайное число для того чтобы выбиралась случайная точка
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1; // Вместо count + 1
}
