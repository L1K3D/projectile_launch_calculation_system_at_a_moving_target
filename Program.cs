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

//Declarando as bibliotecas que serão utilizadas
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

//Criando a parte/namespace principal do programa
namespace PPL_Main
{
    //Criando a parte da classe executora do programa principal
    public class Program
    {

        //Cria uma string principal que recebe o grau de confidenciabilidade como público, e o valor do endereçamento do banco de dados.
        //ESSE VALOR DEVE SER ALTERADO CONFORME A MÁQUINA NO QUAL O SOFTWARE ESTÁ SENDO EXECUTADO
        public string enderecamentoBancoDeDados = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Heitor\\FESA\\PBL\\PPL_Main\\PPL_Main\\PBLDB.mdf;Integrated Security=True";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        //Realiza a criação da execução principal do software
        static void Main()
        {

            Application.EnableVisualStyles(); //Habilita os visuais do WindowsForms para serem inicializados corretamente
            Application.SetCompatibleTextRenderingDefault(false); //Desabilita a compatibilidade variável especifica de renderização de visuais do WindowsForms. Isso é desabilitado por padrão para que não ocorra problema de compatibilidade espefica causada pela execução de um mesmo software em diferentes computadores
            Application.Run(new Telas.TelaBemVindo()); //Executa a aplicação, abrindo por principio a Tela com o nome de 'TelaBemVindo'

        }
    }
}
