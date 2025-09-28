Console.WriteLine("введите начальное значение");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите конечное число");
int b= Convert.ToInt32(Console.ReadLine());
int c = 0;
for (int i = 0; i < b; i++)
{
    if (i % 12 == 0)
    {
        c++;
    }
}
    Console.WriteLine(c);
