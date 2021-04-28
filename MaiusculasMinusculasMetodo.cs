using System;

namespace csharpNaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Outros dois métodos úteis colocam uma cadeia de caracteres TODA EM MAIÚSCULAS ou toda em minúsculas. Experimente o código a seguir. Digite-o para ver como o IntelliSense fornece dicas conforme você começa a digitar To:
            */
            string sayHello = "Olá Ed!";
            Console.WriteLine(sayHello);
            sayHello=sayHello.Replace("Olá", "Até mais,");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
        }
    }
}

/*SAÍDA:
Olá Ed!
Até mais, Ed!
ATÉ MAIS, ED!
até mais, ed!
*/