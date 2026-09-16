using System.Net;
using System.Globalization;
using System.Net.Http.Headers;
using System;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using System.Threading;
using System.Text;

class DesafiosModulo02
{
    public static void desafio036()
    {
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();
        Console.Write("Qual o valor do seu salário? R$: ");
        double salario = double.Parse(Console.ReadLine());
        Console.Write("Qual o valor da casa que você está procurando? ");
        double valorCasa = double.Parse(Console.ReadLine());
        Console.Write("Em quantas parcelas você deseja pagar esta casa? ");
        int parcelas = int.Parse(Console.ReadLine());
        double valorParcela = valorCasa / parcelas;
        Console.WriteLine($"Olá {nome} você deseja comprar uma casa de R$ {valorCasa:F2} em {parcelas} vezes");
        Console.WriteLine($"O total das parcelas seria de R$:{valorParcela:F2}");
        double valorPermitido = salario * 30 / 100;
        if(valorPermitido < valorParcela)
        {
            Console.WriteLine($"Seu salário é de R$: {salario:F2} e as parcelas é no valor de R$: {valorParcela:F2} não é possível o empréstimo");
        }
        else if(valorPermitido == valorParcela)
        {
            Console.WriteLine($"Seu salário é de R$: {salario:F2} e as parcelas é no valor de R$: {valorParcela:F2}  é possível o empréstimo");
        }
        else
        {
            Console.WriteLine($"Seu salário é de R$: {salario:F2} e as parcelas é no valor de R$: {valorParcela:F2}  é possível o empréstimo. PARABÉNS");
        }


    }
    public static void desafio037()
    {
        Console.Write("Digite um número inteiro qualquer: ");
        int numeroDigitado = int.Parse(Console.ReadLine());
        Console.Write("MENU DE OPÇÕES:\n\t[ 1 ] Binário\n\t[ 2 ] Octal\n\t[ 3 ] Hexadecimal\n");
        int opcaoSelecionada = int.Parse(Console.ReadLine());
        if(opcaoSelecionada == 1)
        {
            string binario = Convert.ToString(numeroDigitado, 2);
            Console.WriteLine($"O valor digitado {numeroDigitado} em binário fica {binario}");
        }
         else if(opcaoSelecionada == 2)
        {
            string octal = Convert.ToString(numeroDigitado, 8);
            Console.WriteLine($"O valor digitado {numeroDigitado} em octal fica {octal}");
        }
         else if(opcaoSelecionada == 3)
        {
            string hexadecial = Convert.ToString(numeroDigitado, 16);
            Console.WriteLine($"O valor digitado {numeroDigitado} em hexadecimal fica {hexadecial}");
        }
        else
            {
                Console.WriteLine("Opção inválida! Escolha entre 1, 2 ou 3.");
            }
    }
    public static void desafio038()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());
        if(num1 > num2)
        {
            Console.WriteLine($"O maior número é o {num1} e o menor número é o {num2}");
        }
        else if(num2 > num1)
        {
            Console.WriteLine($"O maior número é o {num2} e o menor número é o {num1}");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }

    }
    public static void desafio039()
    {
        int anoAtual = DateTime.Now.Year;
        Console.Write("Qual seu nome? ");
        string nome = Console.ReadLine();
        Console.Write($"{nome} em que ano você nasceu? ");
        int anoNascimento = int.Parse(Console.ReadLine());
        int anoAlistamento = anoAtual - anoNascimento;
        if(anoAlistamento == 18)
        {
            Console.WriteLine($"Você tem {anoAlistamento} anos e nasceu em {anoNascimento} e neste ano completa 18 anos. Você deve se alistar");
        }
        else if(anoAlistamento < 18)
        {
            int anoParaAlistar = anoNascimento + 18;
            Console.WriteLine($"Você tem {anoAlistamento} anos ainda não completou 18 anos, não precisa se alistar ainda.");
            Console.WriteLine($"Em {anoParaAlistar} você deve se alistar");
        }
        else if(anoAlistamento > 18)
        {
            int anoParaAlistar = anoNascimento + 18;
            int atrasoAlistamento = DateTime.Now.Year - anoParaAlistar;
            Console.WriteLine($"Você tem {anoAlistamento} anos está atrasado, vá procurar o que se deve fazer.");
            Console.WriteLine($"O ano que você deveria ter se alistado seria {anoParaAlistar}, você está {atrasoAlistamento} anos atrasado.");
        }
    }
    public static void desafio040()
    {
       Console.Write("Digite a primeira nota do aluno: ");
        double nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Digite a segunda nota do aluno: ");
        double nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
        double media = (nota1 + nota2) / 2;
        if(media < 5)
        {
            Console.WriteLine($"A suas notas {nota1} + {nota2} teve a média de {media}. VOCÊ ESTÁ REPROVADO");
        }
        else if(media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine($"A suas notas {nota1} + {nota2} teve a média de {media}. VOCÊ ESTÁ EM RECUPERAÇÃO");
        }
        else
        {
            Console.WriteLine($"A suas notas {nota1} + {nota2} teve a média de {media}. VOCÊ ESTÁ APROVADO");
        }

    }
    public static void desafio041()
    {
        Console.Write("Em que ano o atleta nasceu? ");
        int anoNascimento = int.Parse(Console.ReadLine());
        int idade = DateTime.Now.Year - anoNascimento;
        if(idade <= 9)
        {
            Console.WriteLine($"Atleta com {idade} anos. ATLETA MIRIM");
        }
        else if(idade <= 14)
        {
             Console.WriteLine($"Atleta com {idade} anos. ATLETA INFANTIL");
        }
        else if(idade <= 19)
        {
             Console.WriteLine($"Atleta com {idade} anos. ATLETA JUNIOR");
        }
        else if(idade <= 20)
        {
             Console.WriteLine($"Atleta com {idade} anos. ATLETA SENIOR");
        }
        else if(idade > 20)
        {
             Console.WriteLine($"Atleta com {idade} anos. ATLETA MASTER");
        }
    }


public static void desafio042()
    {
        Console.Write("Primeiro segmento: ");
        double r1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo segmento: ");
        double r2 = double.Parse(Console.ReadLine());
        Console.Write("Terceiro segmento: ");
        double r3 = double.Parse(Console.ReadLine());
        // CORRETO: Todos os três lados precisam ser MENORES que a soma dos outros dois
        if (r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2)
        {
            Console.WriteLine("Os segmentos acima PODEM FORMAR UM TRIÂNGULO");
            if(r1 == r2 && r2 == r3 && r3 == r1)
            {
                Console.WriteLine("EQUILÁTERO");
            }
            else if(r1 != r2 && r2 != r3 && r1 != r3)
            {
                Console.WriteLine("ESCALENO");
            }
            else
            {
                Console.WriteLine("ISÓSCELES");
            }
        }
        else
        {
            Console.WriteLine("Os segmentos acima NÃO PODEM FORMAR UM TRIÂNGULO");
            
        }

    }
    public static void desafio043()
    {
        Console.Write("Qual o seu peso? (kg): ");
        double peso = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Qual a sua altura? (m): ");
        double altura = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
        double imc = peso / (altura * altura);
      if (imc < 18.5)
        {
            Console.WriteLine("Você está ABAIXO DO PESO ideal.");
        }
        else if (imc <= 24.9) // Não precisa testar se é >= 18.5, pois se passou do primeiro 'if', já é maior
        {
            Console.WriteLine("PARABÉNS, você está no PESO IDEAL!");
        }
        else if (imc <= 29.9)
        {
            Console.WriteLine("Você está em SOBREPESO.");
        }
        else if (imc <= 34.9)
        {
            Console.WriteLine("Cuidado! Você está em OBESIDADE GRAU I.");
        }
        else if (imc <= 39.9)
        {
            Console.WriteLine("Cuidado! Você está em OBESIDADE GRAU II (severa).");
        }
        else
        {
            Console.WriteLine("Atenção! Você está em OBESIDADE GRAU III (mórbida).");
        }
    }

    public static void desafio044()
    {
        Console.Write("Qual valor do item que você vai pagar? R$: ");
        double valorProduto = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
         Console.WriteLine("MENU DE OPÇÕES:\n\t[ 1 ] A vista/PIX\n\t[ 2 ] A Vista Crédito/Débito\n\t[ 3 ] Até 2 vezes no cartão\n\t[ 4 ] 3x ou mais no cartão");
         int opcaoSSelecionada = int.Parse(Console.ReadLine());
         if(opcaoSSelecionada == 1)
        {
            double valorPagar = valorProduto - (valorProduto * 10 / 100);
            Console.WriteLine($"Como você vai pagar a vista você tem 10% de desconto, o produto que custava R${valorProduto:F2} vai custar R$: {valorPagar:F2}");
        }
        else if(opcaoSSelecionada == 2)
        {
             double valorPagar = valorProduto - (valorProduto * 5 / 100);
            Console.WriteLine($"Como você vai pagar a vista no cartão de crédito ou débito você tem 5% de desconto, o produto que custava R${valorProduto:F2} vai custar R$: {valorPagar:F2}");
        }
        else if(opcaoSSelecionada == 3)
        {
             Console.WriteLine($"Como você vai pagar em 2x no cartão , o produto tem o seu valor original R${valorProduto:F2} ");
        }
         else if(opcaoSSelecionada == 4)
        {
             double valorPagar = valorProduto + (valorProduto * 20 / 100);
             Console.WriteLine("Em quantas vezes você quer parcelar? ");
             int parcelas = int.Parse(Console.ReadLine());
             if(parcelas <= 2)
            {
               Console.WriteLine("\n<<ERRO>> Para até 2x, escolha a Opção 3 no menu!");
            }
             double valorParcelas = valorPagar / parcelas;
            Console.WriteLine($"Como você vai pagar em 3x no cartão de crédito ou débito você tem 20% de juros, o produto que custava R${valorProduto:F2} vai custar R$: {valorPagar:F2}");
            Console.WriteLine($"Você vai parcelar em {parcelas} vezes, e cada parcela terá um valor de {valorParcelas:F2}");
        }

        else
        {
            Console.WriteLine("<<ERRO>>OPÇÃO INVÁLIDA.");
        }

    }

    public static void desafio045()
    {
        // Vetor (array) com as opções do jogo
        string[] itens = { "Pedra", "Papel", "Tesoura" };

        // Sorteio do computador (retorna 0, 1 ou 2)
        Random random = new Random();
        int computador = random.Next(0, 3); // O limite superior (3) é exclusivo

        Console.WriteLine("Suas opções:\n[ 1 ] PEDRA\n[ 2 ] PAPEL\n[ 3 ] TESOURA\n");
        Console.Write("Qual é a sua jogada? ");
        
        int jogador = int.Parse(Console.ReadLine()) - 1; // Subtrai 1 para alinhar com os índices (0, 1, 2)

        // Validação da jogada
        if (jogador < 0 || jogador > 2)
        {
            Console.WriteLine("JOGADA INVÁLIDA! Escolha entre 1, 2 ou 3.");
        }
        else
        {
            // Efeito de suspense (1000ms = 1 segundo)
            Console.WriteLine("JO");
            Thread.Sleep(500);
            Console.WriteLine("KEN");
            Thread.Sleep(500);
            Console.WriteLine("PO!!");
            
            Console.WriteLine("-=".PadRight(20, '='));
            Console.WriteLine($"Computador jogou: {itens[computador]}");
            Console.WriteLine($"Jogador jogou:    {itens[jogador]}");
            Console.WriteLine("-=".PadRight(20, '='));

            // Estrutura de decisão
            if (computador == 0) // Computador jogou PEDRA
            {
                if (jogador == 0) Console.WriteLine("EMPATE!");
                else if (jogador == 1) Console.WriteLine("JOGADOR VENCE!");
                else if (jogador == 2) Console.WriteLine("COMPUTADOR VENCE!");
            }
            else if (computador == 1) // Computador jogou PAPEL
            {
                if (jogador == 0) Console.WriteLine("COMPUTADOR VENCE!");
                else if (jogador == 1) Console.WriteLine("EMPATE!");
                else if (jogador == 2) Console.WriteLine("JOGADOR VENCE!");
            }
            else if (computador == 2) // Computador jogou TESOURA
            {
                if (jogador == 0) Console.WriteLine("JOGADOR VENCE!");
                else if (jogador == 1) Console.WriteLine("COMPUTADOR VENCE!");
                else if (jogador == 2) Console.WriteLine("EMPATE!");
            }
        }
    }
    public static void desafio046()
    {
        for(int c = 10; c > 0; c--)
        {
            Console.WriteLine(c);

            Thread.Sleep(1000);
        }

        for(int c = 0; c < 5; c++)
        {
           string emojis = string.Concat(Enumerable.Repeat("🎉🎉", 2));
        Console.WriteLine(emojis);

            Thread.Sleep(1000);
        }

        
    }

    public static void desafio047()
    {
        Console.WriteLine("Números Pares do 0 ao 50.");
        for(int c = 0; c <= 50; c++)
        {

            if(c % 2 == 0)
            {
                Console.WriteLine(c);
                Thread.Sleep(500);
            }
        }
    }

    public static void desafio048()
    {
        Console.WriteLine("Soma dos ímpares multiplos de 3 do 0 ao 500.");
        int soma = 0;
        for(int c = 0; c <= 500; c++)
        {
            if(c % 2 == 1 && c % 3 == 0)
            {           
            
                Console.WriteLine(c);
                soma += c;
                Thread.Sleep(500);
            }
           
        }
        Console.WriteLine($"A soma de todos os números ímpares Múltiplos por é de {soma}.");
    }

    public static void desafio049()
    {
        int numero;
        Console.WriteLine("Qual tabuada você quer analisar? ");
        int tabuada = int.Parse(Console.ReadLine());
        for(int c = 0; c <= 10; c++)
        {
            numero = tabuada * c;
            Console.WriteLine($"{tabuada} x {c} = {numero}");
        }
        Console.WriteLine("FIM");
    }

    public static void desafio050()
    {
        int soma = 0;
        int contPares = 0;
        for(int c = 0; c < 6; c++)
        {
        Console.Write($"Digite o {c + 1}° valor: ");
        int valor = int.Parse(Console.ReadLine());
        if(valor % 2 == 0)
            {
                contPares++;
                soma += valor;

            }
        }
        Console.WriteLine($"\nVocê digitou {contPares} números PARES e a soma deles foi {soma}.");
        
    }

    public static void desafio051()
    {
        Console.Write("Qual o primeiro termo? ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Qual a razão da P.A? ");
        int razao = int.Parse(Console.ReadLine());
   
        for (int c = 1; c <= 10; c++)
    {
        Console.WriteLine($"{c}º termo: {num}");
        num += razao; // Atualiza o valor para a próxima volta
    }
    }

    public static void desafio052()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        int totalDivisores = 0;

        for(int c = 1; c <= num; c++)
        {
            if(num % c == 0)
            {
                totalDivisores++;
            }
        }
        if(totalDivisores == 2)
        {
            Console.WriteLine($"O número {num} é PRIMO!");
        }
        else
        {
            Console.WriteLine($"O número {num} NÃO é primo (foi divisível {totalDivisores} vezes).");
        }
    }
    public static void desafio053()
    {
        Console.Write("Digite uma frase: ");
        string entrada = Console.ReadLine();

        string fraseLimpa = entrada.ToLower().Replace(" ", "");
        char[] arrayCaracteres = fraseLimpa.ToCharArray();
        Array.Reverse(arrayCaracteres);
        string fraseInvertida = new string(arrayCaracteres);
        Console.WriteLine($"\nO inverso de '{fraseLimpa}' é '{fraseInvertida}'.");
        if (fraseLimpa == fraseInvertida)
    {
        Console.WriteLine("Temos um PALÍNDROMO! 🎉");
    }
    else
    {
        Console.WriteLine("A frase digitada NÃO é um palíndromo.");
    }
    }

    public static void desafio054()
    {
        int maioridade = 0;
        int menoridade = 0;
        for(int c = 0; c < 7; c++)
        {
            Console.Write($"Digite a idade da {c+1}° pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            if(idade >= 21)
            {
                maioridade++;
            }
            else
            {
                menoridade++;
            }
        }
        Console.WriteLine($"O total de pessoas acima da maior idade de 21 anos é de {maioridade}");
        Console.WriteLine($"O total de pessoas abaixo da maior idade de 21 anos é de {menoridade}");

    }

    public static void desafio055()
    {
         double maiorpeso = 0;
        double menorpeso = 0;
        for(int c = 0; c < 5; c++)
        {
            Console.Write($"Digite o peso da {c+1}° pessoa: ");
            string entrada = Console.ReadLine().Replace('.', ',');
            double peso = double.Parse(entrada);
            if( c == 0)
            {
                maiorpeso = peso;
                menorpeso = peso;
            }
            else
            {
                if(peso > maiorpeso)
                {
                    maiorpeso = peso;
                }
                if(peso < menorpeso)
                {
                    menorpeso = peso;
                }
            }
        }
        Console.WriteLine($"O maior peso foi o  {maiorpeso}");
        Console.WriteLine($"O menor peso foi o  {menorpeso}");

    }

    public static void desafio056()
    {
        string nomeHomem = "";
         double maiorIdadeHomem = 0;
        double totalMulheres = 0;
        for(int c = 0; c < 5; c++)
        {
            Console.Write($"Digite o nome da {c+1}° pessoa: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite o sexo da {c+1}° pessoa: ");
            string sexo = Console.ReadLine().ToLower().Trim();
            Console.Write($"Digite a idade da {c+1}° pessoa: ");            
            double idade = double.Parse(Console.ReadLine());

           
            if(sexo == "m" || sexo == "masculino" )
            {
                 
                
                    if(idade > maiorIdadeHomem)
                    {
                        maiorIdadeHomem = idade;
                        nomeHomem = nome;
                    }
                
            }
            else if(sexo == "f" || sexo == "feminino")
            {
               if(idade < 20)
                {
                    totalMulheres++;
                }
            }
            
        }
        Console.WriteLine("\n================ RESULTADO ================");
        if (maiorIdadeHomem > 0)
    {
        Console.WriteLine($"O homem mais velho é {nomeHomem} com {maiorIdadeHomem} anos.");
    }
    else
    {
        Console.WriteLine("Nenhum homem foi cadastrado.");
    }

    Console.WriteLine($"Total de mulheres com menos de 20 anos: {totalMulheres}");

    }
    public static void desafio057()
    {
        Console.Write("Digite seu sexo [M/F]: ");
        string sexo = Console.ReadLine().ToLower().Trim();

        while (sexo != "m" && sexo != "f" && sexo != "masculino" && sexo != "feminino")
        {
            Console.Write("Entrada inválida! Por favor, digite M ou F: ");
            sexo = Console.ReadLine().ToLower().Trim();
        }

        Console.WriteLine($"\nSexo cadastrado com sucesso: {sexo.ToUpper()}");
    }

      public static void desafio058()
    {
        int palpite = 0;
        int tentativas = 0;
        Random gerador = new Random();
        int numeroPensado = gerador.Next(1,6);
        Console.WriteLine(numeroPensado);
        Console.Write("Pensei em um número de 1 a 5.");
        Console.WriteLine("Será que você consegue adivinhar?");
       
        while (palpite != numeroPensado)
        {
           Console.Write("Qual é o seu palpite? ");
           palpite = int.Parse(Console.ReadLine());
            if (palpite > 5 || palpite < 1)
            {
                 Console.WriteLine("<<NÚMERO INVÁLIDO>>! Digite número entre 1 e 5.");
            }
            else
            {
                
            
           tentativas++;
           if (palpite != numeroPensado)
            {
                Console.WriteLine("Errou! Tenta mais uma vez...");
            }
       
        
       
            }
        }
        Console.WriteLine($"\nPARABÉNS! Você acertou o número {numeroPensado} com {tentativas} tentativa(s)!");
    }

    public static void desafio059()
    {
        int res = 0;
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        while(res != 5)
        {
          
        Console.WriteLine("\n [ 1 ] SOMAR \n [ 2 ] MULTIPLICAR \n [ 3 ] MAIOR \n [ 4 ] NOVOS NÚMEROS \n [ 5 ] SAIR DO PROGRAMA");
         res = int.Parse(Console.ReadLine());
         if(res == 1)
            {
                int soma = valor1 + valor2;
                Console.WriteLine($"A soma entre {valor1} + {valor2} é igual a {soma}.");
            }
        if(res == 2)
            {
                int mult = valor1 * valor2;
                Console.WriteLine($"A multiplicação entre {valor1} * {valor2} é igual a {mult}.");
            }
        if(res == 3)
            {
                if(valor1 > valor2)
                {
                    Console.WriteLine($"O maior valor entre {valor1} e {valor2} é o -> {valor1}");
                }
                else
                {
                     Console.WriteLine($"O maior valor entre {valor1} e {valor2} é o -> {valor2}");
                }

                
            }
        if(res == 4)
            {
                Console.Write("Digite o primeiro valor: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                valor2 = int.Parse(Console.ReadLine());
            }
        
        if(res == 5)
            {
                Console.WriteLine("ADEUS! ATÉ A PRÓXIMA.");
            }
        }
    }

public static void desafio059b()
    {
        int res = 0;

    Console.Write("Digite o primeiro valor: ");
    int valor1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    int valor2 = int.Parse(Console.ReadLine());

    while (res != 5)
    {
        Console.WriteLine("\n [ 1 ] SOMAR \n [ 2 ] MULTIPLICAR \n [ 3 ] MAIOR \n [ 4 ] NOVOS NÚMEROS \n [ 5 ] SAIR DO PROGRAMA");
        Console.Write(">>>>> Qual é a sua opção? ");
        res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1:
                int soma = valor1 + valor2;
                Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a {soma}.");
                break;

            case 2:
                int mult = valor1 * valor2;
                Console.WriteLine($"A multiplicação entre {valor1} e {valor2} é igual a {mult}.");
                break;

            case 3:
                if (valor1 > valor2)
                {
                    Console.WriteLine($"O maior valor entre {valor1} e {valor2} é {valor1}.");
                }
                else if (valor2 > valor1)
                {
                    Console.WriteLine($"O maior valor entre {valor1} e {valor2} é {valor2}.");
                }
                else
                {
                    Console.WriteLine($"Ambos os valores são iguais ({valor1}).");
                }
                break;

            case 4:
                Console.WriteLine("Informe os novos números:");
                Console.Write("Digite o primeiro valor: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                valor2 = int.Parse(Console.ReadLine());
                break;

            case 5:
                Console.WriteLine("ADEUS! ATÉ A PRÓXIMA.");
                break;

            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;
        }
    }
    }
public static void desafio060()
    {
        Console.Write("Digite um número para realizarmos o seu fatorial: ");
        int numero = int.Parse(Console.ReadLine());
        int contador = numero;
        long fatorial = 1;
        Console.Write($"Calculando {numero}! = ");
        while(contador > 0)
        {
            Console.Write($"{contador}");
            Console.Write(contador > 1 ? " x " : " = ");
            fatorial = fatorial * contador;
            contador = contador - 1;
        }

        Console.WriteLine(fatorial);
    }
public static void desafio060b()
    {
         Console.Write("Digite um número para realizarmos o seu fatorial: ");
        int numero = int.Parse(Console.ReadLine());
        long fatorial = Enumerable.Range(1, numero).Aggregate(1L, (acc, x) => acc * x);
        Console.WriteLine(fatorial);
    }
 public static void desafio061()
    {
        Console.Write("Qual o primeiro termo? ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Qual a razão da P.A? ");
        int razao = int.Parse(Console.ReadLine());
        int c = 1;
       while (c <= 10)
    {
        Console.WriteLine($"{c}º termo: {num}");
        num += razao; // Atualiza o valor para a próxima volta
        c++;
    }
    }
 public static void desafio062()

    {

       Console.Write("Qual o primeiro termo? ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Qual a razão da P.A? ");
        int razao = int.Parse(Console.ReadLine());
        int c = 1;
        int total = 0;
        int mais = 10;
       while (mais != 0)
    {
        total += mais; // Atualiza o limite total de termos a serem mostrados

        while (c <= total)
        {
            Console.WriteLine($"{c}º termo: {num}");
            num += razao;
            c++;
        }

        Console.WriteLine("----------------------------------");
        Console.Write("Quantos termos a mais você quer mostrar? (0 para sair): ");
        mais = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"\nProgressão finalizada com {total} termos mostrados.");
}
public static void desafio063()
    {
        Console.Write("Quantos termos da sequência de Fibonacci você quer ver? ");
        int n = int.Parse(Console.ReadLine());
        int t1 = 0;
        int t2 = 1;
        int c = 3;
        Console.WriteLine("\n~ Sequência de Fibonacci ~");
        if(n >= 1) Console.Write($"{t1}");
        if ( n >= 2) Console.Write($" -> {t2}");

        while (c <= n)
        {
            int t3 = t1 + t2;
            Console.Write($" -> {t3}");
            t1 = t2;
            t2 = t3;
            c++;
        }
        Console.WriteLine(" -> FIM");
    }
public static void desafio064()
    {
        int numero = 0;
        int c = 0;
        int soma = 0;
        while(numero != 9999)
        {
            Console.Write($"Digite o {c+1}° número: DIGITE 9999 PARA PARAR: ");
            numero = int.Parse(Console.ReadLine());
            if(numero != 9999)
            {
                
            
            soma = soma + numero;
            c++;
        }
        }
        Console.Write($"O total de números digitados foi de {c} e a soma de todos os números é de {soma}.");
    }

    public static void desafio065()
    {
        string resp = "s";
        int c = 0;
        int soma = 0;
        
        int menor = 0;
        int maior = 0;
        

        while(resp == "s")
        {
            Console.Write($"Digite o {c+1}° número: ");
            int numero = int.Parse(Console.ReadLine());
             soma += numero;
           
            if(c == 0)
            {
                maior = numero;
                menor = numero;
            }
            else
            {
                if(numero > maior)
                {
                    maior = numero;
                }
                if(numero < menor)
                {
                    menor = numero;
                }
            }

            
           
            c++;
             Console.Write($"Deseja continuar? [S/N]");
            resp = Console.ReadLine().ToLower().Trim();
            Console.WriteLine();
       
        }
        double media = (double)soma / c;
        Console.WriteLine($"O total de números digitados foi de {c} e a soma de todos os números é de {soma}.");
        Console.WriteLine($"A média dos números digitados é de {media:F2}.");
        Console.WriteLine($"O maior número digitado foi o  {maior}.");
        Console.WriteLine($"O menor número digitado foi o {menor}.");

    }
    public static void desafio066()
    {
        int soma = 0;

        while (true)
        {
            Console.Write("Digite um valor (999 para parar): ");
            int num = int.Parse(Console.ReadLine());

            if (num == 999)
            {
                break;
            }

            soma += num;
        }

        Console.WriteLine($"A soma dos valores foi {soma}!");
    }

    public static void desafio067()
    {
        while (true)
        {
            Console.Write("Quer ver a tabuada de qual valor? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 30));

            // Se o número for negativo, interrompe o laço
            if (n < 0)
            {
                break;
            }

            // Laço para calcular a tabuada de 1 a 10
            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine($"{n} x {c} = {n * c}");
            }

            Console.WriteLine(new string('-', 30));
        }

        Console.WriteLine("PROGRAMA TABUADA ENCERRADO. Volte sempre!");
    }
    public static void desafio068()
    {
        Random gerador = new Random();
        int v = 0; // Contador de vitórias

        while (true)
        {
            Console.Write("Diga um valor: ");
            int jogador = int.Parse(Console.ReadLine());

            int computador = gerador.Next(0, 11); // Gera número de 0 a 10
            int total = jogador + computador;
            string tipo = "";

            // Laço de validação: só aceita 'P' ou 'I'
            while (tipo != "P" && tipo != "I")
            {
                Console.Write("Par ou Ímpar? [P/I]: ");
                string entrada = Console.ReadLine().Trim().ToUpper();

                if (!string.IsNullOrEmpty(entrada))
                {
                    tipo = entrada[0].ToString(); // Pega apenas a primeira letra
                }
            }

            Console.WriteLine($"\nVocê jogou {jogador} e o computador {computador}. Total de {total}");
            Console.WriteLine(total % 2 == 0 ? "DEU PAR!" : "DEU ÍMPAR!");

            // Lógica de vitória e derrota
            if (tipo == "P")
            {
                if (total % 2 == 0)
                {
                    Console.WriteLine("Você VENCEU!");
                    v++;
                }
                else
                {
                    Console.WriteLine("Você PERDEU!");
                    break;
                }
            }
            else if (tipo == "I")
            {
                if (total % 2 == 1)
                {
                    Console.WriteLine("Você VENCEU!");
                    v++;
                }
                else
                {
                    Console.WriteLine("Você PERDEU!");
                    break;
                }
            }

            Console.WriteLine("Vamos jogar novamente...\n" + new string('-', 30));
        }

        Console.WriteLine($"\nGAME OVER! Você venceu {v} vezes.");
    }
    public static void desafio069()
    {
        int tot18 = 0;
        int totH = 0;
        int totM20 = 0;

        while (true)
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            string sexo = "";

            // Validação do sexo (só aceita M ou F)
            while (sexo != "M" && sexo != "F")
            {
                Console.Write("Sexo: [M/F] ");
                string entradaSexo = Console.ReadLine().Trim().ToUpper();

                if (!string.IsNullOrEmpty(entradaSexo))
                {
                    sexo = entradaSexo[0].ToString();
                }
            }

            // Análise dos dados cadastrados
            if (idade >= 18)
            {
                tot18++;
            }

            if (sexo == "M")
            {
                totH++;
            }

            if (sexo == "F" && idade < 20)
            {
                totM20++;
            }

            string resp = "";

            // Validação de continuação (só aceita S ou N)
            while (resp != "S" && resp != "N")
            {
                Console.Write("Quer continuar? [S/N] ");
                string entradaResp = Console.ReadLine().Trim().ToUpper();

                if (!string.IsNullOrEmpty(entradaResp))
                {
                    resp = entradaResp[0].ToString();
                }
            }

            // Condição de parada do loop principal
            if (resp == "N")
            {
                break;
            }

            Console.WriteLine(); // Linha em branco para organizar a saída
        }

        Console.WriteLine("\n===== FIM DO PROGRAMA =====");
        Console.WriteLine($"Total de pessoas com mais de 18 anos: {tot18}.");
        Console.WriteLine($"Ao todo temos {totH} homens cadastrados.");
        Console.WriteLine($"E temos {totM20} mulheres com menos de 20 anos.");
    }

    public static void desafio070()
    {
        double total = 0;
        int totmil = 0;
        double menor = 0;
        int cont = 0;
        string barato = "";

        while (true)
        {
            Console.Write("Nome do Produto: ");
            string produto = Console.ReadLine();

            Console.Write("Preço: R$ ");
            double preco = double.Parse(Console.ReadLine());

            cont++;
            total += preco;

            if (preco > 1000)
            {
                totmil++;
            }

            // No primeiro produto ou se encontrar um valor menor
            if (cont == 1 || preco < menor)
            {
                menor = preco;
                barato = produto;
            }

            string resp = "";

            // Validação da resposta (aceita apenas 'S' ou 'N')
            while (resp != "S" && resp != "N")
            {
                Console.Write("Quer continuar? [S/N] ");
                string entradaResp = Console.ReadLine().Trim().ToUpper();

                if (!string.IsNullOrEmpty(entradaResp))
                {
                    resp = entradaResp[0].ToString();
                }
            }

            if (resp == "N")
            {
                break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("\n" + "FIM DO PROGRAMA".PadLeft(27, '-').PadRight(40, '-'));
        Console.WriteLine($"O total da compra foi R${total:F2}");
        Console.WriteLine($"Temos {totmil} produtos custando mais de R$1000.00");
        Console.WriteLine($"O produto mais barato foi {barato} que custa R${menor:F2}");
    }
    public static void desafio071()
    {
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("BANCO SILMIR".PadLeft(21).PadRight(30));
        Console.WriteLine(new string('=', 30));

        Console.Write("Que valor você quer sacar? R$: ");
        int valor = int.Parse(Console.ReadLine());

        int total = valor;
        int ced = 50;
        int totced = 0;

        while (true)
        {
            if (total >= ced)
            {
                total -= ced;
                totced++;
            }
            else
            {
                if (totced > 0)
                {
                    Console.WriteLine($"Total de {totced} cédulas de R${ced}");
                }

                if (ced == 50)
                {
                    ced = 20;
                }
                else if (ced == 20)
                {
                    ced = 10;
                }
                else if (ced == 10)
                {
                    ced = 1;
                }

                totced = 0;

                if (total == 0)
                {
                    break;
                }
            }
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Volte sempre ao BANCO SILMIR! Tenha um bom dia!");
    }
}
