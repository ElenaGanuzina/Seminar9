// A и B, A в степени B


int Exponentiation(int a, int b)
{
    if(b == 0) 
        return 1;
    
    return a * Exponentiation(a, b - 1);
}

Console.WriteLine(Exponentiation(3, 5));
Console.WriteLine(Exponentiation(2, 4));
Console.WriteLine(Exponentiation(10, 3));
Console.WriteLine(Exponentiation(5, 4));