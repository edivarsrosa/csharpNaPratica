using System;

namespace csharpNaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça mais com as cadeias de caractere
18 minutos restantes
Você está usando um método, Console.WriteLine , para imprimir mensagens. Um método é um bloco de código que implementa alguma ação. Ele tem um nome, portanto você pode acessá-lo.

Suponha que suas cadeias de caracteres têm espaços à esquerda ou à direita que você não deseja exibir. Você deseja cortar os espaços das cadeias de caracteres. O método Trim e os métodos relacionados TrimStart e TrimEnd fazem isso funcionar. Você pode apenas usar esses métodos para remover espaços à esquerda e à direita. Experimente o código a seguir:
            */
            string firstFriend = "Maria";
            string secondFriend="Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters. ");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters ");

            //observe agora abaixo o uso de MÉTODOS
            /*
            Os colchetes [ e ] ajudar a visualizar o que o Trim e os TrimStart TrimEnd métodos fazem. Os colchetes mostram onde o espaço em branco começa e termina.

Este exemplo reforça alguns conceitos importantes do trabalho com cadeias de caracteres. Os métodos que manipulam cadeias de caracteres retornam novos objetos de cadeia de caracteres, em vez de fazer modificações no local. Veja que cada chamada para qualquer um dos métodos Trim retorna uma nova cadeia de caracteres, mas não altera a mensagem original.

Há outros métodos disponíveis para trabalhar com uma cadeia de caracteres. Por exemplo, você provavelmente já usou um comando de pesquisa e substituição em um editor ou processador de textos. O método Replace faz algo semelhante em uma cadeia de caracteres. Ele procura uma subcadeia de caracteres e a substitui por outro texto. O Replace método usa dois parâmetros. Essas são as cadeias de caracteres entre parênteses. A primeira cadeia de caracteres é o texto a ser pesquisado. A segunda cadeia de caracteres é o texto para substituição. Experimente. Adicione este código. Digite-o para ver as dicas conforme você começa a digitar .Re depois da variável sayHello:
            */

            string greeting="      Hello World!           ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting= greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting=greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting=greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Olá Ed!";
            Console.WriteLine(sayHello);
            sayHello=sayHello.Replace("Olá", "Até mais,");
            Console.WriteLine(sayHello);

        }
    }
}
