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

    //Define a classe "MetodoFatorial" como publica
    public class MetodoFatorial
    {

        //Declarando o método de calcular a Fatorial
        public static double CalculaFatorial(int n) //Nesse meio, o método é declarado como público e seu tipo de retorno é definido como 'double', recebendo um valor do tipo inteiro chamado de 'n' que durante o decorrer do código e a aplicação desse método ao decorrer da construção do software em geral, será responsável por determinar o número de valores a ser incluido na fatorial
        {
            //Determina uma variavel de nome 'valorFatorial' como inteiro e atribui um valor inicial de 1 (um) para ela
            int valorFatorial = 1;

            //Verifica o valor do número de fatoriais a ser realizado. Caso o valor seja maior que 0 (zero)
            if (n > 0)
            {

                //Cria um laço de repetição/verificação, onde o número determinado dentro da função recebe o valor de 'n', julgando que ele seja maior que zero e regresse um em sua sequencia natural
                for (int i = n; i > 0; i--)
                {
                    //Adiciona uma múltiplicação dinamica e iterativa a variavel de 'valorFatorial'
                    valorFatorial *= i;
                }
            }

            //Retorna o valor atribuido a variavel 'valorFatorial' em sua condição final
            return valorFatorial;
        }

    }
}
