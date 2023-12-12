# Controle de Contas de Luz e Água - Console App

## Introdução
Este é um console app desenvolvido em C# para facilitar a administração de contas de luz e água associadas a clientes. A solução é construída com Programação Orientada a Objetos (POO) e utiliza o Entity Framework Core para interação com um banco de dados MySQL.

## Estrutura do Sistema
O sistema é composto por duas entidades principais: "Cliente" e "Conta". As relações entre essas entidades são definidas da seguinte forma:

- Um "Cliente" pode ter várias "Contas" associadas a ele.
- Uma "Conta" pertence a um único "Cliente".

## Funcionalidades Principais
1. **Cadastro de Clientes e Contas:**
   - Permite a adição de novos clientes, incluindo informações como nome, endereço, etc.
   - Facilita o registro de contas de luz e água associadas a cada cliente.

2. **Consulta de Informações:**
   - Possibilita a consulta de detalhes sobre clientes, incluindo suas contas associadas.
   - Oferece a capacidade de visualizar informações específicas de uma conta.
   - Alem de relatorios sobre consumo e custo.

3. **Persistência de Dados:**
   - Utiliza o Entity Framework Core para interagir com um banco de dados MySQL.
   - Garante a persistência segura e eficiente das informações de clientes e contas.

## Requisitos do Sistema
- .NET Core SDK instalado (versão x.x.x).
- Banco de dados MySQL configurado e acessível.

## Instruções de Uso
1. Clone o repositório.
2. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
3. Abra o terminal na pasta do projeto e execute o comando `dotnet run`.

## Contribuições
Contribuições são bem-vindas! Se você encontrar problemas ou tiver sugestões, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença
Este projeto é licenciado sob a [MIT License](LICENSE).

[POO_Trabalho Prático_2023.pdf](https://github.com/Davi-OS/TrabalhoPOO/files/13642350/POO_Trabalho.Pratico_2023.pdf)
[Etapa 1 - Trabalho Prático.pdf](https://github.com/Davi-OS/TrabalhoPOO/files/13642349/Etapa.1.-.Trabalho.Pratico.pdf)
