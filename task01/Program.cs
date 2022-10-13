Console.WriteLine("Введите целое число А");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите целое число Б");
int num2 = Convert.ToInt32(Console.ReadLine());
int num = num1 * num1;
if (num == num2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
