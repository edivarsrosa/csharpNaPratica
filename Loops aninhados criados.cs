namespace csharpNaPratica
{
    public class Loops aninhados criados
    {
        /*for (int row=1; row<11; row++)
{
    Console.WriteLine($"The row is {row}");
}
*/

for (char column='a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}

for (int row=1; row<11;row++)
{
    for (char column = 'a'; column <'k'; column++)
    {
        Console.WriteLine($"A célula é ({row}, {column})");
    }
}
    }
}