# README: Console App com Conexão ao SQLite

Este projeto é um aplicativo de console simples em C# que se conecta a um banco de dados SQLite e executa uma consulta básica para listar informações da tabela `Album`.

## Requisitos

- .NET SDK 8.0 ou superior
- SQLite instalado

## Instalação do SQLite

### Windows

1. Baixe o SQLite no [site oficial](https://www.sqlite.org/download.html).
2. Escolha a versão pré-compilada para Windows (geralmente o arquivo ZIP).
3. Extraia o conteúdo do ZIP e coloque os arquivos em um diretório acessível pelo `PATH` do sistema, como `C:\sqlite`.
4. Para testar a instalação, abra o Prompt de Comando e digite:
   ```
   sqlite3 --version
   ```

### Linux (Debian/Ubuntu)

1. Abra o terminal e execute o seguinte comando para instalar o SQLite:
   ```bash
   sudo apt update
   sudo apt install sqlite3
   ```
2. Verifique se a instalação foi bem-sucedida digitando:
   ```bash
   sqlite3 --version
   ```

### macOS

1. Abra o terminal e instale o SQLite usando o Homebrew:
   ```bash
   brew update
   brew install sqlite
   ```
2. Verifique a instalação com:
   ```bash
   sqlite3 --version
   ```

## Executando o Projeto

1. Clone este repositório ou baixe os arquivos do projeto.
2. Navegue até o diretório do projeto no terminal.
3. Execute o comando abaixo para restaurar as dependências e compilar o projeto:
   ```bash
   dotnet build
   ```
4. Para executar o aplicativo, use o comando:
   ```bash
   dotnet run
   ```

## Observações

- O arquivo `Chinook.sqlite` deve estar localizado no mesmo diretório do aplicativo para que a conexão funcione corretamente.
- Certifique-se de que o SQLite esteja instalado e configurado no `PATH` do sistema para evitar problemas de execução.

## Licença

Este projeto é livre para uso e modificação. Sinta-se à vontade para contribuir ou adaptar o código conforme necessário.

