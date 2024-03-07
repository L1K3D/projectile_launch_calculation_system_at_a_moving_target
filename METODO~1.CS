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

    //Referenciando a classe de "MetodoCosseno" como pública
    public class MetodoCosseno
    {

        //Criando função principal da classe que realiza o cálculo do Cosseno
        public static double CalculaCosseno(double x) //A função é declarada com um meio de público e estático, recebendo um valor em meio 'double' que é chamado de 'x'. Durante o uso dessa função ao decorrer do calculo, o valor de 'x' é geralmente recebido como o valor do ângulo em radianos a ser calculado
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

            //Cria um laço de repetição 'while' que tem sua continuação mantida, determinada pelo atingimento da precisão desejada
            while (!precisaoDesejadaAlcancada)
            {

                //Realiza a criação de diversas determinações de calculo
                //O primeiro 'if' realiza a verificação do valor de 'k', onde, caso o mesmo esteja zerado, recebe a interação de um valor '1' (um).
                if (k == 0)
                {
                    valorFuncaoF += 1; //Adiciona o valor de '1' (um) a várivale que recebe o valor da função
                }
                //Essa condição julga o valor de K entre divisões de sobra e recebimento de determinantes diferentes de zero
                else if (k >= 1 && k % 2 == 0 && k % 4 != 0)
                {
                    valorFuncaoF += (-1) * Math.Pow(x, k) / MetodoFatorial.CalculaFatorial(k); //O valor da função recebe então a iteração de um valor determinado pela conta matemática aplicada, que nesse caso é: o valor de -1, vezes a elevada do valor de 'x' pelo número de iterações correspondente no momento dividio pela fatorial do valor das iterações correspondentes. O valor da fatorial é calculado evocando a classe "MetodoFatorial" e a função "CalculaFatorial"
                }
                //Essa condição julga o valor de K entre as sobras dos valores obtidos pelo mesmo após cada iteração
                else if (k >= 1 && k % 4 == 0)
                {
                    valorFuncaoF += (Math.Pow(x, k)) / MetodoFatorial.CalculaFatorial(k); //O valor da função recebe então a iteração de um valor determinado pela conta matemática aplicada, que nesse caso é: a elevada do valor de 'x' pelo número de iterações correspondente no momento dividio pela fatorial do valor das iterações correspondentes. O valor da fatorial é calculado evocando a classe "MetodoFatorial" e a função "CalculaFatorial"
                }

                //Determina um valor para a variavel "raizFuncaoF" declarada anteriormente
                raizFuncaoF = (Math.Pow(Math.Abs(x), (k + 1)) / MetodoFatorial.CalculaFatorial(k + 1)); //O valor da variavel é determinado pela elevação do valor em modulo de 'x' pelo número de iterações mais um, divido pela fatorial do valor da iteração mais um. O valor da fatorial é calculado evocando a classe "MetodoFatorial" e a função "CalculaFatorial"

                //Realiza a verificação perante o julgamento de que caso o valor da raiz da função calculada seja menor ou igual o valor da precisão desejada, a variavel de nível de julgamento 'verdadeiro' ou 'falso' ('bool') criada anteriormente, é definida como verdadeira
                if (raizFuncaoF <= precisaoDesejada)
                {
                    precisaoDesejadaAlcancada = true; //Define a variavel do tipo 'bool' como true, nesse momento, o loop while é interrompido
                }
                //Caso a verificação realizada no 'if' falhe, é adiciona mais uma iteração a variavel 'k'
                else
                {
                    k += 1;
                }
            }

            //Declara o retorno do valor da função em F como valor da função
            return valorFuncaoF;
        }
    }
}