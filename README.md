# NetCoreMvcDocker
Este projeto desenvolvido em .Net 6 tem o intuito de fornecer uma aplicação template de projeto Net Core MVC.

LIBRARIES
-----------------
Foram utilizados para este projeto os seguintes recursos:

- docker
- docker-compose
- EntityFrameworkCore (6.0.6)
- Swagger (1.0.0)

PATTERN
------------------
O pattern utilizado para este projeto foi padrão MVC

ENVIRONMENTS
------------------
O arquivo ```appsettings.json``` contém a string de conexão com o banco dentro do container:

INSTRUÇÕES
---------------------
Para iniciar subir o projeto basta rodar o comando:
```
docker-compose up --build -o
```
O comando build é importante para rodar as migrations.

DEBUG
--------------------
Caso queira executar em debug, é necessário subir o container do SQL separado. Examplo de comando:
```
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pass#2022" -p 1450:1433 --name sqlserverdb -d mcr.microsoft.com/mssql/server
```
Depois basta acessar o arquivo ```appsettings.json``` e informar os dados de conexão (usuário e senha), e subir o app via Kestrel ou IISExpress.
