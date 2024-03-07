/*

CEFSA - Centro Educacional da Fundação Salvador Arena
FESA - Faculdade Engenheiro Salvador Arena
PBL - Projeto Integrador Entre Disciplinas
Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

-----Alunos Envolvidos------

Erikson Vieira Queiroz - RA: 082220021
Enzo Brito Alves de Oliveira - RA: 082220040
Guilherme Alve Barbosa - RA: 082220014
Heitor Santos Ferreira - RA: 081230042
Tainara do Nascimento Casimiro - RA: 082220011
William Santim - RA: 082220033

Engenharia de Computação - Terceiro Semestre - EC3

-----Disciplinas Envolvidas-----
Programação Orientada a Objetos | Professora Leide Vieira
Calculo Avançado | Professor Daniel Giglio
Física Geral e Experimental II | Professor João Lamesa
Banco de Dados II | Professor Flávio Viotti

*/

--Cria trigger de verificação do nome de usuário inserido na tabela de usuário
--Define criação ou alteração do trigger juntamente com o seu nome e sua determinação de alteração ou circunstância de ativação. Esse trigger é alterado após um INSERT INTO ou um UPDATE
CREATE OR ALTER TRIGGER VerificaNomeUsuario
ON usuarios
AFTER INSERT, UPDATE
AS
BEGIN

    --Declarando uma váriavel de mensagem de erro que irá receber o número máximo de caracteres permitido no SQLServer Local Statement
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);

    --Realizando a verificação da condição para gerar um erro. No caso, não é permitido que o usuário insira um nome de usuário que contenha números, caracteres especiais ou 'ç'
    --A verificação das condições é realizada após uma tentativa de inserção de novos dados na tabela
    IF EXISTS (

        SELECT 1
        FROM inserted
        WHERE PATINDEX('%[^a-zA-Z ]%', nome_usuario) > 0 OR
        nome_usuario LIKE '%[0-9]%' OR
        nome_usuario LIKE '%[çÇ]%'

    )
        
        --Caso a verificação retorne um valor verdadeiro, no caso, caso o usuário digite um nome de usuário que contenha números, caracteres especiais ou 'ç', a variavel de mensagem de erro declarada anteriormente recebe um valor númerico e genêrico de gravação em sistema (50000 no caso) e recebe um valor de mensagem para ser retornado
        BEGIN
            SET @ErrorMessage = 'O nome de usuário não atende aos requisitos solicitados';
            THROW 50000, @ErrorMessage, 1;
            ROLLBACK;
        END
END;

------------------------------------------------------------------------------------------

--Trigger que verifica a senha digitada pelo usuario
--Define criação ou alteração do trigger juntamente com o seu nome e sua determinação de alteração ou circunstância de ativação. Esse trigger é alterado após um INSERT INTO ou um UPDATE
CREATE OR ALTER TRIGGER VerificaSenhaUsuario
ON usuarios
AFTER INSERT, UPDATE
AS
BEGIN

    --Declarando uma váriavel de mensagem de erro que irá receber o número máximo de caracteres permitido no SQLServer Local Statement
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    
    --Realizando a verificação da condição para gerar um erro. No caso, não é permitido que o usuário insira uma senha de usuário caracteres especiais ou 'ç'
    --A verificação das condições é realizada após uma tentativa de inserção de novos dados na tabela
    IF EXISTS (

        SELECT 1
        FROM inserted
        WHERE PATINDEX('%[^a-zA-Z0-9 ]%', senha_usuario) > 0 OR
        senha_usuario LIKE '%[çÇ]%'

    )
        --Caso a verificação retorne um valor verdadeiro, no caso, caso o usuário digite uma senha que contenha caracteres especiais ou 'ç', a variavel de mensagem de erro declarada anteriormente recebe um valor númerico e genêrico de gravação em sistema (60000 no caso) e recebe um valor de mensagem para ser retornado
        BEGIN
            SET @ErrorMessage = 'A senha de usuário não atende aos requisitos solicitados';
            THROW 60000, @ErrorMessage, 1;
            ROLLBACK;
        END
END;

------------------------------------------------------------------------------------------

--Cria trigger que verifica a existência do usuário para que não haja duplicidade de nomes de usuário
--Define criação ou alteração do trigger juntamente com o seu nome e sua determinação de alteração ou circunstância de ativação. Esse trigger é alterado após um INSERT INTO ou um UPDATE
CREATE OR ALTER TRIGGER VerificaExistenciaUnicaUsuario
ON usuarios
AFTER INSERT, UPDATE
AS
BEGIN

    --Declarando uma váriavel de mensagem de erro que irá receber o número máximo de caracteres permitido no SQLServer Local Statement
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    
    --Realizando a verificação da condição para gerar um erro. No caso, não é perimitido que o usuario insira um nome de usuario que já esteja cadastrado na tabela do banco de dados
    --A verificação das condições é realizada após uma tentativa de inserção de novos dados na tabela
    IF EXISTS (

        SELECT 1
        FROM inserted i
        JOIN usuarios u ON i.nome_usuario = u.nome_usuario
        WHERE i.id_usuario IS NULL OR i.id_usuario <> u.id_usuario
    )
    
    --Caso a verificação retorne um valor verdadeiro, no caso, caso o usuário digite um nome de usuario que já exista na tabela do banco de dados, a variavel de mensagem de erro declarada anteriormente recebe um valor númerico e genêrico de gravação em sistema (70000 no caso) e recebe um valor de mensagem para ser retornado
    BEGIN
        SET @ErrorMessage = 'O nome de usuário já está em uso. Escolha outro.';
        THROW 70000, @ErrorMessage, 1;
        ROLLBACK;
    END
END;