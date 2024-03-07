//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//PBL - Projeto Integrador Entre Disciplinas
//Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

//-----Alunos Envolvidos------

//Erikson Vieira Queiroz - RA: 082220021
//Enzo Brito Alves de Oliveira - RA: 082220040
//Guilherme Alves Barbosa - RA: 082220014
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
using System.Windows.Forms;

//Declarando nome da "namespace"/"ambiente" no qual o programa se encontra
namespace PPL_Main.Telas
{
    //Declarando a construção da tela incial
    public partial class TelaInicio : Form
    {

        //Instanciando construtor da TelaEntrar
        public TelaInicio()
        {
            InitializeComponent();
        }

        //Atribuindo ações para o botão de Entrar
        private void EntrarButton_Click(object sender, EventArgs e)
        {

            //Evoca um novo objeto da 'TelaEntrar' e atribui com o nome de 'telaEntrar'
            TelaEntrar telaEntrar = new TelaEntrar();

            //Exibe a TelaEntrar
            telaEntrar.Show();

        }

        //Atribuindo ações para o botão de "Sair"
        private void SairButton_Click(object sender, EventArgs e)
        {

            //Fechando a aplicação completamente
            Application.Exit();

        }

        //Definindo ações para o botão de "Cadastrar"
        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            //Evoca um novo objeto da 'TelaCadastrar' e atribui com o nome de 'telaCadastrar'
            TelaCadastrar telaCadastrar = new TelaCadastrar();

            //Exibe a TelaCadastrar
            telaCadastrar.Show();
        }
    }
}