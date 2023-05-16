Console.WriteLine("Cálculo Fatorial Resurso");
Console.WriteLine("************************");
Console.WriteLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fatorial de {numero} é {Factorial(numero)}");
Console.WriteLine($"Fibonacci de {numero} é {Fibonacci(numero)}");
Console.WriteLine($"Multiplicador de {numero} é {Multiplicafor(numero)}");

static int Factorial(int number)
{
    //Caso Base1
    if(number < 0)
    {
        throw new ArgumentException(
        message: $"A função fatorial não suporta números negativos. Input {number}",
        paramName: nameof(number)
        );
    }
    else if(number ==0) //Caso Base2
    {
    return 1;   
    }
    else //Caso Recursivo
    {
        return number * Factorial(number - 1);
    }
}


static long Fibonacci(int n)
{
      if( n <= 2L) //Caso Base
        return 1L;

    return Fibonacci(n - 1) + Fibonacci(n-2);
}

static void MultiplicarWrile(int n)
{
    int fator = 1;
    while(fator <= 10)
    {
        Console.WriteLine($"{n} x {fator} = {n * fator}");
        fator++;
    }
}

static void Multiplicafor(int n)
{
    for(int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

//net
int Recursivo(int n,int v)
{
    int v = 0;

    if(v==0)
        return 0;
    else if(n==0)
        return n;
    else
        return n + Recursivo(n,v);
}

int main()
{
    int n,v,res=0;
    scanf("%d%d",&n,&v);
    res = Recursivo(n,v);
    printf("Res = %d\n",res);

    return 0;
}