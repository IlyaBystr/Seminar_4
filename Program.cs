
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуарльное число для степени");
int stepen = int.Parse(Console.ReadLine()!);
if (stepen >= 1)
{
    Console.WriteLine($"Число {A} в степени {stepen} = {GetPow(A,stepen)}");

    int GetPow(int a, int b)
    {
        int number = 1;
        for (int i = 1; i <= b; i++)
        {
            number = number * a;
        }
        return number;
    }
}
else
{
    Console.WriteLine("Вы ввели не прравильную степень");
}