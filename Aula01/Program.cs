// See https://aka.ms/new-console-template for more information
using Aula01._1bim;
using System.Runtime.InteropServices;

bool continuar = true;
while (continuar) {
    Console.WriteLine("//MENU//\n");
    Console.WriteLine("\nESCOLHA UMA OPÇÃO:\n");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar dois números");
    Console.WriteLine("2 - Converter metros(m) para milímetros(mm)");
    Console.WriteLine("3 - Calcular aumento de salário");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Saindo...");
            continuar = false;
            break;
        case 1:
            Console.WriteLine("Escreva dois números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            SomaDoisNumeros somador = new SomaDoisNumeros();
            int resultado = somador.Somar(num1, num2);
            Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");
            break;
        case 2:
            Console.WriteLine("Escreva o comprimento(m): ");
            int metros = int.Parse(Console.ReadLine());
            MetrosMilimetros converta = new MetrosMilimetros();
            int milimetros = converta.Converter(metros);
            Console.WriteLine($"{metros}m é igual a {milimetros}mm");
            break;
    }
}

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
