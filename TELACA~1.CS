//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//PBL - Projeto Integrador Entre Disciplinas
//Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

//-----Alunos Envolvidos------

//Erikson Vieira Queiroz - RA: 082220021
//Enzo Brito Alves de Oliveira - RA: 082220040
//Guilherme Alve Barbosa - RA: 082220014
//Heitor Santos Ferreira - RA: 081230042
//Tainara do Nascimento Casimiro -RA: 082220011
//William Santim - RA: 082220033

//Engenharia de Computação - Terceiro Semestre - EC3

//-----Disciplinas Envolvidas-----
//Programação Orientada a Objetos | Professora Leide Vieira
//Calculo Avançado | Professor Daniel Giglio
//Física Geral e Experimental II | Professor João Lamesa
//Banco de Dados II | Professor Flávio Viotti

//Declarando bibliotecas que serão utilizadas ao decorrer do código
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//Declara o local e o nomespace no qual o código estará alocado dentro do software
namespace PPL_Main.Telas
{

    //Cria a classe de execução da tela
    public partial class TelaCadastrar : Form
    {

        //Realiza evocação das referencias contidas no código principal de execução do programa
        Program referenciaClassePrograma = new Program();

        //Realiza instanciamento inicial do visual, inicializando componente do WindowsForms
        public TelaCadastrar()
        {
            InitializeComponent();
        }
        
        //Define um caracter especial que irá mascarar os valores digitados na textBox de senha
        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            textBoxCadastrarSenhaUsuario.PasswordChar = '*';
        }

        //Cria um método que realiza a criação ou alteração da SP (Stored Procedure) que irá cadastrar novos usuários
        internal void CriaSPCadastrarUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza a abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Cria string que irá receber a SP (Stored Procedure)
                string criandoSPInclusaoDadosUsuario = @"
                
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
                
                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP (Stored Procedure) declarada
                using (SqlCommand comandoQuerySPInsereDadosUsuario = new SqlCommand(criandoSPInclusaoDadosUsuario, conexaoBancoDeDados))
                {
                    comandoQuerySPInsereDadosUsuario.ExecuteNonQuery();
                }

            }

        }

        //Cria método que categoriza e gerencia todo o cadastramento do usuário
        internal void CadastraUsuario()
        {

            //Julga se os valores digitados nas textBoxes de Nome de Usuário e de Senha de Usuário estão recebendo os valores corretos de tipo string
            if ((!string.IsNullOrEmpty(textBoxCadastrarNomeUsuario.Text)) &&
               (!string.IsNullOrEmpty(textBoxCadastrarSenhaUsuario.Text)))
            {

                //Abre laço de checagem por tentativa
                try
                {

                    //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
                    using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
                    {

                        //Realiza a abertura da conexão com o banco de dados
                        conexaoBancoDeDados.Open();

                        //Abre instancia SQL onde cria um comando em SQL utilizando a SP (Stored Procedure) 'InserirUsuario' para que a mesma seja acionada e receba os valores que serão ingeridos durante a construção da SP (Stored Procedure)
                        using (SqlCommand comandoInsereDadosTabelaUsuarios = new SqlCommand("InserirUsuario", conexaoBancoDeDados))
                        {

                            //Define que o comando aberto acima é um comando do tipo SP (Stored Procedure)
                            comandoInsereDadosTabelaUsuarios.CommandType = CommandType.StoredProcedure;

                            //Define quais valores devem ser atribuidos a SP que está associada ao comando
                            comandoInsereDadosTabelaUsuarios.Parameters.AddWithValue("@NomeUsuario", this.textBoxCadastrarNomeUsuario.Text.ToUpper()); //Define que o valor a ser considerado no parametro '@NomeUsuario' da SP deve ser o valor da textBox que recebe o nome de usuário, o mesmo converte o valor para maiusculo absoluto
                            comandoInsereDadosTabelaUsuarios.Parameters.AddWithValue("@SenhaUsuario", this.textBoxCadastrarSenhaUsuario.Text); //Define que o valor a ser considerado no parametro '@SenhaUsuario' da SP deve ser o valor da textBox que recebe a senha do usuário

                            //Executa o comando com parametro de "NonQuery", pois o mesmo se trata da evocação de uma SP
                            comandoInsereDadosTabelaUsuarios.ExecuteNonQuery();

                            //Exibe uma mensagem ao usuário por meio de uma caixa de mensagem
                            MessageBox.Show("Dados cadastrados com sucesso!");

                            //Realiza a 'limpeza' dos valores em ambas as textBoxe's existentes no WindowsForm em questão
                            textBoxCadastrarNomeUsuario.Text = "";
                            textBoxCadastrarSenhaUsuario.Text = "";

                            //...Encerra o laço de checagem por tentativa
                        }

                    }

                }

                //Inicia laço de excessão
                //Caso haja um erro na tentativa, uma exceção é aberta e recebe o valor de erro gerado naturalmente pelo SQL
                catch (SqlException ex)
                {

                    //Exibe uma mensagem ao usuário por meio de uma caixa de mensagem, relatando ao mesmo os valores dos erros
                    MessageBox.Show($"Erro SQL ({ex.Number}): {ex.Message}");

                    //Realiza a 'limpeza' dos valores em ambas as textBoxe's existentes no WindowsForm em questão
                    textBoxCadastrarNomeUsuario.Text = "";
                    textBoxCadastrarSenhaUsuario.Text = "";
                }

            }

            //Caso os valores digitados nas textBoxe's não sejam atentidos nas instancias definidas no conceito if, cria uma alternativa de execução
            else
            {

                //Exibe uma mensagem ao usuário por meio de uma caixa de manesagem
                MessageBox.Show("Os tipos de dados digitados estão incorretos, por favor, digite novamente.");

                //Realiza a 'limpeza' dos valores em ambas as textBoxe's existentes no WindowsForm em questão
                textBoxCadastrarNomeUsuario.Text = "";
                textBoxCadastrarSenhaUsuario.Text = "";

            }

        }

        //Criando método que realiza a criação ou alteração do Trigger que verifica condições especificas de preenchimento do nome de usuário
        public void CriarTriggerVerificaNomeUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza a abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Criando comando de trigger
                string scriptTriggerVerificaNomeUsuario = @"
                
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

                ";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração do Trigger declarado
                using (SqlCommand comandoCriarTriggerVerificaNomeUsuario = new SqlCommand(scriptTriggerVerificaNomeUsuario, conexaoBancoDeDados))
                {
                    comandoCriarTriggerVerificaNomeUsuario.ExecuteNonQuery();
                }
            }
        }

        //Criando método que realiza a criação ou alteração do Trigger que verifica condições especificas de preenchimento da senha de usuário
        public void CriarTriggerVerificaSenhaUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza a abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Criando comando de trigger
                string scriptTriggerVerificaSenhaUsuario = @"
                
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

                ";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração do Trigger declarado
                using (SqlCommand comandoCriarTriggerVerificaSenhaUsuario = new SqlCommand(scriptTriggerVerificaSenhaUsuario, conexaoBancoDeDados))
                {
                    comandoCriarTriggerVerificaSenhaUsuario.ExecuteNonQuery();
                }
            }
        }

        //Criando método que realiza a criação ou alteração do Trigger que verifica se um nome de usuário digitado já não existe na tabela contida no banco de dados
        public void CriarTriggerVerificaExistenciaUnicaUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza a abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Criando comando de Trigger
                string scriptTriggerVerificaExistenciaUnicaaUsuario = @"
                
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

                ";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração do Trigger declarado
                using (SqlCommand comandoCriarTriggerVerificaExistenciaUnicaUsuario = new SqlCommand(scriptTriggerVerificaExistenciaUnicaaUsuario, conexaoBancoDeDados))
                {
                    comandoCriarTriggerVerificaExistenciaUnicaUsuario.ExecuteNonQuery();
                }
            }
        }

        //Define as ações que serão realizadas após o clique do botão 'cadastrarButton'
        private void cadastrarButton_Click(object sender, EventArgs e)
        {

            //Executa o método que cria ou altera a SP (Stored Procedure) que cadastra o usuário
            CriaSPCadastrarUsuario();

            //Executa todos os métodos de Trigger para a tabela de usuários
            CriarTriggerVerificaNomeUsuario(); //Executa método que cria ou altera o trigger responsável por verificar as condições estabelecidas para o nome de usuario
            CriarTriggerVerificaSenhaUsuario(); //Executa método que cria ou altera o trigger responsável por verificar as condições estabelecidas para o senha de usuario
            CriarTriggerVerificaExistenciaUnicaUsuario(); //Executa método que cria ou altera o trigger responsável por verificar se um nome de usuario digitado já não existe na tabela do banco de dados

            //Executa o método que realiza o cadastramento do novo usuário
            CadastraUsuario();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastrar_Load(object sender, EventArgs e)
        {

        }

        //Define ações que serão realizadas após o clique do botão 'voltarButton'
        private void voltarButton_Click(object sender, EventArgs e)
        {

            //Fecha a tela do WindowsForms atual
            this.Close();
        
        }
    }
}
