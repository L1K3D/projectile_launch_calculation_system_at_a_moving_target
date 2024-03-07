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

--Stored Procedure que insere usuário novo na tabela
--Cria Stored Procedure ou altera a mesma, definindo um nome para ela
CREATE OR ALTER PROCEDURE InserirUsuario
    
    --Define o nome dos valores e a tipagem de dado que irão compor a SP
    @NomeUsuario VARCHAR(25),
    @SenhaUsuario VARCHAR(25)

AS

BEGIN
    
    --Declara uma variavel mutável e adaptativa que irá determinar um ID de usuário, o dado é definido como inteiro e recebe o próximo valor sequencial do último 
    DECLARE @ProximoID INT;
    
    SELECT @ProximoID = ISNULL(MAX(id_usuario), 0) + 1 FROM usuarios;

    --Realiza a inserção dos novos dados obtidos na tabela já existente, declarando os valores que devem ser preenchidos e os campos que receberão esses valores
    INSERT INTO usuarios (id_usuario, nome_usuario, senha_usuario)

    VALUES (@ProximoID, @NomeUsuario, @SenhaUsuario)

END;

-----------------------------------------------------------------------------------

--Cria Stored Procedure que verifica a existência do usuario
 --Cria Stored Procedure ou altera a mesma, definindo um nome para ela
CREATE OR ALTER PROCEDURE VerificaUsuario

    --Define o nome dos valores e a tipagem de dado que irão compor a SP
    @NomeUsuario VARCHAR(25),
    @SenhaUsuario VARCHAR(25)

AS

BEGIN

    --Declarando variavel de contagem que recebe uma tipagem de dado de número inteiro
    DECLARE @Contagem INT;
    
    --É realizada a contagem de usuários com o mesmo nome de usuario e senha digitada nas textBoxe's refereridas no visual do WindowsForms
    SELECT @Contagem = COUNT(*) 
    FROM usuarios
    WHERE nome_usuario = @NomeUsuario
    AND senha_usuario = @SenhaUsuario;
    
    --Caso a variavel de contagem seja maior que zero, significa que existe um cadastro para os valores de nome de usuario e senha digitados nas textBoxe's referidas no visual do WindowsForms
    IF @Contagem > 0
    BEGIN
    
        --Retorna o nome de usuário encontrado com os valores fornecidos
        SELECT nome_usuario
        FROM usuarios
        WHERE nome_usuario = @NomeUsuario;

    END

    ELSE
    BEGIN
         
         --Caso não exista nenhum usuario cadastrado com os valores de nome de usuario e senha fornecidos, retorna um 'N/A' como nome de usuario. Esse valor será transformado ao decorrer do código
         SELECT 'N/A' AS nome_usuario

    END

END;

------------------------------------------------------------------------------

--Stored Procedure que captura o ID do usuario
--Cria Stored Procedure ou altera a mesma, definindo um nome para ela
CREATE OR ALTER PROCEDURE CapturaIDUsuarioAutenticado
    
    --Define o nome dos valores e a tipagem de dado que irão compor a SP
    @NomeUsuario VARCHAR(25),
    @SenhaUsuario VARCHAR(25)

AS

BEGIN

    --Declarando variavel de contagem que recebe uma tipagem de dado de número inteiro
    DECLARE @Contagem INT;
    
    --É realizada a contagem de usuários com o mesmo nome de usuario e senha digitada nas textBoxe's refereridas no visual do WindowsForms
    SELECT @Contagem = COUNT(*) 
    FROM usuarios
    WHERE nome_usuario = @NomeUsuario
    AND senha_usuario = @SenhaUsuario;
    
    --Caso a variavel de contagem seja maior que zero, significa que existe um cadastro para os valores de nome de usuario e senha digitados nas textBoxe's referidas no visual do WindowsForms
    IF @Contagem > 0
    BEGIN
        
        --Retorna o ID de usuario encontrado com os valores fornecidos
        SELECT id_usuario
        FROM usuarios
        WHERE nome_usuario = @NomeUsuario;

    END

    ELSE
    BEGIN
        
         --Caso não exista nenhum usuario cadastrado com os valores de nome de usuario e senha fornecidos, retorna um '0' como ID de usuario. Esse valor será transformado ao decorrer do código
         SELECT '0' AS id_usuario

    END

END;

---------------------------------------------------------------------------------------------------

--Stored Procedure que insere dados na tabela de projetil
--Declara nome e estado de criação ou alteração da SP
CREATE OR ALTER PROCEDURE InserirProjetil
    
    --Declara variaveis e tipagem de dados dos parametros da SP
    @AnguloTrajetoriaProjetil DECIMAL(10,2),
    @VelocidadeInicial1Projetil DECIMAL(10,2),
    @VelocidadeInicial2Projetil DECIMAL(10,2),
    @VelocidadeUsadaProjetil DECIMAL(10,2),
    @TempoVooProjetil DECIMAL(10,2),
    @TipoMovimentoProjetil VARCHAR(30),
    @ExistenciaResolucaoRealAnguloFornecido VARCHAR(3)

AS

BEGIN
    
    --Declara variavel que irá receber um próximo ID de projetil, verificando sempre qual o ID máximo e encontrando o próximo número
    DECLARE @ProximoID INT;

    SELECT @ProximoID = ISNULL(MAX(id_projetil), 0) + 1 FROM projetil;
    
    --Declarando os campos que receberão inserção de dados e quais valores serão inseridos nos respectivos campos
    INSERT INTO projetil (id_projetil, angulo_trajetoria_projetil, velocidade_inicial1_projetil, velocidade_inicial2_projetil, velocidade_usada_projetil, tempo_de_voo_projetil, tipo_de_movimento_projetil, existencia_resolucao_real_angulo_fornecido)

    VALUES (@ProximoID, @AnguloTrajetoriaProjetil, @VelocidadeInicial1Projetil, @VelocidadeInicial2Projetil, @VelocidadeUsadaProjetil, @TempoVooProjetil, @TipoMovimentoProjetil, @ExistenciaResolucaoRealAnguloFornecido);

END;

---------------------------------------------------------------------------------------------------

--Stored Procedure que insere dados na tabela de alvo
--Declara nome e estado de criação ou alterãção da SP
CREATE OR ALTER PROCEDURE InserirAlvo

    --Declara os parametros e suas tipagem de dados 
    @AlturaInicialAlvo DECIMAL(10,2),
    @DistanciaCanhaoAlvo DECIMAL(10,2),
    @VelocidadeInicialAlvo DECIMAL(10,2),
    @AnguloMaximoAcertoAlvo DECIMAL(10,2),
    @TempoAteAtingirSoloAlvo DECIMAL(10,2)

AS

BEGIN

    --Declara variavel que irá receber um próximo ID de projetil, verificando sempre qual o ID máximo e encontrando o próximo número
    DECLARE @ProximoID INT;

    SELECT @ProximoID = ISNULL(MAX(id_alvo), 0) + 1 FROM alvo;
    
    --Declarando os campos que receberão inserção de dados e quais valores serão inseridos nos respectivos campos
    INSERT INTO alvo (id_alvo, altura_inicial_alvo, distancia_canhao_alvo, velocidade_inicial_alvo, angulo_maximo_acerto_alvo, tempo_ate_atingir_solo_alvo)

    VALUES (@ProximoID, @AlturaInicialAlvo, @DistanciaCanhaoAlvo, @VelocidadeInicialAlvo, @AnguloMaximoAcertoAlvo, @TempoAteAtingirSoloAlvo);

END;

---------------------------------------------------------------------------------------------------

--Stored Procedure que realiza a inserção de novos dados na tabela de simulação
--Declarando nome e estado de criação ou alteração da SP
CREATE OR ALTER PROCEDURE InserirSimulacao
    
    --Declarando parametros da SP e suas tipagem de dados
    @AnguloTrajetoriaProjetil DECIMAL(10,2),
    @VelocidadeInicial1Projetil DECIMAL(10,2),
    @VelocidadeInicial2Projetil DECIMAL(10,2),
    @VelocidadeUsadaProjetil DECIMAL(10,2),
    @TempoVooProjetil DECIMAL(10,2),
    @TipoMovimentoProjetil VARCHAR(30),
    @ExistenciaResolucaoRealAnguloFornecido VARCHAR(3),
    @AlturaInicialAlvo DECIMAL(10,2),
    @DistanciaDoCanhaoAlvo DECIMAL(10,2),
    @VelocidadeInicialAlvo DECIMAL(10,2),
    @AnguloMaximoAcertoAlvo DECIMAL(10,2),
    @TempoAteAtingrSoloAlvo DECIMAL(10,2)

AS

BEGIN

    --Declarando variaveis e suas tipagem de dados
    DECLARE @ProximoID INT;
    DECLARE @IDProjetil INT;
    DECLARE @IDAlvo INT;
    
    --Declarando o valor que será recebido pela variavel 'ProximoID'. Essa variavel seleciona o próximo ID de simulação, selecionando o número máximo disponível na tabela e adiciona 1 (um)
    SELECT @ProximoID = ISNULL(MAX(id_simulacao), 0) + 1 FROM simulacoes;
    
    --Declarando o valor que será recebido pela variavel 'IDProjetil'. Essa variavel seleciona o ID máximo do projetil
    SELECT @IDProjetil = MAX(id_projetil) FROM projetil;
    
    --Declarando o valor que será recebido pela variavel 'IDAlvo'. Essa variavel seleciona o ID máximo do alvo
    SELECT @IDAlvo = MAX(id_alvo) FROM alvo;

    --Define os campos da tabela que irão receber os valores e quais parametros da SP irão ser incluidos nos campos referenciados
    INSERT INTO simulacoes (id_simulacao, 
                            id_projetil, 
                            id_alvo,
                            angulo_trajetoria_projetil,
                            velocidade_inicial1_projetil, 
                            velocidade_inicial2_projetil, 
                            velocidade_usada_projetil, 
                            tempo_de_voo_projetil, 
                            tipo_movimento_projetil, 
                            existencia_resolucao_real_angulo_fornecido,
                            altura_inicial_alvo, 
                            distancia_canhao_alvo, 
                            velocidade_inicial_alvo, 
                            angulo_maximo_acerto_alvo, 
                            tempo_ate_atingir_solo_alvo)
    
    VALUES (@ProximoID, 
            @IDProjetil, 
            @IDAlvo,
            @AnguloTrajetoriaProjetil,
            @VelocidadeInicial1Projetil, 
            @VelocidadeInicial2Projetil, 
            @VelocidadeUsadaProjetil, 
            @TempoVooProjetil, 
            @TipoMovimentoProjetil, 
            @ExistenciaResolucaoRealAnguloFornecido,
            @AlturaInicialAlvo, 
            @DistanciaDoCanhaoAlvo, 
            @VelocidadeInicialAlvo, 
            @AnguloMaximoAcertoAlvo, 
            @TempoAteAtingrSoloAlvo);
END