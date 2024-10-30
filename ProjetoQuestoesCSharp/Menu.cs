using System;
using System.Collections.Generic;

namespace ProjetoQuestoesCSharp
{
    public class Menu
    {
        private Dictionary<int, string> descricoesQuestoes = new Dictionary<int, string>
{
    { 1, "Classe Produto com Nome e Preço para gerenciar produtos." },
    { 2, "Exibe valores de um objeto Produto." },
    { 3, "Calcula e exibe a soma de dois números inteiros." },
    { 4, "Verifica se um número é par ou ímpar." },
    { 5, "Converte metros para centímetros." },
    { 6, "Verifica se uma pessoa é maior de idade com base na idade." },
    { 7, "Calcula a área de um círculo dado o raio." },
    { 8, "Exibe a tabuada de um número fornecido pelo usuário." },
    { 9, "Soma todos os números inteiros de 1 a N." },
    { 10, "Converte temperatura de Celsius para Fahrenheit." },
    { 11, "Verifica se uma string é vazia ou nula." },
    { 12, "Exibe todos os números pares entre 1 e 50." },
    { 13, "Encontra o maior entre três números fornecidos." },
    { 14, "Inverte uma string e exibe o resultado." },
    { 15, "Determina se uma pessoa pode votar com base no ano de nascimento." },
    { 16, "Verifica se um número é positivo ou negativo." },
    { 17, "Calcula a média de três notas e exibe se o aluno está aprovado." },
    { 18, "Conta o número de letras 'a' em uma string." },
    { 19, "Exibe números de 1 a 10 em ordem decrescente." },
    { 20, "Calcula a soma dos quadrados de números de 1 a N." },
    { 21, "Exibe uma mensagem de boas-vindas com nome e idade." },
    { 22, "Mostra o dobro e triplo de um número fornecido." },
    { 23, "Retorna o último caractere de uma string." },
    { 24, "Converte horas em segundos." },
    { 25, "Verifica se um número é divisível por 3 e por 5." },
    { 26, "Ordena três números fornecidos." },
    { 27, "Calcula o fatorial de um número." },
    { 28, "Classe Aluno com Nome e Nota; exibe informações do aluno." },
    { 29, "Calcula a média de uma lista de números." },
    { 30, "Verifica se uma palavra é um palíndromo." },
    { 31, "Encontra o menor número em um array." },
    { 32, "Multiplica elementos de um array por um valor fornecido." },
    { 33, "Retorna a soma dos números ímpares em um array." },
    { 34, "Classe Carro com propriedades Marca e Ano." },
    { 35, "Verifica se um ano é bissexto." },
    { 36, "Exibe os primeiros 10 números da sequência de Fibonacci." },
    { 37, "Substitui espaços em uma string por '_'." },
    { 38, "Retorna o índice do maior elemento de um array." },
    { 39, "Calcula o MDC entre dois números." },
    { 40, "Conta o número de vogais em uma string." },
    { 41, "Converte um número decimal para binário." },
    { 42, "Exibe um número em sua representação por extenso." },
    { 43, "Simula o lançamento de um dado 100 vezes e exibe a frequência." },
    { 44, "Calcula o IMC e exibe a categoria correspondente." },
    { 45, "Encontra o segundo maior número em um array." },
    { 46, "Inverte os elementos de um array." },
    { 47, "Soma duas matrizes 2x2." },
    { 48, "Exibe o dia da semana correspondente a uma data." },
    { 49, "Verifica se uma string contém apenas letras e números." },
    { 50, "Calcula uma potência sem usar Math.Pow()." },
    { 51, "Verifica se uma matriz é simétrica." },
    { 52, "Ordena uma lista de nomes em ordem alfabética." },
    { 53, "Encontra o elemento mais frequente em um array." },
    { 54, "Calcula o valor absoluto sem usar Math.Abs()." },
    { 55, "Implementa o algoritmo de busca linear." },
    { 56, "Simula um cronômetro simples." },
    { 57, "Conta o número de palavras em uma string." },
    { 58, "Classe Pessoa com método Falar() para exibir uma mensagem." },
    { 59, "Retorna a interseção entre dois arrays." },
    { 60, "Converte uma string para maiúsculas e minúsculas alternadas." },
    { 61, "Conta o número de caracteres únicos em uma string." },
    { 62, "Exibe os números primos até um valor fornecido." },
    { 63, "Verifica se um número é perfeito." },
    { 64, "Exibe os divisores de um número." },
    { 65, "Calcula a transposta de uma matriz." },
    { 66, "Exibe o horário atual continuamente." },
    { 67, "Simula uma calculadora simples para operações básicas." },
    { 68, "Converte valores monetários para extenso." },
    { 69, "Calcula a média ponderada de notas." },
    { 70, "Simula um caixa eletrônico para saques." },
    { 71, "Verifica se dois arrays possuem os mesmos elementos na mesma ordem." },
    { 72, "Gera uma senha aleatória com letras e números." },
    { 73, "Exibe uma tabela de multiplicação." },
    { 74, "Calcula a área de um triângulo com base em três lados." },
    { 75, "Gera números aleatórios únicos entre 1 e N." },
    { 76, "Jogo de 'Adivinhe o Número' com dicas de maior ou menor." },
    { 77, "Verifica se dois arrays possuem os mesmos elementos, independentemente da ordem." },
    { 78, "Simula uma fila de atendimento usando List<T>." },
    { 79, "Jogo de 'Pedra, Papel e Tesoura' contra o computador." },
    { 80, "Calcula a soma dos dígitos de um número fornecido." },
    { 81, "Exibe números pares de uma lista fornecida." },
    { 82, "Exibe a média e o maior valor de uma lista de valores." },
    { 83, "Armazena 10 nomes e os exibe em ordem alfabética." },
    { 84, "Verifica se uma string é um palíndromo." },
    { 85, "Gera 10 números aleatórios e exibe o menor e o maior." },
    { 86, "Classe ContaBancaria com métodos de depósito, saque e saldo." },
    { 87, "Calcula o salário líquido com desconto de 10%." },
    { 88, "Converte um número decimal para binário." },
    { 89, "Verifica se um aluno está aprovado com base na média de três notas." },
    { 90, "Calcula a soma dos elementos de uma matriz 2x2." },
    { 91, "Simula uma votação com três candidatos e exibe o vencedor." },
    { 92, "Verifica se um número é múltiplo de 3 e 7." },
    { 93, "Calcula a distância entre dois pontos no plano cartesiano." },
    { 94, "Gera e exibe cinco números aleatórios em ordem crescente." },
    { 95, "Agenda de contatos que permite adicionar e listar contatos." },
    { 96, "Exibe todos os números primos entre 1 e 100." },
    { 97, "Exibe a tabuada de multiplicação de um número até 10." },
    { 98, "Retorna o maior número em uma matriz 3x3." },
    { 99, "Calcula a soma dos quadrados dos números de 1 a N." },
    { 100, "Jogo de 'Forca' onde o usuário tenta adivinhar uma palavra." }
};


        public void ExibirMenu()
        {
            Questoes questoes = new Questoes();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("---------------- Menu ----------------");
                Console.WriteLine("Digite o número da questão:");
                Console.WriteLine("Nível Básico: 1 - 25");
                Console.WriteLine("Nível Intermediário: 26 - 50");
                Console.WriteLine("Nível Intermediário-Avançado: 51 - 75");
                Console.WriteLine("Nível Avançado: 76 - 100");
                Console.WriteLine("Sair: 0");
                Console.WriteLine("");

                if (int.TryParse(Console.ReadLine(), out int questao) && questao >= 0 && questao <= 100)
                {
                    if (questao == 0)
                    {
                        continuar = false;
                        Console.WriteLine("Adiós!");
                    }
                    else
                    {
                        if (descricoesQuestoes.ContainsKey(questao))
                        {
                            Console.WriteLine($"\nQuestão {questao}: {descricoesQuestoes[questao]}");
                            questoes.ExecutarQuestao(questao);
                        }
                        else
                        {
                            Console.WriteLine("Questão não encontrada.");
                        }

                        Console.WriteLine("\nPressione qualquer tecla para voltar para o menu.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Coloque um número válido.");
                }
            }
        }
    }
}

