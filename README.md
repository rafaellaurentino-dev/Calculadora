# 🧮 Calculadora Didática em C#

Uma calculadora interativa em modo console desenvolvida em C# utilizando o paradigma **Procedural**. Este projeto foi criado com fins estritamente didáticos para consolidar os fundamentos de lógica de programação, estruturas de repetição, controle de fluxo e manipulação de tipos primitivos, sem a introdução de objetos ou classes de domínio.

---

## 🚀 Funcionalidades

O sistema conta com um menu interativo e validação robusta contra erros de digitação (letras e campos vazios) através do método `int.TryParse`.

*   **➕ Soma:** Adição entre dois números inteiros.
*   **➖ Subtração:** Subtração entre dois números inteiros.
*   **✖️ Multiplicação:** Produto entre dois números inteiros.
*   **➗ Divisão Segura:** Divisão com retorno em ponto flutuante (`double`). Possui validação inteligente que impede a divisão por zero e obriga o usuário a digitar um novo divisor sem resetar o primeiro número.
*   **🔲 Potenciação:** Cálculo de potência utilizando a biblioteca nativa `Math.Pow`.
*   **🧬 Raiz Genérica:** Permite calcular qualquer tipo de raiz (quadrada, cúbica, etc.) elevando a base ao inverso do índice informado, com correção para divisão inteira (`1.0 / num2`).


---

## 💻 Como Executar o Projeto

### Pré-requisitos
*   [.NET SDK (versão 10.0+)](https://microsoft.com) instalado em sua máquina.

### Passo a Passo
1. Clone este repositório para o seu computador:
   ```bash
   git clone https://github.com/rafaellaurentino-dev/Calculadora
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd Calculadora
   ```
3. Execute o comando de inicialização do .NET:
   ```bash
   dotnet run
   ```

## 📁 Executável

O projeeto já está copilado e com um atalho .exe para testes.

1. Acesse a pasta do projeto.
    └── 📂 Calculadora
           └── 🚀 Calculadora.exe

2. Execute o programa Calculadora.exe.

---

## 📁 Estrutura do Executável e Ícone Personalizado

O projeto já está configurado para gerar o executável com um ícone customizado (`calculadora.ico`). Após realizar a compilação do projeto com o comando `dotnet build` ou através da sua IDE, o arquivo executável gerado estará localizado na seguinte estrutura de pastas:
```text
📂 bin
 └── 📂 Debug
      └── 📂 net10.0
           └── 🚀 Calculadora.exe
```

---

## ✒️ Licença

Este projeto é de uso livre para fins de estudo e aprendizado. Sinta-se à vontade para clonar, modificar e propor melhorias!
