// N
// N...0

void PrintNumbers(int start, int end)
{
    if(start > end)
        return;
    
    Console.Write($"{start} ");
    PrintNumbers(start + 1, end);
}

void PrintNumbers1 (int n)
{
    if(n == 0)
        return;
    
    Console.Write($"{n} ");
    PrintNumbers1(n - 1);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(1, 5);
PrintNumbers1(number);

