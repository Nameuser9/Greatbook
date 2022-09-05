Console.WriteLine("Введите 3 числа");
double a = Convert.ToDouble(Console.ReadLine()) , b = Convert.ToDouble(Console.ReadLine()) , c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (a > b) 
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.Write (max);
}
else
{
    max = c;
    Console.Write (max);
}
Console.Write (" - самое большое число");