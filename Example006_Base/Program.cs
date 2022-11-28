int numberA = 4;
int numberB = 8;
int numberC = 15;
int numberD = 16;
int numberE = 23;
int numberF = 42;

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
if (numberD > max) max = numberD;
if (numberE > max) max = numberE;
if (numberF > max) max = numberF;

Console.WriteLine("Максимальное значение: ");
Console.WriteLine(max);
