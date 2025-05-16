// See https://aka.ms/new-console-template for more information
using Aula01._1bil;
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
    Console.WriteLine("4 - Calcular desconto de mercadoria");
    Console.WriteLine("5 - Calcular aluguel de carro");
    Console.WriteLine("6 - Tabuada de 1 a 10");
    Console.WriteLine("7 - Calcular imposto de renda");
    Console.WriteLine("8 - Calcular IMC");
    Console.WriteLine("9 - Números múltiplos de 3 entre 0 e 100");
    Console.WriteLine("10 - Adivinhe o número");
    Console.WriteLine("11 - Fatoriais de 1 a 10");

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
        case 3:
            Console.Write("Digite o valor atual do salário: R$ ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de aumento (%): ");
            double percentual = double.Parse(Console.ReadLine());

            CalculaAumento calcularamt = new CalculaAumento(salario, percentual);
            calcularamt.ExibirResultado();
            break;
        case 4:
            Console.Write("Digite o valor atual da mercadoria: R$ ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto (%): ");
            double percent = double.Parse(Console.ReadLine());

            CalculaDesconto calculardes = new CalculaDesconto(valor, percent);
            calculardes.ExibirResultado();
            break;
        case 5:
            Console.Write("Digite o total de dias alugados: ");
            int dias = int.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = double.Parse(Console.ReadLine());

            AluguelCarro calculacar = new AluguelCarro(dias, kmInicial, kmFinal);
            calculacar.ExibirResultado();
            break;
        case 6:
            Console.WriteLine("Tabuada Completa (1 a 10)");
            Console.WriteLine("------------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nTabuada do {i}:");
                Console.WriteLine("-------------");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} × {j} = {i * j}");
                }
            }
            break;
        case 7:
            Console.Write("Informe sua renda anual bruta: R$ ");
            double rendaAnual = double.Parse(Console.ReadLine());

            CalculadoraIRPF calculadora = new CalculadoraIRPF(rendaAnual);
            var (imposto, aliquota) = calculadora.CalcularImposto();

            Console.WriteLine("\nResultado:");
            Console.WriteLine($"Renda anual: R$ {rendaAnual:F2}");
            Console.WriteLine($"Imposto devido: R$ {imposto:F2}");
            Console.WriteLine($"Alíquota efetiva: {aliquota:F2}%");
            break;
        case 8:
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu gênero (M/F): ");
            char genero = char.Parse(Console.ReadLine().ToUpper());

            Pessoa pessoa = new Pessoa(peso, altura, genero);
            double imc = pessoa.CalcularIMC();
            string classificacao = pessoa.ClassificarIMC();

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Classificação: {classificacao}");
            break;
        case 9:
            multiplosde3 calcularM3 = new multiplosde3();
            List<int> resultados = calcularM3.multiplo(100);

            Console.WriteLine("Múltiplos de 3 entre 0 e 100:");
            Console.WriteLine("esses são os multiplos de 3 até 100");
            foreach (int num in resultados)
            {
                Console.WriteLine(num);
            }
            break;
        case 10:
            Random random = new Random();
            int numeroSecreto = random.Next(0, 101); // Gera número entre 0 e 100
            int tentativasRestantes = 10;
            bool acertou = false;

            Console.WriteLine("=== Jogo de Adivinhação ===");
            Console.WriteLine("Tente adivinhar o número secreto entre 0 e 100!");
            Console.WriteLine($"Você tem {tentativasRestantes} tentativas.\n");

            while (tentativasRestantes > 0 && !acertou)
            {
                Console.Write($"Tentativa {11 - tentativasRestantes}/10 - Digite seu palpite: ");

                if (int.TryParse(Console.ReadLine(), out int palpite))
                {
                    if (palpite < 0 || palpite > 100)
                    {
                        Console.WriteLine("Por favor, digite um número entre 0 e 100.\n");
                        continue;
                    }

                    if (palpite == numeroSecreto)
                    {
                        acertou = true;
                    }
                    else
                    {
                        tentativasRestantes--;
                        string dica = palpite < numeroSecreto ? "MAIOR" : "MENOR";
                        Console.WriteLine($"Errou! O número secreto é {dica} que {palpite}");
                        Console.WriteLine($"Tentativas restantes: {tentativasRestantes}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite apenas números inteiros.\n");
                }
            }

            if (acertou)
            {
                Console.WriteLine("\nPARABÉNS! Você acertou o número secreto!");
                Console.WriteLine($"O número era realmente {numeroSecreto}!");
                Console.WriteLine($"Você usou {10 - tentativasRestantes} tentativas.");
            }
            else
            {
                Console.WriteLine("\nSuas tentativas acabaram! Você perdeu.");
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
            }
            break;
        case 11:
            void fatorial()
            {
                {
                    fatoriais fator = new fatoriais();
                    Console.WriteLine("Fatoriais de 1 até 10:");

                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = fator.CalcularFatorial(i);
                        Console.WriteLine($"{i}! = {resultado}");
                    }
                }
            }
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
