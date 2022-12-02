int[] array = { 51, 22, 35, 4, 52, 4, 47, 4 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
    Console.WriteLine(index);
    break;
    }
    
    index++;
}


