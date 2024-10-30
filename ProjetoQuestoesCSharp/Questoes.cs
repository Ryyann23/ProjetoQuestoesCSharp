using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ProjetoQuestoesCSharp
{
    public class Questoes
    {
        private List<Action> questoes;

        public Questoes()
        {
            questoes = new List<Action>
        {
            Questao1,
            Questao2,
            Questao3,
            Questao4,
            Questao5,
            Questao6,
            Questao7,
            Questao8,
            Questao9,
            Questao10,
            Questao11,
            Questao12,
            Questao13,
            Questao14,
            Questao15,
            Questao16,
            Questao17,
            Questao18,
            Questao19,
            Questao20,
            Questao21,
            Questao22,
            Questao23,
            Questao24,
            Questao25,
            Questao26,
            Questao27,
            Questao28,
            Questao29,
            Questao30,
            Questao31,
            Questao32,
            Questao33,
            Questao34,
            Questao35,
            Questao36,
            Questao37,
            Questao38,
            Questao39,
            Questao40,
            Questao41,
            Questao42,
            Questao43,
            Questao44,
            Questao45,
            Questao46,
            Questao47,
            Questao48,
            Questao49,
            Questao50,
            Questao51,
            Questao52,
            Questao53,
            Questao54,
            Questao55,
            Questao56,
            Questao57,
            Questao58,
            Questao59,
            Questao60,
            Questao61,
            Questao62,
            Questao63,
            Questao64,
            Questao65,
            Questao66,
            Questao67,
            Questao68,
            Questao69,
            Questao70,
            Questao71,
            Questao72,
            Questao73,
            Questao74,
            Questao75,
            Questao76,
            Questao77,
            Questao78,
            Questao79,
            Questao80,
            Questao81,
            Questao82,
            Questao83,
            Questao84,
            Questao85,
            Questao86,
            Questao87,
            Questao88,
            Questao89,
            Questao90,
            Questao91,
            Questao92,
            Questao93,
            Questao94,
            Questao95,
            Questao96,
            Questao97,
            Questao98,
            Questao99,
            Questao100
        };
        }

        public void ExecutarQuestao(int numeroQuestao)
        {
            if (numeroQuestao >= 1 && numeroQuestao <= questoes.Count)
            {
                questoes[numeroQuestao - 1](); 
            }
            else
            {
                Console.WriteLine("Questão não encontrada.");
            }
        }
private void Questao1()
{
    Console.Write("Informe o nome do produto: ");
    string nomeProduto = Console.ReadLine();
    Console.Write("Informe o preço do produto: ");
    double precoProduto = double.Parse(Console.ReadLine());
    Console.WriteLine($"Produto: {nomeProduto}, Preço: {precoProduto}");
}

private void Questao2()
{
    Console.Write("Informe o nome do produto: ");
    string nomeProduto = Console.ReadLine();
    Console.Write("Informe o preço do produto: ");
    double precoProduto = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nome: {nomeProduto}, Preço: {precoProduto}");
}

private void Questao3()
{
    Console.Write("Informe o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.Write("Informe o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());
    int resultadoSoma = numero1 + numero2;
    Console.WriteLine($"A soma de {numero1} e {numero2} é: {resultadoSoma}");
}

private void Questao4()
{
    Console.Write("Informe um número: ");
    int numero = int.Parse(Console.ReadLine());
    string tipoNumero = numero % 2 == 0 ? "par" : "ímpar";
    Console.WriteLine($"O número {numero} é {tipoNumero}.");
}

private void Questao5()
{
    Console.Write("Informe o valor em metros: ");
    double valorMetros = double.Parse(Console.ReadLine());
    double valorCentimetros = valorMetros * 100;
    Console.WriteLine($"{valorMetros} metros são {valorCentimetros} centímetros.");
}

private void Questao6()
{
    Console.Write("Informe a idade: ");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine(idade >= 18 ? "A pessoa é maior de idade." : "A pessoa é menor de idade.");
}

private void Questao7()
{
    Console.Write("Informe o raio do círculo: ");
    double raio = double.Parse(Console.ReadLine());
    double areaCirculo = Math.PI * Math.Pow(raio, 2);
    Console.WriteLine($"A área do círculo é: {areaCirculo:F2}");
}

private void Questao8()
{
    Console.Write("Informe um número para exibir sua tabuada: ");
    int numero = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

private void Questao9()
{
    Console.Write("Informe um número para calcular a soma de 1 até ele: ");
    int limite = int.Parse(Console.ReadLine());
    int somaTotal = 0;
    for (int i = 1; i <= limite; i++)
    {
        somaTotal += i;
    }
    Console.WriteLine($"A soma de 1 até {limite} é: {somaTotal}");
}

private void Questao10()
{
    Console.Write("Informe a temperatura em Celsius: ");
    double temperaturaCelsius = double.Parse(Console.ReadLine());
    double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
    Console.WriteLine($"{temperaturaCelsius}°C em Fahrenheit é: {temperaturaFahrenheit}°F");
}

private void Questao11()
{
    Console.Write("Informe uma string: ");
    string entradaTexto = Console.ReadLine();
    Console.WriteLine(string.IsNullOrEmpty(entradaTexto) ? "A string é vazia ou nula." : "A string contém texto.");
}

private void Questao12()
{
    Console.WriteLine("Números pares entre 1 e 50:");
    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }
}

private void Questao13()
{
    Console.Write("Informe o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.Write("Informe o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());
    Console.Write("Informe o terceiro número: ");
    int numero3 = int.Parse(Console.ReadLine());

    int maiorNumero = Math.Max(numero1, Math.Max(numero2, numero3));
    Console.WriteLine($"O maior número é: {maiorNumero}");
}

private void Questao14()
{
    Console.Write("Informe uma string: ");
    string entradaTexto = Console.ReadLine();
    char[] arrayCaracteres = entradaTexto.ToCharArray();
    Array.Reverse(arrayCaracteres);
    Console.WriteLine("String invertida: " + new string(arrayCaracteres));
}

private void Questao15()
{
    Console.Write("Informe o ano de nascimento: ");
    int anoNascimento = int.Parse(Console.ReadLine());
    int idade = DateTime.Now.Year - anoNascimento;
    Console.WriteLine(idade >= 18 ? "A pessoa pode votar." : "A pessoa não pode votar.");
}

private void Questao16()
{
    Console.Write("Informe um número: ");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine(numero >= 0 ? "O número é positivo." : "O número é negativo.");
}

private void Questao17()
{
    Console.Write("Informe a primeira nota: ");
    double nota1 = double.Parse(Console.ReadLine());
    Console.Write("Informe a segunda nota: ");
    double nota2 = double.Parse(Console.ReadLine());
    Console.Write("Informe a terceira nota: ");
    double nota3 = double.Parse(Console.ReadLine());

    double mediaNotas = (nota1 + nota2 + nota3) / 3;
    Console.WriteLine(mediaNotas >= 7.0 ? "Aprovado" : "Reprovado");
}

private void Questao18()
{
    Console.Write("Informe uma string: ");
    string entradaTexto = Console.ReadLine();
    int contagemA = entradaTexto.Count(c => c == 'a' || c == 'A');
    Console.WriteLine($"A letra 'a' aparece {contagemA} vezes.");
}

private void Questao19()
{
    Console.WriteLine("Números de 10 a 1:");
    for (int i = 10; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}

private void Questao20()
{
    Console.Write("Informe um número: ");
    int limite = int.Parse(Console.ReadLine());
    int somaQuadradosTotal = 0;
    for (int i = 1; i <= limite; i++)
    {
        somaQuadradosTotal += i * i;
    }
    Console.WriteLine($"A soma dos quadrados de 1 até {limite} é: {somaQuadradosTotal}");
}

        private void Questao21()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bem-vindo, {nome}! Você tem {idade} anos.");
        }

        private void Questao22()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dobro: {numero * 2}, Triplo: {numero * 3}");
        }

        private void Questao23()
        {
            Console.Write("Digite uma string: ");
            string str = Console.ReadLine();
            char ultimoCaractere = str[str.Length - 1];
            Console.WriteLine($"Último caractere: {ultimoCaractere}");
        }

        private void Questao24()
        {
            Console.Write("Digite horas: ");
            int horas = int.Parse(Console.ReadLine());
            int segundos = horas * 3600;
            Console.WriteLine($"{horas} horas equivalem a {segundos} segundos.");
        }

        private void Questao25()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 3 == 0 && numero % 5 == 0)
                Console.WriteLine($"{numero} é divisível por 3 e por 5.");
            else
                Console.WriteLine($"{numero} não é divisível por 3 e por 5.");
        }

        private void Questao26()
        {
            Console.WriteLine("Digite três números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(input, int.Parse);
            Array.Sort(numeros);
            Console.WriteLine($"Números ordenados: {string.Join(", ", numeros)}");
        }

        private void Questao27()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fatorial de {numero} é {Fatorial(numero)}.");
        }

        private int Fatorial(int n)
        {
            return (n == 0) ? 1 : n * Fatorial(n - 1);
        }

        private void Questao28()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine($"Aluno: {nome}, Nota: {nota}");
        }

        private void Questao29()
        {
            Console.Write("Digite números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            double[] numeros = Array.ConvertAll(input, double.Parse);
            double media = numeros.Average();
            Console.WriteLine($"Média: {media}");
        }

        private void Questao30()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            string palavraInvertida = new string(palavra.Reverse().ToArray());
            bool isPalindromo = palavra.Equals(palavraInvertida, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isPalindromo ? "É um palíndromo." : "Não é um palíndromo.");
        }

        private void Questao31()
        {
            Console.Write("Digite números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(input, int.Parse);
            int menorNumero = numeros.Min();
            Console.WriteLine($"Menor número: {menorNumero}");
        }

        private void Questao32()
        {
            Console.Write("Digite um número para multiplicar: ");
            double multiplicador = double.Parse(Console.ReadLine());
            Console.Write("Digite números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            double[] numeros = Array.ConvertAll(input, double.Parse);
            double[] resultados = numeros.Select(n => n * multiplicador).ToArray();
            Console.WriteLine($"Resultados: {string.Join(", ", resultados)}");
        }

        private void Questao33()
        {
            Console.Write("Digite números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(input, int.Parse);
            int somaImpares = numeros.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"Soma dos ímpares: {somaImpares}");
        }

        private void Questao34()
        {
            Console.Write("Digite a marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o ano do carro: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine($"Carro: Marca: {marca}, Ano: {ano}");
        }

        private void Questao35()
        {
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
            Console.WriteLine(bissexto ? $"{ano} é bissexto." : $"{ano} não é bissexto.");
        }

        private void Questao36()
        {
            Console.WriteLine("Os 10 primeiros números da sequência de Fibonacci são:");
            int a = 0, b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{a} ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }

        private void Questao37()
        {
            Console.Write("Digite uma string: ");
            string str = Console.ReadLine();
            string resultado = str.Replace(' ', '_');
            Console.WriteLine($"Resultado: {resultado}");
        }

        private void Questao38()
        {
            Console.Write("Digite números separados por espaço: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(input, int.Parse);
            int indiceMaior = Array.IndexOf(numeros, numeros.Max());
            Console.WriteLine($"Índice do maior elemento: {indiceMaior}");
        }

        private void Questao39()
        {
            Console.Write("Digite dois números: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine($"MDC de {a} e {b} é {MDC(a, b)}.");
        }

        private int MDC(int a, int b)
        {
            return (b == 0) ? a : MDC(b, a % b);
        }

        private void Questao40()
        {
            Console.Write("Digite uma string: ");
            string str = Console.ReadLine();
            int contagemVogais = str.Count(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine($"Número de vogais: {contagemVogais}");
        }
        private void Questao41()
        {
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"Representação binária: {binario}");
        }

        private void Questao42()
        {
            Console.Write("Digite um número entre 0 e 9: ");
            int numero = int.Parse(Console.ReadLine());
            string[] palavras = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            Console.WriteLine(numero >= 0 && numero <= 9 ? palavras[numero] : "Número fora do intervalo.");
        }
        private void Questao43()
        {
            Random random = new Random();
            int[] frequencia = new int[6];

            for (int i = 0; i < 100; i++)
                frequencia[random.Next(1, 7) - 1]++;

            Console.WriteLine("O dado foi girado 100 vezes:");
            for (int i = 0; i < frequencia.Length; i++)
                Console.WriteLine($"Número {i + 1} apareceu {frequencia[i]} vezes");
        }

        private void Questao44()
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string categoria = imc < 18.5 ? "Baixo peso" :
                               imc < 24.9 ? "Peso normal" :
                               imc < 29.9 ? "Sobrepeso" :
                               "Obesidade";
            Console.WriteLine($"IMC: {imc:F2} - Categoria: {categoria}");
        }

        private void Questao45()
        {
            Console.Write("Digite a quantidade de números no array: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array.Max();
            int segundoMaior = array.Where(num => num != max).Max();
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");
        }

        private void Questao46()
        {
            Console.Write("Digite a quantidade de elementos no array: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(array);
            Console.WriteLine("Array invertido: " + string.Join(", ", array));
        }

        private void Questao47()
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] soma = new int[2, 2];

            Console.WriteLine("Digite os valores da primeira matriz 2x2:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    matrizA[i, j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores da segunda matriz 2x2:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    matrizB[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    soma[i, j] = matrizA[i, j] + matrizB[i, j];

            Console.WriteLine("Soma das matrizes:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(soma[i, j] + " ");
                Console.WriteLine();
            }
        }

        private void Questao48()
        {
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Dia da semana: {data.DayOfWeek}");
        }

        private void Questao49()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            bool somenteLetrasNumeros = input.All(char.IsLetterOrDigit);
            Console.WriteLine(somenteLetrasNumeros ? "A string contém apenas letras e números." : "A string contém outros caracteres.");
        }

        private void Questao50()
        {
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 0; i < expoente; i++)
                resultado *= baseNum;

            Console.WriteLine($"Resultado: {resultado}");
        }
        private void Questao51()
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite os valores da matriz 3x3:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matriz[i, j] = int.Parse(Console.ReadLine());

            bool simetrica = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] != matriz[j, i]) simetrica = false;

            Console.WriteLine(simetrica ? "A matriz é simétrica" : "A matriz não é simétrica");
        }

        private void Questao52()
        {
            Console.WriteLine("Digite uma lista de nomes separados por vírgula:");
            List<string> nomes = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
            nomes.Sort();
            Console.WriteLine("Nomes ordenados: " + string.Join(", ", nomes));
        }

        private void Questao53()
        {
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int frequente = array.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine("Elemento mais frequente: " + frequente);
        }

        private void Questao54()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int valorAbsoluto = numero < 0 ? -numero : numero;
            Console.WriteLine("Valor absoluto: " + valorAbsoluto);
        }

        private void Questao55()
        {
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Digite o número a ser encontrado: ");
            int valor = int.Parse(Console.ReadLine());
            int indice = Array.IndexOf(array, valor);
            Console.WriteLine(indice >= 0 ? $"Valor encontrado no índice {indice}" : "Valor não encontrado");
        }

        private void Questao56()
        {
            Console.WriteLine("Cronômetro iniciado...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " segundo(s)");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Cronômetro encerrado.");
        }

        private void Questao57()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int palavras = frase.Split(' ').Length;
            Console.WriteLine("Número de palavras: " + palavras);
        }
        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }

            public void Falar()
            {
                Console.WriteLine($"Olá, meu nome é {Nome}!");
            }
        }
        private void Questao58()
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Pessoa pessoa = new Pessoa(nome);
            pessoa.Falar();
        }

        private void Questao59()
        {
            Console.WriteLine("Digite os elementos do primeiro array separados por vírgula:");
            int[] array1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine("Digite os elementos do segundo array separados por vírgula:");
            int[] array2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] intersecao = array1.Intersect(array2).ToArray();
            Console.WriteLine("Interseção: " + string.Join(", ", intersecao));
        }

        private void Questao60()
        {
            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine();
            string resultado = string.Concat(texto.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)));
            Console.WriteLine("Texto alternado: " + resultado);
        }

        private void Questao61()
        {
            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine();
            int unicos = texto.Distinct().Count();
            Console.WriteLine("Caracteres únicos: " + unicos);
        }

        private void Questao62()
        {
            Console.Write("Digite o limite para exibir números primos: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("Números primos até " + limite + ":");
            for (int i = 2; i <= limite; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) primo = false;
                if (primo) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private void Questao63()
        {
            Console.Write("Digite um número para verificar se é perfeito: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i < numero; i++)
                if (numero % i == 0) soma += i;
            Console.WriteLine(soma == numero ? "Número perfeito" : "Não é perfeito");
        }

        private void Questao64()
        {
            Console.Write("Digite um número para exibir seus divisores: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores de " + numero + ":");
            for (int i = 1; i <= numero; i++)
                if (numero % i == 0) Console.Write(i + " ");
            Console.WriteLine();
        }

        private void Questao65()
        {
            int[,] matriz = new int[2, 3];
            Console.WriteLine("Digite os valores da matriz 2x3:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    matriz[i, j] = int.Parse(Console.ReadLine());

            int[,] transposta = new int[3, 2];
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    transposta[j, i] = matriz[i, j];

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                    Console.Write(transposta[i, j] + " ");
                Console.WriteLine();
            }
        }

        private void Questao66()
        {
            {
                Console.WriteLine("Horário atual: " + DateTime.Now);
                Thread.Sleep(1000);
            }
        }

        private void Questao67()
        {
            Console.Write("Digite uma operação (+, -, *, /): ");
            char operacao = Console.ReadLine()[0];
            Console.Write("Digite o primeiro número: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double resultado = operacao switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                _ => 0
            };
            Console.WriteLine("Resultado: " + resultado);
        }

        private void Questao68()
        {
            Console.Write("Digite um valor em reais: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor em extenso: " + valor.ToString("C"));
        }

        private void Questao69()
        {
            Console.Write("Digite as notas separadas por vírgula: ");
            int[] notas = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Digite os pesos das notas separados por vírgula: ");
            int[] pesos = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            double soma = 0, totalPesos = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i] * pesos[i];
                totalPesos += pesos[i];
            }
            Console.WriteLine("Média ponderada: " + (soma / totalPesos));
        }

        private void Questao70()
        {
            Console.Write("Digite o valor do saque: ");
            int valor = int.Parse(Console.ReadLine());
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            foreach (int nota in notas)
            {
                int qtdNotas = valor / nota;
                if (qtdNotas > 0)
                {
                    Console.WriteLine($"{qtdNotas} nota(s) de {nota}");
                    valor %= nota;
                }
            }
        }

        private void Questao71()
        {
            Console.WriteLine("Digite os elementos do primeiro array separados por vírgula:");
            int[] array1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine("Digite os elementos do segundo array separados por vírgula:");
            int[] array2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            bool iguais = array1.SequenceEqual(array2);
            Console.WriteLine(iguais ? "Arrays iguais" : "Arrays diferentes");
        }
        private void Questao72()
        {
            Console.Write("Digite o comprimento desejado para a senha: ");
            int comprimento = int.Parse(Console.ReadLine());

            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < comprimento; i++)
            {
                int indiceAleatorio = random.Next(caracteres.Length);
                senha.Append(caracteres[indiceAleatorio]);
            }

            Console.WriteLine("Senha gerada: " + senha.ToString());
        }

        private void Questao73()
        {
            Console.Write("Digite o número para a tabela de multiplicação: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tabela de multiplicação de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        private void Questao74()
        {
            Console.Write("Digite o lado A do triângulo: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado B do triângulo: ");
            double ladoB = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado C do triângulo: ");
            double ladoC = double.Parse(Console.ReadLine());

            double semiPerimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
            Console.WriteLine("Área do triângulo: " + area);
        }

        private void Questao75()
        {
            Console.Write("Digite o valor máximo para os números únicos gerados: ");
            int max = int.Parse(Console.ReadLine());
            HashSet<int> numeros = new HashSet<int>();
            Random random = new Random();

            while (numeros.Count < max)
            {
                numeros.Add(random.Next(1, max + 1));
            }

            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));
        }
        private void Questao76()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;
            Console.WriteLine("Jogo de Adivinhação: Tente adivinhar o número entre 1 e 100.");

            while (tentativa != numeroSecreto)
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa < numeroSecreto)
                    Console.WriteLine("O número secreto é maior.");
                else if (tentativa > numeroSecreto)
                    Console.WriteLine("O número secreto é menor.");
                else
                    Console.WriteLine("Parabéns! Você acertou o número.");
            }
        }

        private void Questao77()
        {
            Console.WriteLine("Verifique se dois arrays possuem os mesmos elementos (independente da ordem).");

            Console.WriteLine("Digite os elementos do primeiro array separados por espaço:");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Digite os elementos do segundo array separados por espaço:");
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool iguais = array1.OrderBy(x => x).SequenceEqual(array2.OrderBy(x => x));
            Console.WriteLine("Os arrays possuem os mesmos elementos? " + (iguais ? "Sim" : "Não"));
        }

        private void Questao78()
        {
            Queue<string> fila = new Queue<string>();
            string opcao;

            do
            {
                Console.WriteLine("Digite um nome para adicionar na fila / 'atender' para remover o próximo / 'sair' para sair:");
                opcao = Console.ReadLine();

                if (opcao == "atender")
                {
                    if (fila.Count > 0)
                        Console.WriteLine("Atendendo: " + fila.Dequeue());
                    else
                        Console.WriteLine("Fila vazia.");
                }
                else
                    fila.Enqueue(opcao);

            } while (opcao != "sair");

            Console.WriteLine("Programa encerrado.");
        }

        private void Questao79()
        {
            string[] opcoes = { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            Console.WriteLine("Escolha: Pedra, Papel ou Tesoura?");
            string escolhaUsuario = Console.ReadLine();
            string escolhaComputador = opcoes[random.Next(0, 3)];

            Console.WriteLine("Computador escolheu: " + escolhaComputador);

            if (escolhaUsuario == escolhaComputador)
                Console.WriteLine("Empate!");
            else if ((escolhaUsuario == "Pedra" && escolhaComputador == "Tesoura") ||
                     (escolhaUsuario == "Papel" && escolhaComputador == "Pedra") ||
                     (escolhaUsuario == "Tesoura" && escolhaComputador == "Papel"))
                Console.WriteLine("Você venceu!");
            else
                Console.WriteLine("Computador venceu!");
        }

        private void Questao80()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = numero.ToString().Select(digito => int.Parse(digito.ToString())).Sum();
            Console.WriteLine("A soma dos dígitos é: " + soma);
        }

        private void Questao81()
        {
            List<int> listaNumeros = new List<int>();
            Console.WriteLine("Digite números (digite 'sair' para encerrar):");

            string entrada;
            while ((entrada = Console.ReadLine()) != "sair")
            {
                if (int.TryParse(entrada, out int numero))
                {
                    listaNumeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }

            Console.WriteLine("Números pares na lista: " + string.Join(", ", listaNumeros.Where(n => n % 2 == 0)));
        }

        private void Questao82()
        {
            List<double> valores = new List<double>();
            Console.WriteLine("Digite valores (ou 'sair' para encerrar):");

            string entrada;
            while ((entrada = Console.ReadLine()) != "sair")
            {
                valores.Add(double.Parse(entrada));
            }

            if (valores.Count > 0)
            {
                double media = valores.Average();
                double maior = valores.Max();
                Console.WriteLine($"Média: {media}, Maior valor: {maior}");
            }
        }

        private void Questao83()
        {
            List<string> nomes = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o nome {i}: ");
                nomes.Add(Console.ReadLine());
            }

            nomes.Sort();
            Console.WriteLine("Nomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
        private void Questao84()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            string invertida = new string(palavra.Reverse().ToArray());

            Console.WriteLine(palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase)
                ? "A palavra é um palíndromo."
                : "A palavra não é um palíndromo.");
        }

        private void Questao85()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.Next(1, 51));
            }

            int menor = numeros.Min();
            int maior = numeros.Max();
            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));
            Console.WriteLine($"Menor: {menor}, Maior: {maior}");
        }
        public class ContaBancaria
        {
            private decimal saldo;

            public ContaBancaria(decimal saldoInicial)
            {
                saldo = saldoInicial;
                Console.WriteLine("Saldo inicial: " + saldo);
            }

            public void Depositar(decimal valor)
            {
                saldo += valor;
                Console.WriteLine("Depósito de " + valor + " realizado. Saldo atual: " + saldo);
            }

            public void Sacar(decimal valor)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine("Saque de " + valor + " realizado. Saldo atual: " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para saque.");
                }
            }
        }

        private void Questao86()
        {
            ContaBancaria conta = new ContaBancaria(1000);
            Console.WriteLine("Digite o valor para depósito:");
            decimal deposito = decimal.Parse(Console.ReadLine());
            conta.Depositar(deposito);

            Console.WriteLine("Digite o valor para saque:");
            decimal saque = decimal.Parse(Console.ReadLine());
            conta.Sacar(saque);
        }

        private void Questao87()
        {
            Console.Write("Digite o salário bruto do funcionário: ");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());
            decimal salarioLiquido = salarioBruto * 0.90m;
            Console.WriteLine("Salário líquido: " + salarioLiquido);
        }

        private void Questao88()
        {

            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine("Representação binária: " + binario);
        }

        private void Questao89()
        {

            Console.WriteLine("Digite as três notas do aluno:");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Média: " + media + (media >= 7 ? " - Aprovado" : " - Reprovado"));
        }

        private void Questao90()
        {
            int[,] matriz = new int[2, 2];
            Console.WriteLine("Por favor, insira os elementos para a matriz 2x2:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Informe o elemento na posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;
            foreach (int elemento in matriz)
            {
                soma += elemento;
            }

            Console.WriteLine($"A soma total dos elementos inseridos na matriz é: {soma}");
        }

        private void Questao91()
        {
            int[] votos = new int[3];
            string entrada;

            Console.WriteLine("Para votar, digite o número do candidato (1, 2 ou 3) ou 'fim' para encerrar a votação:");
            while ((entrada = Console.ReadLine().ToLower()) != "fim")
            {
                if (int.TryParse(entrada, out int candidato) && candidato >= 1 && candidato <= 3)
                {
                    votos[candidato - 1]++;
                }
                else
                {
                    Console.WriteLine("Voto inválido. Por favor, tente novamente.");
                }
            }

            int vencedor = Array.IndexOf(votos, votos.Max()) + 1;
            Console.WriteLine($"O candidato que venceu a votação é o número: {vencedor}, com um total de {votos.Max()} votos.");
        }

        private void Questao92()
        {
            Console.Write("Insira um número para verificar se é múltiplo de 3 e 7: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(numero % 3 == 0 && numero % 7 == 0
                ? "O número informado é múltiplo de 3 e 7."
                : "O número informado não é múltiplo de 3 e 7.");
        }

        private void Questao93()
        {
            Console.Write("Por favor, digite a coordenada X do primeiro ponto: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Agora, digite a coordenada Y do primeiro ponto: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a coordenada X do segundo ponto: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("E finalmente, digite a coordenada Y do segundo ponto: ");
            double y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"A distância calculada entre os dois pontos é: {distancia}");
        }

        private void Questao94()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numeros.Add(random.Next(1, 101));
            }

            numeros.Sort();
            Console.WriteLine("Os números gerados em ordem crescente são: " + string.Join(", ", numeros));
        }

        private void Questao95()
        {
            Dictionary<string, string> agenda = new Dictionary<string, string>();
            string opcao;

            do
            {
                Console.WriteLine("Selecione uma opção: 1 para adicionar contato, 2 para listar contatos, 3 para sair:");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número: ");
                    string numero = Console.ReadLine();
                    agenda[nome] = numero;
                    Console.WriteLine("Contato adicionado com sucesso!");
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Contatos na agenda:");
                    foreach (var contato in agenda)
                    {
                        Console.WriteLine($"Nome: {contato.Key}, Número: {contato.Value}");
                    }
                }
            } while (opcao != "3");
        }

        private void Questao96()
        {
            Console.WriteLine("Números primos entre 2 e 100:");
            for (int i = 2; i <= 100; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private void Questao97()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do número " + numero + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        private void Questao98()
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite os elementos da matriz 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maior = matriz.Cast<int>().Max();
            Console.WriteLine("O maior elemento da matriz é: " + maior);
        }

        private void Questao99()
        {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                soma += i * i;
            }

            Console.WriteLine("A soma dos quadrados de 1 até " + n + " é: " + soma);
        }

        private void Questao100()
        {
            string palavra = "Morte";
            HashSet<char> letrasAdivinhadas = new HashSet<char>();
            int tentativas = 5;

            while (tentativas > 0)
            {
                Console.Write("Coloque uma letra: ");
                char letra = Console.ReadLine()[0];

                if (palavra.Contains(letra))
                {
                    letrasAdivinhadas.Add(letra);
                    Console.WriteLine("Boa! A letra está na palavra.");
                }
                else
                {
                    tentativas--;
                    Console.WriteLine($"Incorreto, não há essa letra. Tentativas restantes: {tentativas}");
                }

                bool todasLetrasAdivinhadas = true;
                foreach (char c in palavra)
                {
                    if (letrasAdivinhadas.Contains(c))
                        Console.Write(c + " ");
                    else
                    {
                        Console.Write("_ ");
                        todasLetrasAdivinhadas = false;
                    }
                }
                Console.WriteLine();

                if (todasLetrasAdivinhadas)
                {
                    Console.WriteLine("Parabéns! Você adivinhou a palavra!");
                    break;
                }
            }

            if (tentativas == 0)
            {
                Console.WriteLine("Você perdeu! A palavra era: " + palavra);
            }
        }

    }
}

