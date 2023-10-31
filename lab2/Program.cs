Console.WriteLine("Введите f, n");
double f = Convert.ToDouble(Console.ReadLine());
double n = Convert.ToDouble(Console.ReadLine());
if (f != n)
{
    if (f > n)
    {
        n = f;
    }
    else
    {
        f = n;
    }
}
else
{
    f = 0;
    n = 0;
}
Console.WriteLine($"{f}, {n}");
