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
    //Declarando o nome da classe como MetodoSeno e declarando ela como pública
    public class MetodoSeno
    {

        //Criando método princpal da classe, chamando de "CalcularSeno" e declarando o mesmo como público
        public static double CalcularSeno(double x) //Declara do valor da função como 'double', sendo assim, a mesma retornará um valor nesse tipo de dado. Define um valor de tipo 'double' como evocador da função, chamando o mesmo de 'x'. Ao decorrer do código e do uso da função em outros trechos do sofware, o valor de 'x' recebe o valor de angulos em radianos e desenvolve o valor do mesmo.
        {

            double precisaoDesejada = Math.Pow(10, -9); //Sugere uma precisão desejada, elevando o número 10 a uma visão de -9 vezes.

            bool precisaoDesejadaAlcancada = false; //Definie uma variavel como 'bool' para verificar o antingimento da precisão desejada, essa variavel é chamada ao decorrer do código quando a precisão alcançada é encontrada

            //Define a variavel 'k' como tipo inteiro, a variavel 'k' é o número de iterações a ser realizada, incialmente recebe o valor de '0'
            int k;
            k = 0;

            //Declara o valor da função que realiza a 'descoberta' do valor calculado como zero em uma primeira instancia
            double valorFuncaoF = 0;

            //Declara uma variavel que irá receber o valor da raiz da função
            double raizFuncaoF;

            // Define uma variavel que irá receber o valor de iterações, definindo ela como tipo inteiro e recebendo um valor inicial de -1
            int iteracao = -1;

            //Cria um laço de repetição while que tem como conidição de sua continuidade de execução o alcance da precisão desejada
            while (!precisaoDesejadaAlcancada)
            {

                //Cria a primeira verificação no iterador 'k', onde caso o mesmo seja igual a 1 (um), é adicionado uma interação do valor declarado em 'x' para o valor da função
                if (k == 1)
                {

                    valorFuncaoF += x;
                
                }

                //Realiza uma alternativa a verificação inicial, onde caso o valor do iterador 'k' tenha um valor de resto de divisão por dois diferente de zero, é adiicionada um valor na função de calculo.
                else if (k % 2 != 0)
                {

                    valorFuncaoF += iteracao * Math.Pow(x, k) / MetodoFatorial.CalculaFatorial(k); //Itera um valor no valor da função onde a variavel recebe o valor da iteração atual multiplicado pelo valor do ângulo elevado pelo número da iteração, divido pela fatorial do número da iteração. O valor da fatorial é calculado evocando a classe "MetodoFatorial" e a função "CalculaFatorial"
                    iteracao *= -1; //Eleva em modelo de iteração por menos um
                
                }

                //Define o valor da raiz da função F como 1 (um) dividido pela fatorial (O valor da fatorial é calculado evocando a classe "MetodoFatorial" e a função "CalculaFatorial") do número da iteração mais um, multiplicando esse resultado pelo valor da elevação do módulo do ângulo em radianos fornecido pelo número de iteração mais 1 (um)
                raizFuncaoF = (1 / MetodoFatorial.CalculaFatorial(k + 1)) * Math.Pow(Math.Abs(x), k + 1);

                //Realiza a construção de um segundo modelon de verificação. Esse segundo julga o atendimento da condição em que a raiz da função calculada seja menor ou igual ao valor da precisão desejada
                if (raizFuncaoF <= precisaoDesejada)
                {

                    precisaoDesejadaAlcancada = true; //Caso a verificação seja verdadeira, realiza a alteração da variavel que julga a continuidade do laço 'while' para 'true', interrompendo o funcionamento do mesmo.
                
                }

                //Caso a verificação não seja atendida, realiza a iteração do valor de 1 (um) do valor do iterador
                else
                {
                    k += 1;
                
                }

            }

            //Retorna o valor da função calculada
            return valorFuncaoF;
        
        }

    }
}
