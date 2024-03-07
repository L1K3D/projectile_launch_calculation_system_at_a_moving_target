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
using System.IO;
using System.Diagnostics;

//Declarando local onde o código está alocado
namespace PPL_Main.Telas
{
    //Declarando a construão do visual
    public partial class TelaSimulacao : Form
    {

        //Declara um instanciamento de referencia ao código principal do programa, para que seja possível usar os métodos e variaveis declaradas ao decorrer do código
        Program referenciaClassePrograma = new Program();

        //Declarando instanciamento e criação de novo objeto de alvo
        CodigosMain.Alvo alvo1 = new CodigosMain.Alvo();

        //Declarando instancimento e criação de novo objeto de projetil
        CodigosMain.Projetil projetil1 = new CodigosMain.Projetil();

        //Declarando instanciamento e criação de novo obeto de valores de calculo 
        CodigosMain.ValoresCalculoEquacaoQuadratica valoresCalculo1 = new CodigosMain.ValoresCalculoEquacaoQuadratica();

        //Inicializando visual
        public TelaSimulacao()
        {
            InitializeComponent();
        }

        //Criando método que cria a Stored Procedure que realiza a criação do projetil
        internal void CriaSPCadastraProjetil()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abrindo conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Criando comando de SP (Stored Procedure) que realiza a inclusão de novos dados na tabela de projetil
                string criandoSPInclusaoDadosProjetil = @"

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

                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP (Stored Procedure) declarada
                using (SqlCommand comandoQuerySPInsereDadosProjetil = new SqlCommand(criandoSPInclusaoDadosProjetil, conexaoBancoDeDados))
                {
                    comandoQuerySPInsereDadosProjetil.ExecuteNonQuery();
                }

            }

        }

        //Criando metodo que insere os dados do Projetil na tabela
        internal void CadastraProjetil()
        {
            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {
                //Abre conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Declara um comando em SQL que irá usar a SP 'InserirProjetil'
                using (SqlCommand comandoInsereDadosTabelaProjetil = new SqlCommand("InserirProjetil", conexaoBancoDeDados))
                {

                    //Declara o comando como uma SP
                    comandoInsereDadosTabelaProjetil.CommandType = CommandType.StoredProcedure;

                    //Declara quais valores irão ser atribuidos em cada parametro da SP
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@AnguloTrajetoriaProjetil", Convert.ToDecimal(projetil1.AnguloLancamentoProjetil)); //Atribui o valor de angulo do projetil, convertido em decimal para o parametro "@AnguloTrajetoriaProjetil"
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@VelocidadeInicial1Projetil", Convert.ToDecimal(projetil1.VelocidadeInicial1Projetil)); //Atribui o valor de velocidade inicial 1 do projetil, convertido em decimal para o parametro "@VelocidadeInicial1Projetil" 
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@VelocidadeInicial2Projetil", Convert.ToDecimal(projetil1.VelocidadeInicial2Projetil)); //Atribui o valor de velocidade inicial 2 do projetil, convertido em decimal para o parametro "@VelocidadeInicial2Projetil"
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@VelocidadeUsadaProjetil", Convert.ToDecimal(projetil1.VelocidadeUsada)); //Atribui o valor de velocidade usada do projetil, convertido em decimal para o parametro "@VelocidadeUsadaProjetil"
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@TempoVooProjetil", Convert.ToDecimal(projetil1.TempoVoo)); //Atribui o valor de tempo de voo do projetil, convertido em decimal para o parametro de "@TempoVooProjetil"
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@TipoMovimentoProjetil", projetil1.TipoMovimento); //Atribui o valor do tipo de movimento para o parametro de "@TipoMovimentoProjetil"
                    comandoInsereDadosTabelaProjetil.Parameters.AddWithValue("@ExistenciaResolucaoRealAnguloFornecido", projetil1.ResolucaoRealParaOAngulo); //Atribui o valor da existência real para ângulo fornecido para o parametro de "@ExistenciaResolucaoRealAnguloFornecido"

                    //Executa o comando como um método de 'NonQuery', tendo em vista que o comando trata-se de uma SP
                    comandoInsereDadosTabelaProjetil.ExecuteNonQuery();


                }

            }
        }

        //Criando método que Cria a SP que insere os dados do Alvo
        internal void CriaSPCadastrarAlvo()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abrindo conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Cria comando que cria ou altera SP
                string criandoSPInclusaoDadosAlvo = @"

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

                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP
                using (SqlCommand comandoQuerySPInsereDadosAlvo = new SqlCommand(criandoSPInclusaoDadosAlvo, conexaoBancoDeDados))
                {
                    comandoQuerySPInsereDadosAlvo.ExecuteNonQuery();
                }

            }

        }

        //Criando metodo que realiza o cadastro do alvo
        internal void CadastraAlvo()
        {

            //Abre coneção com o banco de dados com o endereçamento referenciado no momento de instancia do programa
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abre conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Inicia as variações de comando com a Stored Procedure de "InserirAlvo"
                using (SqlCommand comandoInsereDadosTabelaAlvo = new SqlCommand("InserirAlvo", conexaoBancoDeDados))
                {

                    //Referencia o comando de inserir dados na tabela de alvo como uma SP
                    comandoInsereDadosTabelaAlvo.CommandType = CommandType.StoredProcedure;

                    //Atribui os valores de referencia na SP de "Inserir Alvo"
                    comandoInsereDadosTabelaAlvo.Parameters.AddWithValue("@AlturaInicialAlvo", Convert.ToDecimal(alvo1.AlturaInicialAlvo)); //Referencia o atributo da SP  de "AlturaInicial" como o atributo de "AlturaInicialAlvo" do objeto Alvo
                    comandoInsereDadosTabelaAlvo.Parameters.AddWithValue("@DistanciaCanhaoAlvo", Convert.ToDecimal(alvo1.DistanciaDoCanhaoAlvo)); //Referencia o atributo da SP de "DistanciaDoCanhao" como o atributo de "DistanciaDoCanhao" do objeto Alvo
                    comandoInsereDadosTabelaAlvo.Parameters.AddWithValue("@VelocidadeInicialAlvo", Convert.ToDecimal(alvo1.VelocidadeAlvo)); //Referencia o atributo da SP de "VelocidadeInicialAlvo" como o atributo de "VelocidadeAlvo" do objeto Alvo
                    comandoInsereDadosTabelaAlvo.Parameters.AddWithValue("@AnguloMaximoAcertoAlvo", Convert.ToDecimal(alvo1.AnguloMaximo)); //Referencia o atributo da SP de "AnguloMaximoAcertoAlvo" como o atributo de "AnguloMaximo" do objeto Alvo
                    comandoInsereDadosTabelaAlvo.Parameters.AddWithValue("@TempoAteAtingirSoloAlvo", Convert.ToDecimal(alvo1.TempoAteAtingirSoloAlvo)); //Referencia o atributo da SP "TempoAteAtingirSoloAlvo" como o atributo de "TempoAteAtingirSoloAlvo" do objeto Alvo

                    //Realiza a executão do comando como uma execução de uma "Não Query", tratando-se de uma SP
                    comandoInsereDadosTabelaAlvo.ExecuteNonQuery();


                }

            }

        }

        //Criando método que cria a SP que insere os dados na tabela de simulação
        internal void CriaSPSimulacao()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abrindo conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Criando SP
                string criandoSPInclusaoDadosSimulacao = @"
                
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
                END";

                //Cria instancia SQL que realiza a execução do comando de criação ou alteração da SP
                using (SqlCommand comandoQuerySPInsereDadosSimulacao = new SqlCommand(criandoSPInclusaoDadosSimulacao, conexaoBancoDeDados))
                {
                    comandoQuerySPInsereDadosSimulacao.ExecuteNonQuery();
                }

            }

        }

        //Cria método que cadastra uma nova simulação
        internal void CadastraSimulacao()
        {

            //Abre coneção com o banco de dados com o endereçamento referenciado no momento de instancia do programa
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abre conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Inicia as variações de comando com a Stored Procedure de "InserirAlvo"
                using (SqlCommand comandoInsereDadosTabelaSimulacao = new SqlCommand("InserirSimulacao", conexaoBancoDeDados))
                {

                    //Referencia o comando de inserir dados na tabela de alvo como uma SP
                    comandoInsereDadosTabelaSimulacao.CommandType = CommandType.StoredProcedure;

                    //Atribui os valores de referencia na SP de "Inserir Alvo"
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@AnguloTrajetoriaProjetil", Convert.ToDecimal(projetil1.AnguloLancamentoProjetil)); //Converte o valor de angulo do lançamento do projetil para decimal e atribui ele ao parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@VelocidadeInicial1Projetil", Convert.ToDecimal(projetil1.VelocidadeInicial1Projetil)); //Converte o valor de velocidade inicial 1 do projetil para decimal e atribui ele ao parametro correspondente na SP 
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@VelocidadeInicial2Projetil", Convert.ToDecimal(projetil1.VelocidadeInicial2Projetil)); //Converte o valor de velocidade inicial 2 do projetil para decimal e atribui ele ao parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@VelocidadeUsadaProjetil", Convert.ToDecimal(projetil1.VelocidadeUsada)); //Converte o valor de velocidade usada do projetil para decimal e atribui ele ao parametro correspondente a SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@TempoVooProjetil", Convert.ToDecimal(projetil1.TempoVoo)); //Converte o valor de tempo de voo do projetil para decimal e atribui ele ao parametro correspondente a SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@TipoMovimentoProjetil", projetil1.TipoMovimento); //Atribui o valor do tipo de movimento do projetil para o parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@ExistenciaResolucaoRealAnguloFornecido", projetil1.ResolucaoRealParaOAngulo); //Atribui o valor do conceito de resolução real para o ângulo, para o parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@AlturaInicialAlvo", Convert.ToDecimal(alvo1.AlturaInicialAlvo)); //Converte o valor da altura inicial do alvo para decimal e atribui ele para o valor correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@DistanciaDoCanhaoAlvo", Convert.ToDecimal(alvo1.DistanciaDoCanhaoAlvo)); //Converte o valor a distancia do alvo até o canhão para decimal e atribui ele para o valor correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@VelocidadeInicialAlvo", Convert.ToDecimal(alvo1.VelocidadeAlvo)); //Converte o valor da velociade do alvo para decimal e atribui ele ao parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@AnguloMaximoAcertoAlvo", Convert.ToDecimal(alvo1.AnguloMaximo)); //Converte o valor do ângulo máximo do alvo para decimal e atribui ele ao parametro correspondente na SP
                    comandoInsereDadosTabelaSimulacao.Parameters.AddWithValue("@TempoAteAtingrSoloAlvo", Convert.ToDecimal(alvo1.TempoAteAtingirSoloAlvo)); //Converte o valor do tempo que decorre até que o alvo atinga o solo para decimal e atribui ele ao parametro correspondente na SP

                    //Realiza a executão do comando como uma execução de uma "Não Query", tratando-se de uma SP
                    comandoInsereDadosTabelaSimulacao.ExecuteNonQuery();


                }

            }

        }

        //Cria método que escreve o arquivo CSV que contém os dados do gráfico 
        private void EscreverArquivoCSV(string nome_arquivo) //Define como parametro recebedor do método o caminho do arquivo que será criado
        {

            //Define o nome da pasta que será criada
            string nomeSubpasta = "PBLGeracaoGrafico";

            //Captura o caminho da pasta padrão de 'documentos' na qual o software está sendo executado
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Combina os caminhos declaradados anteriormente e determina o caminho final de uma pasta de destino
            string pastaDestino = Path.Combine(pastaDocumentos, nomeSubpasta);

            //Julga que caso o diretorio a ser construido não exista, ele então é criado do zero
            if (!Directory.Exists(pastaDestino + "\\" + nome_arquivo))
            {

                Directory.CreateDirectory(pastaDestino);

            }

            //Cria um caminho de ssalvamento para o arquivo, onde será combinado o caminho da pasta destino e o nome do arquivo
            string caminhoArquivo = Path.Combine(pastaDestino, nome_arquivo);

            //Escreve um arquivo vazio com o nome declarado
            File.WriteAllText(caminhoArquivo, string.Empty);

            //Caso a pasta de arquivo e o arquivo não exista, retorna uma caixa de mensagem informando que um erro ocorreu
            if (!File.Exists(pastaDestino + "\\" + nome_arquivo))
            {

                MessageBox.Show("Erro ao localizar o arquivo de input");

            }

            //Calcula parametros com definições de cinco vezes maiores que os obtidos
            //Calcula o tempo máximo de voo
            double maximo_tempo_voo = projetil1.TempoVoo * 5;

            //Calcula a posição máxima em y do projetil
            double maximo_posicao_em_y_projetil = projetil1.VelocidadeInicialEmYProjetil * maximo_tempo_voo - (4.9 * Math.Pow(maximo_tempo_voo, 2));
            maximo_posicao_em_y_projetil = Math.Round(maximo_posicao_em_y_projetil, 2); //Arredonda o valor em duas casas decimais

            //Calcula a posição máxima em y do alvo
            double maximo_posicao_em_y_alvo = alvo1.AlturaInicialAlvo - alvo1.VelocidadeAlvo * maximo_tempo_voo;

            //Define o nome das colunas que serão encontradas no arquivo
            string adicionarConteudoColunas = "TempoDeVooProjetil;MaximoTempoDeVooProjetil;PosicaoEmYProjetil;AlturaInicialAlvo;MaximoPosicaoEmYProjetil;PosicaoEmYAlvo;MaximoPosicaoEmYAlvo";

            //Define o conteúdo das colunas
            string adicionarConteudoDados = $"{Math.Abs(projetil1.TempoVoo)};{Math.Abs(maximo_tempo_voo)};{Math.Abs(projetil1.PosicaoEmYProjetil)};{Math.Abs(alvo1.AlturaInicialAlvo)};{Math.Abs(maximo_posicao_em_y_projetil)};{Math.Abs(alvo1.PosicaoEmYAlvo)};{Math.Abs(maximo_posicao_em_y_alvo)}";

            //Une os conteudos das colunas em um esquema de gravação no arquivo
            File.AppendAllText(pastaDestino + "\\" + nome_arquivo, adicionarConteudoColunas + Environment.NewLine);
            
            //Une os conteudos digitados e referenciados em um esquema de gravação de arquivo
            File.AppendAllText(pastaDestino + "\\" + nome_arquivo, adicionarConteudoDados + Environment.NewLine);


        }

        //Criando método que realiza a execução da abertura do código em python que gera o arquivo da simulação
        private void AbreScriptPython()
        {

            //O CAMINHO DO SCRIPT EM PYTHON DEVE SER ALTERADO CONFORME A MÁQUINA NA QUAL O SOFTWARE ESTÁ SENDO EXECUTADA
            Process.Start("python", @"D:\Heitor\FESA\PBL\PPL_Main\PythonScripts\GeracaoGrafico.py");

        }

        //Cria método que realiza o calculo da trajetória
        private void RealizaCalculo()
        {

            //Verifica o tipo de dado no qual os inputs fornecidos nas textBoxe's existentes no visual do WindosForms. Todos devem receber dados do tipo double
            if (double.TryParse(textBoxDadosAlvoAlturaInicial.Text, out double valorTextBoxDadosAlvoAlturaInicial) &&
               double.TryParse(textBoxDadosAlvoDistanciaDoCanhao.Text, out double valorTextBoxDadosAlvoDistanciaDoCanhao) &&
               double.TryParse(textBoxDadosVelocidadeInicialAlvo.Text, out double valorTextBoxDadosAlvoVelocidadeInicial) &&
               double.TryParse(textBoxDadosProjetilAnguloTrajetoria.Text, out double valorTextBoxDadosProjetilAnguloTrajetoria))
            {
                //Atribuindo valores iniciais
                projetil1.AnguloLancamentoProjetil = valorTextBoxDadosProjetilAnguloTrajetoria;
                alvo1.AlturaInicialAlvo = valorTextBoxDadosAlvoAlturaInicial;
                alvo1.DistanciaDoCanhaoAlvo = valorTextBoxDadosAlvoDistanciaDoCanhao;
                alvo1.VelocidadeAlvo = valorTextBoxDadosAlvoVelocidadeInicial;

                //Realizando o calculo do tempo que decorre até que o alvo atinja o solo
                alvo1.CalculaTempoAteAtingirSoloAlvo();

                //Realizando o calculo do angulo máximo
                alvo1.CalculaAnguloMaximo();

                //Realizando condição para visualizar atendimento do angulo digitado pelo usuario, compreenda as variações do ângulo máximo
                projetil1.AnguloLancamentoProjetil = (projetil1.AnguloLancamentoProjetil) * Math.PI / 180.0;

                //Verifica as condições onde o angulo do lançamento do projejtil fornecido pelo usuário e convertido em radianos seja menor ou igual ao ângulo máximo e seja maior que '0'
                if ((projetil1.AnguloLancamentoProjetil <= alvo1.AnguloMaximo) &&
                    (projetil1.AnguloLancamentoProjetil > 0.00))
                {

                    //Resolvendo equação do lançamento
                    valoresCalculo1.VisaoA = alvo1.DistanciaDoCanhaoAlvo * Math.Tan(projetil1.AnguloLancamentoProjetil) - alvo1.AlturaInicialAlvo; //Resolvendo valor em A
                    valoresCalculo1.VisaoB = alvo1.VelocidadeAlvo * alvo1.DistanciaDoCanhaoAlvo / (CodigosMain.MetodoCosseno.CalculaCosseno(projetil1.AnguloLancamentoProjetil)); //Resolvendo valor em B
                    valoresCalculo1.VisaoC = -4.9 * (Math.Pow(alvo1.DistanciaDoCanhaoAlvo, 2)) / Math.Pow((CodigosMain.MetodoCosseno.CalculaCosseno(projetil1.AnguloLancamentoProjetil)), 2); //Resolvendo valor em C

                    //Resolvendo delta da equação
                    valoresCalculo1.CalculaDiscriminanteEmDelta();

                    // Realizando condicionamento para o valor de delta encontrado
                    //Caso o valor de delta seja menor ou igual a zero, retorna uma message Box informando ao usuário que não existe uma resolução real para o angulo digitado
                    if (valoresCalculo1.DiscriminanteEmDelta <= 0)
                    {

                        //Exibe uma caixa de mensagem para o usuario informando valores sobre o seu angulo digitado
                        MessageBox.Show("Infelizmente, não há uma resolução real para o angulo fornecido \n" + //Informa ao usuario que o angulo digitado não possui resolução real
                                                        "Valor em A: " + Math.Round(valoresCalculo1.VisaoA, 2) + "\n" + //Informa o valor do coeficiente em A
                                                        "Valor em B: " + Math.Round(valoresCalculo1.VisaoB, 2) + "\n" + //Informa o valor do coeficiente em B
                                                        "Valor em C: " + Math.Round(valoresCalculo1.VisaoC, 2) + "\n" + //Informa o valor do coeficiente em C
                                                        "Valor de Delta: " + Math.Round(valoresCalculo1.DiscriminanteEmDelta, 2)); //Informa o valor de Delta

                        //Limpa os valores de todas as TextBoxes presentes na tela
                        textBoxDadosAlvoAlturaInicial.Text = "";
                        textBoxDadosAlvoDistanciaDoCanhao.Text = "";
                        textBoxDadosProjetilAnguloTrajetoria.Text = "";
                        textBoxDadosVelocidadeInicialAlvo.Text = "";

                        //Realizao cadastro do projetil simulado com os dados definidos
                        projetil1.VelocidadeInicial1Projetil = 0.00;
                        projetil1.VelocidadeInicial2Projetil = 0.00;
                        projetil1.TempoVoo = 0.00;
                        projetil1.TipoMovimento = "N/A";
                        projetil1.ResolucaoRealParaOAngulo = "N";
                        CadastraProjetil();

                        //Realiza o cadastro do alvo com os dados definidos
                        CadastraAlvo();

                        //Realiza o cadastro da simulacao completa
                        CadastraSimulacao();

                    }

                    //Caso exista uma resolução real para o ângulo, o calculo é iniciado
                    else
                    {

                        //Define um valor para o atributo de que se existe resolução real no ângulo
                        projetil1.ResolucaoRealParaOAngulo = "S";

                        //Calcula o valor da velocidade inicial 1
                        projetil1.VelocidadeInicial1Projetil = (-valoresCalculo1.VisaoB + Math.Sqrt(valoresCalculo1.DiscriminanteEmDelta)) / (2 * valoresCalculo1.VisaoA);

                        //Calcula o valor da velocidade inicial 2
                        projetil1.VelocidadeInicial2Projetil = (-valoresCalculo1.VisaoB - Math.Sqrt(valoresCalculo1.DiscriminanteEmDelta)) / (2 * valoresCalculo1.VisaoA);

                        //Decide qual velocidade deve ser usada
                        projetil1.VelocidadeUsada = projetil1.VelocidadeInicial1Projetil > 0 ? projetil1.VelocidadeInicial1Projetil : projetil1.VelocidadeInicial2Projetil;

                        //Analisa condição para determinar o tipo de movimento do projetil
                        projetil1.TipoMovimento = alvo1.VelocidadeAlvo > (projetil1.VelocidadeUsada * CodigosMain.MetodoSeno.CalcularSeno(projetil1.AnguloLancamentoProjetil) - 4.9 * Math.Pow(projetil1.TempoVoo, 2)) ? "Ascendente" : "Descendente";

                        //Calcula a velocidade do projetil em X
                        projetil1.VelocidadeInicialEmXProjetil = projetil1.VelocidadeUsada * CodigosMain.MetodoCosseno.CalculaCosseno(projetil1.AnguloLancamentoProjetil);

                        //Calcula a velocidade do projetil em Y
                        projetil1.VelocidadeInicialEmYProjetil = projetil1.VelocidadeUsada * CodigosMain.MetodoSeno.CalcularSeno(projetil1.AnguloLancamentoProjetil);

                        //Define uma posição inicial para o projetil
                        projetil1.PosicaoEmYProjetil = 0.00;

                        //Criando modelo de equação quadrática para encontrar o tempo de encontro entre projetil e alvo
                        double equacaoEncontroA = 4.9; //Resolvendo valor de A
                        double equacaoEncontroB = -(projetil1.VelocidadeInicialEmYProjetil + alvo1.VelocidadeAlvo); //Resolvendo valor em B
                        double equacaoEncontroC = alvo1.AlturaInicialAlvo; //Resolvendo valor em B

                        //Calcula o valor de Delta
                        double discriminanteEmDelta = Math.Pow(equacaoEncontroB, 2) - 4 * equacaoEncontroA * equacaoEncontroC;

                        //Verifica se o valor de delta é maior que zero
                        if (discriminanteEmDelta > 0)
                        {

                            //Obtem os valores de tempo 1 e tempo 2, usando calculos padrões de formula de Baskhara
                            double tempo1 = (-equacaoEncontroB +  Math.Sqrt(discriminanteEmDelta)) / (2 * equacaoEncontroA);
                            double tempo2 = (-equacaoEncontroB - Math.Sqrt(discriminanteEmDelta)) / (2 * equacaoEncontroA);

                            //Atribui um valor para o atributo de 'TempoVoo' do proejtil, selecionando a menor variação entre esses.
                            projetil1.TempoVoo = Math.Min(tempo1, tempo2);
                            projetil1.TempoVoo = Math.Round(projetil1.TempoVoo, 2); //Arredonda o valor em até duas casas decimais após a virgula

                            //Calcula a posição em Y para o proejetil
                            projetil1.PosicaoEmYProjetil = projetil1.VelocidadeInicialEmYProjetil * projetil1.TempoVoo - (4.9 * Math.Pow(projetil1.TempoVoo, 2));
                            projetil1.PosicaoEmYProjetil = Math.Round(projetil1.PosicaoEmYProjetil, 2); //Arredona o valor em até duas casas decimaais após a virgula

                            //Calcula a posição em Y para o alvo
                            alvo1.PosicaoEmYAlvo = alvo1.AlturaInicialAlvo - alvo1.VelocidadeAlvo * projetil1.TempoVoo;
                            alvo1.PosicaoEmYAlvo = Math.Round(alvo1.PosicaoEmYAlvo, 2); //Arredonda o valor em até das casas decimais após a virgula

                        }

                        //Caso a verificação falhe, define 0 para o atributo de "TempoVoo" do projetil
                        else
                        {

                            projetil1.TempoVoo = 0.00;

                        }

                        //Exibe os resultados finais em uma caixa de mensagem
                        MessageBox.Show("Confira os resultados abaixo \n" +
                                                        "Valor em A: " + Math.Round(valoresCalculo1.VisaoA, 2) + "\n" + //Informa o valor em A
                                                        "Valor em B: " + Math.Round(valoresCalculo1.VisaoB, 2) + "\n" + //Informa o valor em B
                                                        "Valor em C: " + Math.Round(valoresCalculo1.VisaoC, 2) + "\n" + //Informa o valor em C
                                                        "Valor de Delta: " + Math.Round(valoresCalculo1.DiscriminanteEmDelta, 2) + "\n\n" + //Informa o valor de Delta
                                                        "Velocidade inicial do projetil sugerida: " + Math.Round(projetil1.VelocidadeUsada, 2) + " m/s \n" + //Informa o valor da velocidade inicial sugerida para o projetil
                                                        "Intervalo do tempo de voo: " + Math.Round(projetil1.TempoVoo, 2) + " segundos \n" + //Informa o valor em que o projetil atingiria o alvo
                                                        "Tipo de movimento do acerto: " + projetil1.TipoMovimento); //Informa o tipo de acerto

                        CadastraProjetil(); //Executa o método de cadastrar projetil
                        CadastraAlvo(); //Executa método de cadastrar alvo
                        CadastraSimulacao(); //Executa método de cadastrar simulação
                        EscreverArquivoCSV("dados_simulacao.txt"); //Executa método que grava arquivo dos dados obtidos
                        AbreScriptPython(); //Executa método que executa script em python que gera o gráfico de simulação

                    }

                }

                //Caso a verificação falhe, exibe uma caixa de mensagem e apaga todo conteúdo da textBox de angulo referenciado
                else
                {

                    MessageBox.Show("Não existe possibilidades para o ângulo digitado. Por favor, digite outro angulo");
                    textBoxDadosProjetilAnguloTrajetoria.Text = "";

                }

            }

        }

        //Define ações que serão executadas após o clique do botão 'buttonSimularTelaSimulacao'
        private void buttonSimularTelaSimulacao_Click(object sender, EventArgs e)
        {

            CriaSPCadastraProjetil(); //Executa método que cria ou altera SP de cadastro de projetil
            CriaSPCadastrarAlvo(); //Executa método que cria ou altera SP de cadastro de alvo
            CriaSPSimulacao(); //Executa método que cria ou altera SP de cadastro de simulação

            //Executa método que realiza o calculo
            RealizaCalculo();

        }

        //Define ações que serão executadas após o clique do botão 'buttonObterAnguloIdeal'
        private void buttonObterAnguloIdeal_Click(object sender, EventArgs e)
        {

            //Realiza checagem do tipo de dado digitado nas textBoxe's
            if (double.TryParse(textBoxDadosAlvoAlturaInicial.Text, out double valorTextBoxDadosAlvoAlturaInicial) &&
               double.TryParse(textBoxDadosAlvoDistanciaDoCanhao.Text, out double valorTextBoxDadosAlvoDistanciaDoCanhao) &&
               double.TryParse(textBoxDadosVelocidadeInicialAlvo.Text, out double valorTextBoxDadosAlvoVelocidadeInicial))
            {

                //Atribui valores inicias paara os valores digitados
                alvo1.AlturaInicialAlvo = valorTextBoxDadosAlvoAlturaInicial;
                alvo1.DistanciaDoCanhaoAlvo = valorTextBoxDadosAlvoDistanciaDoCanhao;
                alvo1.VelocidadeAlvo = valorTextBoxDadosAlvoVelocidadeInicial;

                //Executa método de angulo máximo
                alvo1.CalculaAnguloMaximo();

                //Exibe caixa de mensagem que mostra para o usuário, a partir de qual ângulo o mesmo deve digitar
                MessageBox.Show("Para os valores de alvo digitados, o angulo de lançamento minimo do projetil deve ser a partir de " + alvo1.AnguloMaximo);

            }

            //Caso a verificação retorne status falso (False), exibe uma caixa de mensagem que solicita ao usuário que digite valores corretos
            else
            {

                MessageBox.Show("Valores digitados incorretamente, por favor, forneça valores corretos");

            }

        }

        private void TelaSimulacao_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Define ações que serão realizadas após o clique do botão 'buttonSairTelaSimulacao'
        private void buttonSairTelaSimulacao_Click(object sender, EventArgs e)
        {

            //Cria novo objeto que referencia WindowsForms atual
            Form telaAtual = Form.ActiveForm;

            //Cria novo objeto que referencia a 'TelaMenu', atribuindo para uma variavel de nome de 'telaMenu'
            TelaMenu telaMenu = new TelaMenu();

            //Exibe uma nova 'TelaMenu'
            telaMenu.Show();

            //Fecha tela atual
            telaAtual.Close();

        }
    }
}