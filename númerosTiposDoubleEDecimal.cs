namespace csharpNaPratica
{
    public class números
    {
        double a=19;
        double b=23;
        double c=8;
        double d=(a+b)/c;
        Console.WriteLine(d);

        double max=double.MaxValue;
        double min=double.MinValue;
        Console.WriteLine($"The range of double is {min} to {max}");

        double third=1.0/3.0;
        Console.WriteLine(third);

        decimal min=decimal.MinValue;
decimal max=decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a=1.0;
double b=3.0;
Console.WriteLine(a/b);

decimal c=1.0M;
decimal d=3.0M;
Console.WriteLine(c/d);

double raio=2.50;
double area=Math.PI*raio*raio;
Console.WriteLine($"A área de um Círculo com raio de 2.50cm é igual a {area}");

    }
}