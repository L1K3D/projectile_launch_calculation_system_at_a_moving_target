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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

//Decalarando o local e namespace no qual o código está alocado
namespace PPL_Main.Telas
{

    //Cria a classe de execução da tela
    public partial class TelaBemVindo : Form
    {

        //Cria um instanciamento inicial que inicializa a tela/Visual do WindowsForms
        public TelaBemVindo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Cria método que realiza a abertura do script em python que verifica a instalação das bibliotecas necessárias para geração do gráfico ao final da execução da simulação excecutada na tela "TelaSimulacao"
        private void AbreScriptPython()
        {

            //O CAMINHO DO SCRIPT EM PYTHON DEVE SER ALTERADO CONFORME A MÁQUINA/COMPUTADOR QUE ESTIVER EXECUTANDO O PROGRAMA
            Process.Start("python", @"D:\Heitor\FESA\PBL\PPL_Main\PythonScripts\VerificacaoBibliotecas.py");

        }

        //Define ações que serão executadas ao clique do botão "buttonComecar"
        private void buttonComecar_Click(object sender, EventArgs e)
        {

            //Cria um novo objeto a partir da classe "TelaInicio" e chama esse objeto com o nome de variavel "telaInicio"
            TelaInicio telaInicio = new TelaInicio();

            //Realiza a abertura da TelaInicio chamando método nativo de exibição da tela
            telaInicio.Show();

            //Realiza a execução do método "AbreScriptPython"
            AbreScriptPython();

        }

        //Define ações que serão executadas ao clique do botão "buttonObterAjuda"
        private void buttonObterAjuda_Click(object sender, EventArgs e) //O método de clique recebe dois parametros pré-definidos, o parametro de 'sender' evoca um navegador local do computador no qual o software é executado e a classe de execuções de biblioteca "EventArgs" relaciona o navegador com o link definido dentro da função
        {

            //Evoca uma variavel do tipo string que recebe o link no qual está contido o manual de adaptação do programa
            string link = "https://cefsaedu-my.sharepoint.com/:b:/g/personal/081230042_faculdade_cefsa_edu_br/ERTnZcyvB6tIhF7dagOHdjoBDShYotL-jhdbEthOMqIxiQ?e=5IfLfa";

            //Executa a aberura do link por meio do processo de System Diagnostics
            System.Diagnostics.Process.Start(link);

        }

        //Define ações que serão executadas ao clieque do botão "buttonSair"
        private void buttonSair_Click(object sender, EventArgs e)
        {

            //Realiza o encerramento da aplicação de uma maneira geral.
            Application.Exit();
        }
    }
}
