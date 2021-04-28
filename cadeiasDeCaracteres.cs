namespace csharpNaPratica
{
    public class cadeiasDeCaracteres
    {
        /*Trabalhar com cadeias de caracteres
23 minutos restantes
Sua última edição foi nossa primeira análise do que você pode fazer com cadeias de caracteres. Vamos explorar mais.

Você não está limitado a uma única variável entre as chaves. Tente o seguinte:

C#

Copiar*/
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Conforme explorar mais as cadeias de caracteres, você descobrirá que cadeias de caracteres são mais do que uma coleção de letras. Você pode encontrar o tamanho de uma cadeia de caracteres usando Length. Length é uma propriedade de uma cadeia de caracteres e retorna o número de caracteres na cadeia. Adicione o seguinte código na parte inferior da janela interativa:

C#

Copiar
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
 Dica

Este é um bom momento para explorar por conta própria. Você aprendeu que Console.WriteLine() escreve um texto na tela. Você aprendeu como declarar variáveis e concatenar cadeias de caracteres. Experimente com a janela interativa. A janela tem um recurso chamado IntelliSense, que faz sugestões sobre o que você pode fazer. Digite um . depois do d em firstFriend. Você verá uma lista de sugestões para propriedades e métodos que você pode usar.
    }
}