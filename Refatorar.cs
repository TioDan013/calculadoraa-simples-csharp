using System;

class CalculadoraSimples
{
    static void Main(string[] args)
    {
        Console.Write("Digite o 1º valor: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Erro: Valor inválido para o primeiro número.");
            return;
        }

        Console.Write("Digite o 2º valor: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Erro: Valor inválido para o segundo número.");
            return;
        }

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("+ para adição");
        Console.WriteLine("- para subtração");
        Console.WriteLine("* para multiplicação");
        Console.WriteLine("/ para divisão");
        Console.Write("Operação: ");
        
        char operacao = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double resultado;
        bool operacaoValida = true;
        string nomeOperacao = "";

        switch (operacao)
        {
            case '+':
                nomeOperacao = "Adição";
                resultado = numero1 + numero2;
                break;
            case '-':
                nomeOperacao = "Subtração";
                resultado = numero1 - numero2;
                break;
            case '*':
                nomeOperacao = "Multiplicação";
                resultado = numero1 * numero2;
                break;
            case '/':
                nomeOperacao = "Divisão";
                if (numero2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                    return;
                }
                resultado = numero1 / numero2;
                break;
            default:
                operacaoValida = false;
                resultado = 0;
                break;
        }

        if (operacaoValida)
        {
            Console.WriteLine($"{nomeOperacao}: {numero1} {operacao} {numero2} = {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Operação inválida.");
        }
    }
}
