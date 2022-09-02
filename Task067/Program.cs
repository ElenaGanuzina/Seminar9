// вход - число, выход - сумма цифр числа.

int SumNumbers(int number)
{
    if(number == 0) 
        return 0;
    
    
    return (number % 10) + SumNumbers(number / 10);
    
}

Console.WriteLine(SumNumbers(753));