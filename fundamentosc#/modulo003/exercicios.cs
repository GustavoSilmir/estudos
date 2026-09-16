using System;
using System.Formats.Asn1;
using System.Linq;

class Desafios
{
    public static void Conceito01()
    {
        // Declaração da coleção estática
        string[] lanche = { "Hambúrguer", "Suco", "Pizza", "Pudim", "Batata Frita" };

        // 1. Exibe o tamanho do array (len em Python = Length em C#)
        Console.WriteLine(lanche.Length);

        // 2. Iteração com laço 'for' usando índice
        for (int cont = 0; cont < lanche.Length; cont++)
        {
            Console.WriteLine($"Eu vou comer {lanche[cont]} na posição {cont}");
        }

        // 3. Iteração simplificada (for comida in lanche = foreach)
        // foreach (string comida in lanche)
        // {
        //     Console.WriteLine($"Eu vou comer {comida}");
        // }

        Console.WriteLine("Acabou");
    }

    //Organizando uma tupla
    static void Conceito02()
    {
        string[] lanche = { "Hambúrguer", "Suco", "Pizza", "Pudim", "Batata Frita" };

        // Opção A: Usando LINQ (retorna um novo conjunto ordenado, exatamente como o sorted() do Python)
        var lancheOrdenado = lanche.OrderBy(x => x).ToArray();

        foreach (var comida in lancheOrdenado)
        {
            Console.WriteLine(comida);
        }

        // Opção B: Usando Array.Sort() (ordena o próprio array original)
        Array.Sort(lanche);
    }
    public static void Conceito03()
    {
        int[] a = {2,5,4};
        int[] b = {5,8,1,2};
        int[] c = b.Concat(a).ToArray();
        Console.WriteLine(string.Join(", ", c));
    }

    public static void Conceito04()
    {
        var pessoas = ("Gustavo", 99.80, 39,'M');       
        Console.Write(pessoas);
    }

    //Exemplos de tuplas com diversos valores em c# suportando até 8 ou mais
    static void Exemplo01()
    {
        // Tupla com int, string, double e bool
        var pessoa = (1, "Lucas", 3500.50, true);

        // Acessando pelos nomes padrão:
        Console.WriteLine($"ID: {pessoa.Item1}");
        Console.WriteLine($"Nome: {pessoa.Item2}");
        Console.WriteLine($"Salário: {pessoa.Item3}");
        Console.WriteLine($"Ativo: {pessoa.Item4}");
    }

    public static void Exemplo02()
    {
        // Declarando explicitamente os tipos e nomes dos campos
        (int Id, string Nome, double Salario, bool Ativo) funcionario = (101, "Ana", 5200.00, true);

        // Acessando pelos nomes definidos:
        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"Status: {(funcionario.Ativo ? "Ativo" : "Inativo")}");

        var megaTupla = (1, "A", 3.0, true, 'X', 10L, 2.5f, "Mais um", 999);
        Console.WriteLine(megaTupla); // Funciona normalmente
    }

    public static void desafio072()
    {
        
        string[] numeroExtenso = {"zero","um","dois","três","quatro","cinco","seis","sete","oito","nove","dez","onze","doze","treze","quatorze","quinze","dezesseis","dezessete","dezoito","dezenove","vinte"};
        int numeroLido;
        while(true)
        {
            Console.Write("Digite um número entre 0 e 20: ");
            if(int.TryParse(Console.ReadLine(), out numeroLido) && numeroLido >= 0 && numeroLido <= 20)
            {
                break;
            }
            Console.WriteLine("Tente novamente");
        }
        Console.WriteLine($"Você digitou o número {numeroExtenso[numeroLido]}.");
    }

    public static void desafio073()
    {
        string[] tabelaPremier = {"arsenal","city","manchester united","aston villa","liverpool","boumemouth","sunderland", "brighton","brentford","chelsea","fulhan","newcastle","everton","leeds","crystal palace","nottingham","spurs","west ham","burnley","wolves"};
        
        string[] primeiros5 = tabelaPremier.Take(5).ToArray();
        string[] ultimos4 = tabelaPremier[^4..];
        string[] ordemAlfabetica = tabelaPremier.OrderBy(t => t).ToArray();
        string[] ordemAlfabeticareversa = tabelaPremier.OrderByDescending(t => t).ToArray();
        Console.WriteLine($"Os cinco primeiros colocados são: {string.Join(", ", primeiros5)}");
        Console.WriteLine($"Os últimos 4 colocados são: {string.Join(", ", ultimos4)}");
        Console.WriteLine($"Os times em ordem alfabética de A a Z fica assim: {string.Join(", ", ordemAlfabetica)}");
        Console.WriteLine($"Os times em ordem alfabética de Z a A fica assim: {string.Join(", ", ordemAlfabeticareversa)}");
        string busca = "Everton";
        int indice = Array.FindIndex(tabelaPremier, t => t.Equals(busca, StringComparison.OrdinalIgnoreCase));
        if (indice != -1)
        {
            string nome = tabelaPremier[indice];
            int posicao = indice + 1;
            
        Console.WriteLine($"O time {nome} está na {posicao}ª posição.");
        }
    }
    public static void desafio074()
    {
       
        int[] temp = Enumerable.Range(1, 15).OrderBy(x => Guid.NewGuid()).Take(10).ToArray();

        

        var numeros = (temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9]);
        Console.WriteLine($"Tupla gerada: {numeros}");
        Array.Sort(temp);
        int maior = temp.Max();
        int menor = temp.Min();
        Console.WriteLine($"Números ordenados: {string.Join(", ", temp)}");
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }

    public static void desafio075()
    {
        
        int[] temp = new int[5];
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o { i + 1}° número: ");
            temp[i] = int.Parse(Console.ReadLine());
        }

        var tuplaNumeros =(temp[0],temp[1],temp[2],temp[3],temp[4]);
        int noveApareceu = temp.Count(x => x == 9);        
        
    Array.Sort(temp);
        Console.WriteLine($"A tupla digitada foi: {tuplaNumeros}");
        Console.WriteLine($"Tupla ordenada: {string.Join(", ", temp)}");
        Console.WriteLine($"O número 9 apareceu {noveApareceu} vezes no programa.");
        int indiceTres = Array.IndexOf(temp, 3);
        if (indiceTres != -1)
        {
            Console.WriteLine($"O valor 3 apareceu pela primeira vez na {indiceTres + 1}ª posição.");
        }
        else
    {
        Console.WriteLine("O valor 3 não foi digitado em nenhuma posição.");
    }
    var pares = temp.Where(x => x % 2 == 0);
    Console.WriteLine($"Os valores pares digitados foram: {string.Join(" ", pares)}");
    }

    public static void desafio077()
    {
        string[] palavras = {"amor","raiva","carinho","atencao","doloroso","carro","gcom"};

        char[] vogais = {'a','e','i','o','u',};
        foreach (string palavra in palavras)
        {
            Console.Write($"Em '{palavra}' temos as vogais: ");
            foreach (char letra in palavra)
            {
                if(vogais.Contains(letra))
                {
                    Console.Write($"{letra} ");
                }
            }
            Console.WriteLine();
        }
    }
    public static void desafio078()
    {
        List<int> numeros = new List<int>();

        for(int i = 0; i < 5; i++)
        {
            while(true)
            {
                Console.Write($"Digite o {i}° número: ");
                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out int valor))
                {
                    numeros.Add(valor);
                    break;
                }
                Console.WriteLine("Entrada inválida! Digire apenas números inteiros");
            }
        }


        Console.WriteLine("\nValores armazenados na lista:");
        Console.WriteLine(string.Join(", ", numeros));

        int maior = numeros.Max();
        int menor = numeros.Min();
        Console.Write($"\nO maior valor digitado foi {maior} nas posições: ");
        for (int i =0; i < numeros.Count; i++)
        {
            if (numeros[i] == maior)
            {
                Console.Write($"{i}...");
            }
        }
        Console.WriteLine();
        Console.Write($"\nO menor valor digitado foi {menor} nas posições: ");
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] == menor)
            {
                Console.Write($"{i}...");
            }
        }
        Console.WriteLine();
        Console.Write($"\n A lista ordenada fica assim: ");
        numeros.Sort();
        Console.WriteLine(string.Join(", ", numeros));
    }

    public static void desafio079()
    {
        List<int> numeros = new List<int>();
        while(true)
            {
                Console.Write($"Digite um número: ");
                string entrada = Console.ReadLine()!;

               

                if (int.TryParse(entrada, out int valor))
                {
                    if(numeros.Contains(valor))
                {
                    Console.WriteLine("Valor duplicado! Informe outro número....");
                    continue;
                }
                else
                {
                    numeros.Add(valor);
                    Console.WriteLine("Valor adicionado com sucesso...");
                }
                    
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digire apenas números inteiros");
                continue;
            }
             Console.Write($"Deseja Continuar?[S/N] ");
                string resposta = Console.ReadLine()!.Trim().ToUpper();
                if (resposta == "N")
            {
                break;
            }
            }
            numeros.Sort();
            Console.WriteLine($"\nValores cadastrados: {string.Join(", ", numeros)}");
    }
    public static void desafio080()
    {

        List<int> numeros = new List<int>();
         for(int i = 0; i < 5; i++)
        {
            while(true)
            {
                Console.Write($"Digite o {i}° número: ");
                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out int valor))
                {
                    if(numeros.Count == 0 || valor > numeros[numeros.Count - 1])
                    {
                        numeros.Add(valor);
                        Console.WriteLine("Adicionado ao final da lista....");
                    }
                    else
                    {
                        for(int pos = 0; pos < numeros.Count; pos++)
                        {
                            if(valor <= numeros[pos])
                            {
                                numeros.Insert(pos,valor);
                                Console.WriteLine($"Adicionando na posição {pos} da lista...");
                                break;
                            }
                        }
                    }
                    break;
                    
                }
                Console.WriteLine("Entrada inválida! Digire apenas números inteiros");
            }
        }

        
       Console.WriteLine($"\nA lista ordenada fica assim: {string.Join(", ", numeros)}");
    }

    public static void desafio081()
    {
        List<int> numeros = new List<int>();
        int valoresDigitados = 0;
        int valorCinco = 0;
        while(true)
            {
                Console.Write($"Digite um número: ");
                string entrada = Console.ReadLine()!;

               

                if (int.TryParse(entrada, out int valor))
              {
                    numeros.Add(valor);
                    valoresDigitados += 1;
                    Console.WriteLine("Valor adicionado com sucesso...");
                   
                }
                    
            
            
             Console.Write($"Deseja Continuar?[S/N] ");
                string resposta = Console.ReadLine()!.Trim().ToUpper();
                if (resposta == "N")
            {
                break;
            }
            }
            numeros.Sort();
            Console.WriteLine($"\nValores cadastrados de forma crescente: {string.Join(", ", numeros)}");
            Console.WriteLine($"O total de números digitados foi de {valoresDigitados}.");
            numeros.Reverse();
            Console.WriteLine("Lista ordenada de forma decrescente...");
            Console.WriteLine(string.Join(", ", numeros));
            if(numeros.Contains(5))
        {
            Console.WriteLine("O valor 5 faz parte da lista!");
        }
        else
        {
            Console.WriteLine("O valor 5 não foi encontrado na lista");
        }
    }
}