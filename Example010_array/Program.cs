//Функция нахождения максимального числа
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// Вместо назначения девяти переменных используем Массив (Array)
//               0   1   2   3   4   5   6   7   8      -  индекс массива
int[] array = { 13, 12, 34, 54, 25, 67, 27, 18, 92 };

// int a1 = 31;
// int b1 = 52;
// int c1 = 93;
// int a2 = 4;
// int b2 = 15;
// int c2 = 346;
// int a3 = 157;
// int b3 = 78;
// int c3 = 33;

// Применение функции
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);