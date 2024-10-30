Projeto das 100 Questões em C#

O projeto é uma aplicação de console em C# que implementa 100 questões, cada uma representada por um método separado e acessível por meio de um menu interativo.

Requisitos

  - NET SDK Certifique-se de ter o .NET SDK (5.0 ou superior) instalado.
  - Para verificar a instalação, use: dotnet --version.
  - Caso não tenha, baixe e instale o SDK em: https://dotnet.microsoft.com/download.

Como Executar o Projeto

1. Clonar o Repositório
   - Clone o repositório para seu ambiente local usando:
     git clone <URL_DO_REPOSITORIO>
     cd <NOME_DO_DIRETORIO>

2. Compilar e Executar
   - No diretório do projeto, execute os seguintes comandos:
     dotnet build
     dotnet run

3. Navegação pelo Menu
   - Após iniciar, um menu permitirá a escolha de qualquer uma das 100 questões.
   - Digite o número da questão e pressione ENTER.
   - O programa executará a questão escolhida e, ao final, retornará ao menu principal.

Estrutura do Projeto

O projeto está estruturado em duas classes principais:

- Classe MENU Controla a navegação pelo menu e permite selecionar uma questão.
- Classe QUESTOES: Contém os métodos Questao1 até Questao100, cada um implementando a lógica de uma questão.

Exemplo

Para verificar uma questão específica, como a Questão 77 (comparação de dois arrays):

1. No menu, digite 77 e pressione **Enter**.
2. Insira os dados conforme solicitado.
3. O resultado será exibido, e você poderá escolher outra questão ou sair do programa.