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
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

//Decalarando o local e namespace no qual o código está alocado
namespace PPL_Main.Telas
{
    //Declarando instancialmento da classe do visual
    public partial class TelaMenu : Form
    {
        //Importando um novo instanciamento que referencia o código principal do programa, para que esse trecho do código possa ter acesso as variaveis contidas dentro desse trecho
        Program referenciaClassePrograma = new Program();

        //Inicializando visual do WindowsForms
        public TelaMenu()
        {
            InitializeComponent();
        }

        //Criando método que seleciona todo o conteúdo da tabela de simulações e realiza o salvamento do conteudo em um arquivo '.csv'
        private void SelecionaConteudoSimulacoes()
        {

            //Define comando que seleciona todo o conteúdo da tabela de simulações
            string querySelecionaTudoTabelaSimulacoes = "SELECT * FROM simulacoes";

            //Definindo o caminho onde o arquivo '.csv' será salvo
            //ESSE CAMINHO DEVE SER ALTERADO CONFORME A NECESSIDADE DO EXECUTOR DO PROGRAMA, ALTERANDO PARA OS PADRÕES PARA SE ADEQUAR A MÁQUINA NO QUAL O SOFTWARE ESTÁ SENDO EXECUTADO
            string caminhoArquivo = @"D:\Heitor\FESA\PBL\PPL_Main\RelatorioPaginado\Dados\simulacoes.csv";

            //Criando laço de tentativa de execução
            try
            {
                // Conecta ao servidor SQL
                using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
                {
                    conexaoBancoDeDados.Open();

                    // Cria um adaptador SQL para executar a consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(querySelecionaTudoTabelaSimulacoes, conexaoBancoDeDados))
                    {
                        // Cria um DataSet para armazenar os resultados da consulta
                        DataSet dataSet = new DataSet();

                        // Preenche o DataSet com os resultados da consulta
                        adapter.Fill(dataSet);

                        // Chama o método para salvar o DataSet em um arquivo CSV, passando o caminho do arquivo
                        SaveDataSetToCSV(dataSet, caminhoArquivo);

                    }
                }

                //...Encerra laço de tentativa
            }

            //Criando laço de exceção
            catch (Exception ex)
            {
                //Exibe caixa de mensagem que denuncia para o usuário o erro de processamento que ocorreu
                MessageBox.Show("Erro: " + ex.Message);
            
            }

        }

        //Criando método que seleciona todo o conteúdo da tabela de projetil e realiza o salvamento do conteudo em um arquivo '.csv'
        private void SelecionaConteudoProjetil()
        {

            //Define comando que seleciona todo o conteúdo da tabela de simulações
            string querySelecionaTudoTabelaProjetil = "SELECT * FROM projetil";

            //Definindo o caminho onde o arquivo '.csv' será salvo
            //ESSE CAMINHO DEVE SER ALTERADO CONFORME A NECESSIDADE DO EXECUTOR DO PROGRAMA, ALTERANDO PARA OS PADRÕES PARA SE ADEQUAR A MÁQUINA NO QUAL O SOFTWARE ESTÁ SENDO EXECUTADO
            string caminhoArquivo = @"D:\Heitor\FESA\PBL\PPL_Main\RelatorioPaginado\Dados\projetil.csv";
            
            //Cria laço de tentativa de execução
            try
            {
                // Conecta ao servidor SQL
                using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
                {
                    conexaoBancoDeDados.Open();

                    // Cria um adaptador SQL para executar a consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(querySelecionaTudoTabelaProjetil, conexaoBancoDeDados))
                    {
                        // Cria um DataSet para armazenar os resultados da consulta
                        DataSet dataSet = new DataSet();

                        // Preenche o DataSet com os resultados da consulta
                        adapter.Fill(dataSet);

                        // Chama o método para salvar o DataSet em um arquivo CSV, passando o caminho do arquivo
                        SaveDataSetToCSV(dataSet, caminhoArquivo);

                    }
                }

                //...Encerra laço de tentativa
            }

            //Criando laço de exceção
            catch (Exception ex)
            {
                //Exibe caixa de mensagem que denuncia para o usuário o erro de processamento que ocorreu
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        //Criando método que seleciona todo o conteúdo da tabela de alvo e realiza o salvamento do conteudo em um arquivo '.csv'
        private void SelecionaConteudoAlvo()
        {

            //Define comando que seleciona todo o conteúdo da tabela de simulações
            string querySelecionaTudoTabelaAlvo = "SELECT * FROM alvo";

            //Definindo o caminho onde o arquivo '.csv' será salvo
            //ESSE CAMINHO DEVE SER ALTERADO CONFORME A NECESSIDADE DO EXECUTOR DO PROGRAMA, ALTERANDO PARA OS PADRÕES PARA SE ADEQUAR A MÁQUINA NO QUAL O SOFTWARE ESTÁ SENDO EXECUTADO
            string caminhoArquivo = @"D:\Heitor\FESA\PBL\PPL_Main\RelatorioPaginado\Dados\alvo.csv";
            
            //Cria laço de tentativa de execução
            try
            {
                // Conecta ao servidor SQL
                using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
                {
                    conexaoBancoDeDados.Open();

                    // Cria um adaptador SQL para executar a consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(querySelecionaTudoTabelaAlvo, conexaoBancoDeDados))
                    {
                        // Cria um DataSet para armazenar os resultados da consulta
                        DataSet dataSet = new DataSet();

                        // Preenche o DataSet com os resultados da consulta
                        adapter.Fill(dataSet);

                        // Chama o método para salvar o DataSet em um arquivo CSV, passando o caminho do arquivo
                        SaveDataSetToCSV(dataSet, caminhoArquivo);

                    }
                }

                //...Encerra laço de tentativa de execução

            }

            //Cria laço de exceção
            catch (Exception ex)
            {
                //Exibe caixa de mensagem que denuncia para o usuário o erro de processamento que ocorreu
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        //Criando método que seleciona apenas o ID do usuário da tabela de usuarios e realiza o salvamento do conteudo em um arquivo '.csv'
        private void SelecionaConteudoUsuario()
        {

            //Define comando que seleciona todo o conteúdo da tabela de simulações
            string querySelecionaTudoTabelaUsuario = "SELECT id_usuario FROM usuarios";

            //Definindo o caminho onde o arquivo '.csv' será salvo
            //ESSE CAMINHO DEVE SER ALTERADO CONFORME A NECESSIDADE DO EXECUTOR DO PROGRAMA, ALTERANDO PARA OS PADRÕES PARA SE ADEQUAR A MÁQUINA NO QUAL O SOFTWARE ESTÁ SENDO EXECUTADO
            string caminhoArquivo = @"D:\Heitor\FESA\PBL\PPL_Main\RelatorioPaginado\Dados\usuarios.csv";
            
            //Cria laço de tentativa de execução
            try
            {
                // Conecta ao servidor SQL
                using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
                {
                    conexaoBancoDeDados.Open();

                    // Cria um adaptador SQL para executar a consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(querySelecionaTudoTabelaUsuario, conexaoBancoDeDados))
                    {
                        // Cria um DataSet para armazenar os resultados da consulta
                        DataSet dataSet = new DataSet();

                        // Preenche o DataSet com os resultados da consulta
                        adapter.Fill(dataSet);

                        // Chama o método para salvar o DataSet em um arquivo CSV, passando o caminho do arquivo
                        SaveDataSetToCSV(dataSet, caminhoArquivo);

                    }
                }

                //...Encerra o laço de tentativa de excecu~ção

            }

            //Cria laço de exceção
            catch (Exception ex)
            {
                //Exibe caixa de mensagem que denuncia para o usuário o erro de processamento que ocorreu
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        //Cria método que irá realizar o salvamento dos dados nos arquivos '.csv'
        static void SaveDataSetToCSV(DataSet dataSet, string filePath)
        {

            //Inicia método de StreamWriter de arquivos, inserindo o caminho do arquivo como referência
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                //Cria laço de checagem e repetição, onde para cada tabela contida no 'DataSet' criado, ele importa todo o conteúdo
                foreach (DataTable table in dataSet.Tables)
                {
                    // Escreve o cabeçalho (nomes das colunas)
                    foreach (DataColumn col in table.Columns)
                    {
                        writer.Write($"{col.ColumnName};");
                    }
                    writer.WriteLine();

                    // Escreve os dados
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (var field in row.ItemArray)
                        {
                            writer.Write($"{field.ToString()};");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        //Cria método que realiza a abertura do arquivo do PowerBI do relatório páginado
        static void AbrirArquivoPBIX(string caminhoArquivoPBIX) //Esse método é de meio estático e recebe o caminho do arquivo do PowerBI Desktop
        {

            //Cria laço de tentativa de execução
            try
            {
                //Inicia processamento do caminho do arquivo
                Process.Start(caminhoArquivoPBIX);

                //...Encerra a tentativa de execução
            }

            //Cria laço de exceção
            catch (Exception ex)
            {
                //Exibe caixa de mensagem com o erro ocorrido
                MessageBox.Show($"Erro ao abrir o arquivo PBIX: {ex.Message}");
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Define ações que serão executadas após o clique do botão 'buttonAbreTelaSimular'
        private void buttonAbreTelaSimular_Click(object sender, EventArgs e)
        {
            //Define um novo objeto que referencia o visual do WindowsForms atual
            Form telaAtual = Form.ActiveForm;

            //Inicia a criação de um novo objeto que referencia a TelaSimulacao com o nome de 'telaSimulacao'
            TelaSimulacao telaSimulacao = new TelaSimulacao();

            //Abre a tela de simulacao
            telaSimulacao.Show();

            //Fecha a tela atual
            telaAtual.Close();

        }

        //Define ações que serão executadas após o clique do botão 'buttonExibirRelatorioRepaginado'
        private void buttonExibirRelatorioRepaginado_Click(object sender, EventArgs e)
        {

            //Executa todos os métodos que execução de seleção de conteúdo das tabelas
            SelecionaConteudoSimulacoes();
            SelecionaConteudoAlvo();
            SelecionaConteudoProjetil();
            SelecionaConteudoUsuario();

            //Cria uma string que contém o caminho do arquivo do PowerBI
            //ESSE CAMINHO DEVE SER ALTERADO CONFORME A NECESSIDADE DO USUARIO E DA MÁQUINA NA QUAL O SOFTWARE ESTÁ SENDO EXECUTADA
            string caminhoRelatorioPaginado = @"D:\Heitor\FESA\PBL\PPL_Main\RelatorioPaginado\PBL_-_Relatorio_Paginado.pbix";

            //Executa o método que abre o arquivo PowerBI, referenciando o caminho do arquivo do PowerBI
            AbrirArquivoPBIX(caminhoRelatorioPaginado);
            
        }

        //Define ações que serão executadas após o clique do botão 'buttonConferirResultadosAnteriores'
        private void buttonConferirResultadosAnteriores_Click(object sender, EventArgs e)
        {

            //Define um novo objeto que referencia o visual do WindowsForms atual
            Form telaAtual = Form.ActiveForm;

            //Inicia a criação de um novo objeto que referencia a TelaResultadosAnteriores com o nome de 'telaResultadosAnteriores'
            TelaResultadosAnteriores telaResultadosAnteriores = new TelaResultadosAnteriores();

            //Abre tela de Resultados Anteriores
            telaResultadosAnteriores.Show();

            //Fecha a tela atual
            telaAtual.Close();

        }

        //Define ações que serão executadas após o clique do botão 'sairButton'
        private void sairButton_Click(object sender, EventArgs e)
        {

            //Define um novo objeto que referencia o visual do WindowsForms atual
            Form telaAtual = Form.ActiveForm;

            //Inicia a criação de novo objeto que referencia a TelaInicio com o nome de 'telaInicio'
            TelaInicio telaInicio = new TelaInicio();

            //Abre tela de Inicio
            telaInicio.Show();

            //Fecha tela atual
            telaAtual.Close();

        }
    }
}
