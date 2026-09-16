using System.Net;
using System.Globalization;
using System.Net.Http.Headers;
using System;
using Microsoft.Win32.SafeHandles;
using System.Linq;

class MeusExercicios
{
  
    public static void ex001()
    {
        Console.WriteLine("Olá Mundo.");
    }
    public static void ex002()
    {
        Console.Write("Digite o seu Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"é um prazer te conhecer {nome}");
    }

    public static void desafio003()
    {
        Console.Write("Digite o Primeiro Valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        int soma = valor1 + valor2;
        Console.WriteLine($"A soma entre {valor1} + {valor2} = {soma}");

    }

    public static void desafio004()
    {
        Console.Write("Digite algo no teclado: ");
        string teclado = Console.ReadLine();

        bool somenteNumero = teclado.All(char.IsDigit);
        bool apenasLetras = teclado.All(char.IsLetter);
        bool alfaNumerico = teclado.All(char.IsLetterOrDigit);
        bool tudoMaiusculo = teclado.All(char.IsUpper);
        bool tudoMinusculo = teclado.All(char.IsLower);
        Console.WriteLine($"Tem somente Números? {somenteNumero}");
        Console.WriteLine($"Tem somente Letras? {apenasLetras}");
        Console.WriteLine($"Tem Números e Letras? {alfaNumerico}");
        Console.WriteLine($"Tudo Maiusculo? {tudoMaiusculo}");
        Console.WriteLine($"Tudo Minusculo? {tudoMinusculo}");
    }

    public static void desafio005()
    {
        Console.Write("Digite um valor: ");
        int valor = int.Parse(Console.ReadLine());
        int ant = valor - 1;
        int suc = valor + 1;
        Console.WriteLine($"O valor {valor} tem seu antecessor que é {ant} e seu sucessor que é {suc}");
    }

    public static void desafio006()
    {
        Console.Write("Digite um valor: ");
        int valor = int.Parse(Console.ReadLine());
        int dobro = valor * 2;
        int triplo = valor * 3;
        
        double raiz = Math.Sqrt(valor);
        Console.WriteLine($"O valor {valor}");
        Console.WriteLine($"Tem o dobro {dobro}");
        Console.WriteLine($"Tem o triplo {triplo}");
        Console.WriteLine($"Tem a raiz quadrada {raiz}");

    }

    public static void desafio007()
    {
        Console.Write("Digite a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float media = (nota1 + nota2) / 2;
        Console.WriteLine($"As notas {nota1:F2} + {nota2:F2} tem a média de {media:F2}.");

    }

    public static void desafio008()
    {
        Console.Write("Digite um valor em M²: ");
        float medida = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float cm = medida * 100;
        float mm = medida * 1000;
        Console.WriteLine($"A medida {medida:F2}m² tem {cm} centímetros e {mm} milímetros.");
    }

    public static void desafio009()
    {
        Console.Write("Digite um valor: ");
        int valor = int.Parse(Console.ReadLine());
        int contador = 1;
        while(contador <= 10)
        {
            int mult = valor * contador;
            Console.WriteLine($"{valor} x {contador} = {mult}");
            contador++;
        }
    }

    public static void desafio010()
    {
        Console.Write("Quanto você tem na sua carteira?R$: ");
        double dinheiro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double dolar = dinheiro / 3.27;
        Console.WriteLine($"Com R$ {dinheiro:F2} você consegue comprar USS${dolar:F2}");

    }

    public static void desafio011()
    {
        Console.Write("Quanto de altura tem sua parede? ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Quanto de largura tem sua parede? ");
        double largura = double.Parse(Console.ReadLine());
        double area = altura * largura;
        double tinta = area / 2;
        Console.WriteLine($"A sua parede de {area}² vai necessitar de {tinta} litros de tintas");

    }

    public static void desafio012()
    {
        Console.Write("Qual o preço do produto?R$ ");
        double produto = double.Parse(Console.ReadLine());
        double desc = produto - (produto * 0.05);
        Console.WriteLine($"O produto com valor de R${produto:F2} com 5% de desconto passa a custar R${desc:F2}.");
    }

    public static void desafio013()
    {
        Console.Write("Quanto o fúncionario recebe?R$: ");
        double sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double ajuste = sal + (sal * 0.15);
        Console.WriteLine($"O salario de R$ {sal:F2} vai passar a ser R$ {ajuste:F2}.");

    }

    public static void desafio014()
    {
        Console.Write("Quantos graus você quer converter? ");
        double grau = double.Parse(Console.ReadLine());
        double f = 9 * grau / 5 +32;
        Console.WriteLine($"{grau:F2}°C convertido fica {f:F2}°F");
    }

    public static void desafio015()
    {
        Console.Write("Quantos dias alugado? ");
        int dias = int.Parse(Console.ReadLine());
        Console.Write("Quantos Km rodados? ");
        double km = double.Parse(Console.ReadLine());
        double pago = (dias * 60) + (km * 0.15);
        Console.WriteLine($"Com {dias} dias alugado e rodando {km} km, você tem que pagar R${pago:F2}");

    }
    
    //abaixo funciona apenas com números com viruglas
        public static void desafio016()
    {
        Console.Write("Digite um número real qualquer: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine($"O valor digitado {num} arredondado ficaria {Math.Round(num)}!");
    }
    public static void desafio016B()
    {
        //aceita virgula e ponto
        Console.Write("Digite um número real qualquer: ");
        string entrada = Console.ReadLine();
        entrada = entrada.Replace(",", ".");
        double num = double.Parse(entrada, CultureInfo.InvariantCulture);
        Console.WriteLine($"O valor digitado {num.ToString(CultureInfo.InvariantCulture)} arredondado ficaria {Math.Round(num)}!");
    }

    public static void desafio017()
{
    Console.Write("Digite o comprimento do cateto oposto: ");
    // O InvariantCulture garante que o Parse sempre leia o ponto final gerado pelo Replace
    double catetoOposto = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

    Console.Write("Digite o comprimento do cateto adjacente: ");
    double catetoAdjacente = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

    double hipotenusa = Math.Sqrt(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));
    
    // Mostra o resultado final com ponto ou vírgula dependendo do PC, mas com 2 casas decimais
    Console.WriteLine($"A hipotenusa vai medir {hipotenusa:F2}");
}

    public static void desafio018()
    {
        Console.Write("Digite o ângula que você deseja: ");
        double graus = double.Parse(Console.ReadLine().Replace(",","."));
        double radianos = graus * Math.PI / 180;

        double seno = Math.Sin(radianos);
        double cosseno = Math.Cos(radianos);
        double tangente = Math.Tan(radianos);

        Console.WriteLine($"o ângulo de {graus} tem: ");
        Console.WriteLine($"-> O Seno é {seno:F2}");
        Console.WriteLine($"-> O Cosseno é {cosseno:F2}");
        Console.WriteLine($"-> O Tangente é {tangente:F2}");

    }
   
   public static void desafio019()
    {
        Console.Write("Primeiro aluno: ");
        string nome1 = Console.ReadLine();

        Console.Write("Segundo aluno: ");
        string nome2 = Console.ReadLine();

        Console.Write("Terceiro aluno: ");
        string nome3 = Console.ReadLine();

        Console.Write("Quarto aluno: ");
        string nome4 = Console.ReadLine();

        string[] alunos = {nome1,nome2,nome3,nome4};

        Random aleatorio = new Random();

        int indiceSorteado = aleatorio.Next(0, alunos.Length);

        string escolhido = alunos[indiceSorteado];

        Console.WriteLine($"O aluno escolhido foi: {escolhido}");
    }

      public static void desafio020()
    {
        Console.Write("Primeiro aluno: ");
        string nome1 = Console.ReadLine();

        Console.Write("Segundo aluno: ");
        string nome2 = Console.ReadLine();

        Console.Write("Terceiro aluno: ");
        string nome3 = Console.ReadLine();

        Console.Write("Quarto aluno: ");
        string nome4 = Console.ReadLine();

        string[] alunos = {nome1,nome2,nome3,nome4};

        Random aleatorio = new Random();

        

        var lista = alunos.OrderBy(aluno => aleatorio.Next()).ToArray();

        Console.WriteLine($"O 1° aluno escolhido foi: {lista[0]}");
        Console.WriteLine($"O 2° aluno escolhido foi: {lista[1]}");
        Console.WriteLine($"O 3° aluno escolhido foi: {lista[2]}");
        Console.WriteLine($"O 4° aluno escolhido foi: {lista[3]}");
    }

    public static void desafio022()

    {
        Console.Write("Digite seu nome completo: ");
        string nomeCompleto = Console.ReadLine();

        string nomeMaiusculo = nomeCompleto.ToUpper();
        string nomeMinusculo = nomeCompleto.ToLower();

        string nomeLimpo = nomeCompleto.Trim();

        int totalLetras = nomeCompleto.Count(caractere => !char.IsWhiteSpace(caractere));

        string[] partesDoNome = nomeLimpo.Split(' ');

        string primeiroNome = partesDoNome[0];
        int letrasPrimeiroNome = primeiroNome.Length;

        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"Seu nome Original: \"{nomeCompleto}\"");
        Console.WriteLine($"Seu nome em Maiúsculo: {nomeMaiusculo}");
        Console.WriteLine($"Seu nome em Minúsculo: {nomeMinusculo}");
        Console.WriteLine($"O total de letras sem contar espaços: {totalLetras}");
        Console.WriteLine($"O primeiro nome é \"{primeiroNome}\" e ele tem {letrasPrimeiroNome} letras.");


    }


    public static void desafio023()
    {
        Console.Write("Digite um número entre 0 e 9999: ");
        string entrada = Console.ReadLine();

        entrada = entrada.Trim();

        if(int.TryParse(entrada, out int numeroValido) && numeroValido >= 0 && numeroValido <= 9999)
        {
            string numeroFormatado = entrada.PadLeft(4, '0');
            char milhar = numeroFormatado[0];
            char centena = numeroFormatado[1];
            char dezena = numeroFormatado[2];
            char unidade = numeroFormatado[3];

            Console.WriteLine($"\nAnalisando o número {entrada} (formatado como: {numeroFormatado}):");
            Console.WriteLine($"Milhar: {milhar}");
            Console.WriteLine($"Centena: {centena}");
            Console.WriteLine($"Dezena: {dezena}");
            Console.WriteLine($"Unidade: {unidade}");
        }
        else
        {
            Console.WriteLine("Erro: Por favor, digite um número entre 0 e 9999");
        }
    }

    public static void desafio024()
    {
        Console.Write("Digite o nome da sua cidade: ");
        string cidade = Console.ReadLine();

        bool santo = cidade.Contains("santo", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(santo);
    }

    public static void desafio025()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();
        bool silva = nome.Contains("silva", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(silva);
    }

    public static void desafio026()
    {
        Console.Write("Digite uma frase qualquer: ");
        string frase = Console.ReadLine();

        Console.Write("Digite a letra que deseja analisar: ");
        string entradaLetra = Console.ReadLine();

        char letraProcurada = entradaLetra[0];

        string fraseMinuscula = frase.ToLower();
        char letraMinuscula = char.ToLower(letraProcurada);
        // "Conte se o caractere NÃO for espaço em branco E for igual à letra procurada"
int totalOcorrencias = fraseMinuscula.Count(caractere => !char.IsWhiteSpace(caractere) && caractere == letraMinuscula);

        int primeiraPosicao = fraseMinuscula.IndexOf(letraMinuscula) + 1;
        int ultimaPosicao = fraseMinuscula.LastIndexOf(letraMinuscula) + 1;
        Console.WriteLine($"\nAnalisando a letra '{letraProcurada}' na frase:");
        Console.WriteLine($"-> A letra aparece {totalOcorrencias} vezes.");
        Console.WriteLine($"A primeira posição dela é: {primeiraPosicao}");
        Console.WriteLine($"A última posicação dela é: {ultimaPosicao}");

    }

    public static void desafio027()
    {
        Console.Write("Digite seu nome completo: ");
        string nomeCompleto = Console.ReadLine();

        string nomeLimpo = nomeCompleto.Trim();

        string[] partesDoNome = nomeLimpo.Split(' ');
        string primeiroNome = partesDoNome[0];
        string ultimoNome = partesDoNome[^1];
        Console.WriteLine($"Olá muito prazer em te conhecer {nomeCompleto}");
        Console.WriteLine($"Seu primeiro nome é: {primeiroNome}");
        Console.WriteLine($"Seu último nome é: {ultimoNome}");
    }

    public static void desafio028()
    {
        Random gerador = new Random();
        int numeroPensado = gerador.Next(1,6);
        Console.WriteLine(numeroPensado);
        Console.Write("Pensei em um número de 1 a 5, Qual seu Palpite? ");
        int palpite = int.Parse(Console.ReadLine());
        if(palpite == numeroPensado)
        {
            Console.WriteLine("Parabéns você acertou.");
        }
        else
        {
            Console.WriteLine($"Não foi o número que pensei, eu pensei no {numeroPensado}");
        }
    }

    public static void desafio029()
    {
        Console.Write("Qual velocidade você passou no radar KM: ? ");
        double velocidade = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
        if(velocidade > 80.00)
        {
            double valorParaPagar = (velocidade - 80.0) * 7.0;
            Console.WriteLine($"Você passou na velocidade de {velocidade} e isso é acima de 80KM/H sua multa é no valor de {valorParaPagar:F2}");
        }
        else
        {
            Console.WriteLine($"sua velocidade de KM/H {velocidade} esta no limite, parabéns.");
        }
    }
    public static void desafio030()
    {
        Console.Write("Digite um número qualquer inteiro: ");
        string entrada = Console.ReadLine();

        if(int.TryParse(entrada, out int numeroInteiro))
        {
            if(numeroInteiro % 2 == 0)
            {
                Console.WriteLine($"O número {numeroInteiro} é PAR.");
            }
            else
            {
                Console.WriteLine($"O número {numeroInteiro} é ÍMPAR.");
            }
        }
        else if(double.TryParse(entrada, out double numeroReal))
        {
            Console.WriteLine($"<ERRO>: NÚMERO {numeroReal} DIGITADO NÃO É NÚMERO INTEIRO");
        }
        else
        {
            Console.WriteLine("ERRO: O que você digitou não é um número.");
        }
    }

    public static void desafio031()
    {
        Console.Write("Qual a distância que você vai viajar em KM: ");
        double distancia = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
        if(distancia <= 200.00)
        {
            double valorViagemCurta = distancia * 0.50;
            Console.WriteLine($"Sua viagem tem uma distância de KM/H: {distancia:F2} e terá um valor de R$: {valorViagemCurta} ");
        }
        else
        {
            double valorViagemLonga = distancia * 0.45;
             Console.WriteLine($"Sua viagem tem uma distância de KM/H: {distancia:F2} e terá um valor de R$: {valorViagemLonga} ");
        }

    }

    public static void desafio032()
    {
        Console.Write("Digite qualquer ano para analisarmos: ");
        int ano = int.Parse(Console.ReadLine());
        if((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
        {
            Console.WriteLine($"O ano {ano} é bissexto! (possui 366 dias)");
        }
        else
        {
            Console.WriteLine($"O ano {ano} NÃO é bissexto. (possui 365 dias).");
        }
    }
    public static void desafio033()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro valor: ");
        int num3 = int.Parse(Console.ReadLine());
        int menor = num1;
        if(num2 < menor) menor = num2;
        if(num3 < menor) menor = num3;
        int maior = num1;
        if(num2 > maior) maior = num2;
        if (num3 > maior) maior = num3;
        Console.WriteLine($"\nO maior número é o {maior} e o menor é o {menor}.");

    }

    public static void desafio034()
    {
        Console.Write("Quanto é o salário da pessoa? ");
        double salario = double.Parse(Console.ReadLine());
        if(salario > 1250)
        {
            double ajusteMenor = salario + (salario * 0.10);
            Console.WriteLine($"Com o salário de R$ {salario:F2} tendo o aumento de 10% o salário vai passar a ser de R$ {ajusteMenor:F2}.");
        }
        if(salario <= 1250)
        {
            double ajusteMaior = salario + (salario * 0.15);
            Console.WriteLine($"Com o salário de R$ {salario:F2} tendo o aumento de 15% o salário vai passar a ser de R$ {ajusteMaior:F2}.");
        }
    }
    public static void desafio035()
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
        }
        else
        {
            Console.WriteLine("Os segmentos acima NÃO PODEM FORMAR UM TRIÂNGULO");
        }

    }

}
