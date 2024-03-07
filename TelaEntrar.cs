//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//PBL - Projeto Integrador Entre Disciplinas
//Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

//-----Alunos Envolvidos------

//Erikson Vieira Queiroz - RA: 082220021
//Enzo Brito Alves de Oliveira - RA: 082220040
//Guilherme Alve Barbosa - RA: 082220014
//Heitor Santos Ferreira - RA: 081230042
//Tainara do Nascimento Casimiro - RA: 082220011
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

//Decalarando o local e namespace no qual o código está alocado
namespace PPL_Main.Telas
{

    //Cria a classe de execução da tela
    public partial class TelaEntrar : Form
    {

        //Realiza evocação das referencias contidas no código principal de execução do programa
        Program referenciaClassePrograma = new Program();

        //Cria duas variaveis de nível publico que serão usadas no decorrer do código
        public string armazenaIDUsuarioString; //Declara variavel do tipo 'string' que armazena o ID do usuário autenticado
        public int armazenaIDUsuarioInt; //Declarada variavel do tipo 'int' que armazena o ID do usuário autenticado

        //Cria um instanciamento inicial que inicializa a tela/Visual do WindowsForms
        public TelaEntrar()
        {
            InitializeComponent();
        }

        //Cria um método que realiza a criação ou alteração da SP (Stored Procedure) que irá verificar a existência do nome e senha de usuario digitados nas textBoxe's presentes no WindowsForms atual
        internal void CriaSPVerificaUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Cria SP (Stored Procedure)
                string criandoSPVerificacaoUsuario = @"
                
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
                
                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP (Stored Procedure) declarada
                using (SqlCommand comandoQuerySPVerificaDadosUsuario = new SqlCommand(criandoSPVerificacaoUsuario, conexaoBancoDeDados))
                {
                    comandoQuerySPVerificaDadosUsuario.ExecuteNonQuery();
                }

            }

        }

        //Cria um método que realiza a criação ou alteração da SP (Stored Procedure) que irá verificar a existência do nome e senha de usuario digitados nas textBoxe's presentes no WindowsForms atual, capturando somente o ID do usuario
        internal void CriaSPCapturaIDUsuarioAutenticado()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Cria SP (Stored Procedure)
                string criandoSPCapturaIDUsuario = @"

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
                
                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP (Stored Procedure) declarada
                using (SqlCommand comandoQuerySPCapturaIDUsuario = new SqlCommand(criandoSPCapturaIDUsuario, conexaoBancoDeDados))
                {
                    comandoQuerySPCapturaIDUsuario.ExecuteNonQuery();
                }

            }

        }

        //Criando método que realiza a autenticação do usuario
        public void AutenticarUsuario()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Realiza a abertura da conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Realiza a criação de um instanciamento de comando de SP (Stored Procedure), utilizando a SP 'VerificaUsuario'
                using (SqlCommand comandoAutenticarUsuario = new SqlCommand("VerificaUsuario", conexaoBancoDeDados))
                {

                    //Define o comando como um evocador de Stored Procedure
                    comandoAutenticarUsuario.CommandType = CommandType.StoredProcedure;

                    //Atribui os valores que irão preencher os parametros declarados na SP
                    comandoAutenticarUsuario.Parameters.AddWithValue("@NomeUSuario", textBoxEntrarNomeUsuario.Text.ToUpper()); //Declara que o parametro da SP de "@NomeUSuario" irá receber o valor contido na textBox que armazena o nome de usuario, convertendo o valor digitado para todas as letras sendo em maiuscula
                    comandoAutenticarUsuario.Parameters.AddWithValue("@SenhaUsuario", textBoxEntrarSenhaUsuario.Text); //Declara que o parametro da SP irá de "@SenhaUsuario" irá receber o valor contido na textBox que armazena a senha de usuario

                    //Declara uma variavel do tipo 'var', ou seja, uma variavel escaneadora de sistema que irá executar o comando de atribuição de valores a SP em questão. A variavel irá armazenar o valor retornado pela SP
                    var resultadoAutenticacao = comandoAutenticarUsuario.ExecuteScalar();

                    //Realizando verificação. Caso o valor da variavel de 'resultadoAutenticacao' seja diferente de vazio e seja diferente do valor 'N/A', irá executar as linhas de comando declaradas dentro do laço de verificação
                    if ((resultadoAutenticacao != null) &&
                       (resultadoAutenticacao.ToString() != "N/A"))
                    {

                        //Realiza a criação de um instanciamento de comando de SP (Stored Procedure), utilizando a SP 'CapturaIDUsuarioAutenticado'
                        using (SqlCommand comandoCapturaIDUsuario = new SqlCommand("CapturaIDUsuarioAutenticado", conexaoBancoDeDados))
                        {

                            //Define o comando como um evocador de Stored Procedure
                            comandoCapturaIDUsuario.CommandType = CommandType.StoredProcedure;

                            //Atribui os valores que irão preencher os parametros declarados na SP
                            comandoCapturaIDUsuario.Parameters.AddWithValue("@NomeUSuario", textBoxEntrarNomeUsuario.Text.ToUpper()); //Declara que o parametro da SP de "@NomeUSuario" irá receber o valor contido na textBox que armazena o nome de usuario, convertendo o valor digitado para todas as letras sendo em maiuscula
                            comandoCapturaIDUsuario.Parameters.AddWithValue("@SenhaUsuario", textBoxEntrarSenhaUsuario.Text); //Declara que o parametro da SP irá de "@SenhaUsuario" irá receber o valor contido na textBox que armazena a senha de usuario

                            //Declara uma variavel do tipo 'var', ou seja, uma variavel escaneadora de sistema que irá executar o comando de atribuição de valores a SP em questão. A variavel irá armazenar o valor retornado pela SP
                            var resultadoID = comandoCapturaIDUsuario.ExecuteScalar();

                            //Realiza conversões de tipagem de dado e formatação do valor contido na variavel 'resultadoID'
                            armazenaIDUsuarioString = resultadoID.ToString(); //Converte o valor da variavel para 'string' em modelo de pura atribuição e atribui esse valor a variavel do tipo 'string' com o nome de 'armazenaIDUsuarioString'
                            armazenaIDUsuarioInt = int.Parse(armazenaIDUsuarioString); //Converte o valor da variavel 'armazenaIDUsuarioString' em 'int' e atribui esse valor a variavel 'armazenaIDUsuarioInt'

                        }

                        //Caso todas as verificações sejam realizadas com valor de verdade (True) e sejam executadas com sucesso, retorna uma caixa de mensagem dando boas vindas ao usuario autenticado, juntamente com seu ID de usuario
                        MessageBox.Show("Seja bem-vindo " + resultadoAutenticacao.ToString() + "\n" +
                            "Seu ID é: " + armazenaIDUsuarioInt);

                        //Evoca a tela atual que está em execução e chama a mesma por uma variavel de 'telaAtual'
                        Form telaAtual = Form.ActiveForm;

                        //Evoca um novo objeto de tela de menu e atribui com o nome de 'telaMenu'
                        TelaMenu telaMenu = new TelaMenu();

                        //Abre a tela de menu
                        telaMenu.Show();

                        //Fecha a tela atual
                        telaAtual.Close();

                    }

                    //Caso a verificação seja falsa (False), retorna uma caixa de mensagem informando ao usuario que o nome digitado ou senha estão incorretos.
                    else
                    {

                        MessageBox.Show("Nome de usuário ou senha incorretos");

                    }


                }
            }
        }


        //Define as ações que serão executadas ao clique do botão 'buttonVoltar'
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            //Fecha a tela atual
            this.Close();
        
        }

        //Define as ações que serão executadas ao clique do botão 'buttonEntrar'
        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            //Realiza a execução dos métodos que tem relação com SP's
            CriaSPCapturaIDUsuarioAutenticado(); //Executa método que cria ou altera a SP que realiza a captura do ID do usuário
            CriaSPVerificaUsuario(); // Executa o método que cria ou altera a SP que realiza a verificação do usuario

            //Executa o método que realiza a autenticação do usuario
            AutenticarUsuario();

        }

        //Define um caracter especial que irá mascarar os valores digitados na textBox de senha
        private void textBoxEntrarSenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxEntrarSenhaUsuario.PasswordChar = '*';
        }
    }
}
