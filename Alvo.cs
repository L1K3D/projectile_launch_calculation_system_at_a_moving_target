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

//Evoca a biblioteca "System", referenciando a suas funções gerenêricas
using System;

//Define o namespace em que o código está inserido
namespace PPL_Main.CodigosMain
{

    //Declarando a classe/objeto alvo como publico
    public class Alvo
    {

        //Delcrando atributos
        private double alturaInicialAlvo;
        private double distanciaDoCanhaoAlvo;
        private double tempoAteAtingirSoloAlvo;
        private double velocidadeAlvo;
        private double anguloMaximo;
        private double posicaoEmYAlvo;

        //Gerando encapsulamento para os atributos necessários
        //Gerando encapsulamento para o atributo "alturaInicialAlvo"
        public double AlturaInicialAlvo
        {
            get { return alturaInicialAlvo; }
            set { alturaInicialAlvo = value; }
        }

        //Gerando encapsulamento para o atributo "distanciaDoCanhaoAlvo"
        public double DistanciaDoCanhaoAlvo
        {
            get { return distanciaDoCanhaoAlvo; }
            set { distanciaDoCanhaoAlvo = value; }
        }

        //Gerando encapsulamento para o atributo "velocidadeAlvo"
        public double VelocidadeAlvo
        {
            get { return velocidadeAlvo; }
            set { velocidadeAlvo = value; }
        }

        //Gerando encapsulamento para o atributo "tempoAteAtingirSoloAlvo"
        public double TempoAteAtingirSoloAlvo
        {
            get { return tempoAteAtingirSoloAlvo; }
            set { tempoAteAtingirSoloAlvo = value; }
        }

        //Gerando encapsulamento para o atributo "anguloMaximo"
        public double AnguloMaximo
        {
            get { return anguloMaximo; }
            set { anguloMaximo = value; }
        }

        //Gerando encapsulamento para o atributo "posicaoEmYAlvo"
        public double PosicaoEmYAlvo
        {
            get { return posicaoEmYAlvo; }
            set { posicaoEmYAlvo = value; }
        }

        //Criando métodos da classe para melhorar processamento futuros
        //Criando método que realiza calculo do tempo que decorre até que o alvo atinja o solo
        public void CalculaTempoAteAtingirSoloAlvo()
        {

            TempoAteAtingirSoloAlvo = (AlturaInicialAlvo / VelocidadeAlvo); //Atribui o atributo antes declarado "TempoAteAtingirSoloAlvo" com o valor do resultado da divisão entre a altura inical do alvo ("AlturaInicialAlvo") e a velocidade inicial do alvo ("VelocidadeAlvo")
            TempoAteAtingirSoloAlvo = Math.Round(TempoAteAtingirSoloAlvo, 2); //Realiza o arredondamento do valor no caso de valores do resultado gerarem mais de duas virgulas após a casa decimal comum

        }

        //Criando método que realiza o calculo do angulo máximo de lançamento que o projetil precisa ter para atingir o alvo com sucesso
        public void CalculaAnguloMaximo()
        {

            AnguloMaximo = (Math.Atan(AlturaInicialAlvo / DistanciaDoCanhaoAlvo)) * 180 / Math.PI; //Atribui o atributo antes declarado "AnguloMaximo" com o valor do resultado da tangente do valor entre a altura inicial do alvo ("AlturaInicialAlvo") e a distância do alvo até o canhão ("DistanciaDoCanhaoAlvo")
            AnguloMaximo = Math.Round(AnguloMaximo, 2); //Realiza o arredondamento do valor obtido no caso de valores do resultado gerarem mais de duas virgulas após a casa decimal comum

        }

    }
}
