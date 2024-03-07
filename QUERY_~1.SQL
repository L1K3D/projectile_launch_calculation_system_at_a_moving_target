/*

CEFSA - Centro Educacional da Fundação Salvador Arena
FESA - Faculdade Engenheiro Salvador Arena
PBL - Projeto Integrador Entre Disciplinas
Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

-----Alunos Envolvidos------

Erikson Vieira Queiroz - RA: 082220021
Enzo Brito Alves de Oliveira - RA: 082220040
Guilherme Alve Barbosa - RA: 082220014
Heitor Santos Ferreira - RA: 081230042
Tainara do Nascimento Casimiro - RA: 082220011
William Santim - RA: 082220033

Engenharia de Computação - Terceiro Semestre - EC3

-----Disciplinas Envolvidas-----
Programação Orientada a Objetos | Professora Leide Vieira
Calculo Avançado | Professor Daniel Giglio
Física Geral e Experimental II | Professor João Lamesa
Banco de Dados II | Professor Flávio Viotti

*/

---------------------------------------------------------------------------------------------------

USE PBLDB;

---------------------------------------------------------------------------------------------------

DROP TABLE simulacoes;

CREATE TABLE simulacoes
(

    id_simulacao INT PRIMARY KEY,
    id_projetil INT FOREIGN KEY REFERENCES projetil(id_projetil),
    id_alvo INT FOREIGN KEY REFERENCES alvo(id_alvo),
    angulo_trajetoria_projetil DECIMAL(10,2),
    velocidade_inicial1_projetil DECIMAL(10,2),
    velocidade_inicial2_projetil DECIMAL(10,2),
    velocidade_usada_projetil DECIMAL(10,2),
    tempo_de_voo_projetil DECIMAL(10,2),
    tipo_movimento_projetil VARCHAR(30),
    existencia_resolucao_real_angulo_fornecido VARCHAR(3),
    altura_inicial_alvo DECIMAL(10,2),
    distancia_canhao_alvo DECIMAL(10,2),
    velocidade_inicial_alvo DECIMAL(10,2),
    angulo_maximo_acerto_alvo DECIMAL(10,2),
    tempo_ate_atingir_solo_alvo DECIMAL(10,2)

);

SELECT *
FROM simulacoes;

---------------------------------------------------------------------------------------------------

DROP TABLE usuarios;

CREATE TABLE usuarios
(

    id_usuario INT PRIMARY KEY,
    nome_usuario VARCHAR(25),
    senha_usuario VARCHAR(25)

)

SELECT *
FROM usuarios;

---------------------------------------------------------------------------------------------------

DROP TABLE alvo;

CREATE TABLE alvo
(

    id_alvo INT PRIMARY KEY,
    altura_inicial_alvo DECIMAL(10,2),
    distancia_canhao_alvo DECIMAL(10,2),
    velocidade_inicial_alvo DECIMAL(10,2),
    angulo_maximo_acerto_alvo DECIMAL(10,2),
    tempo_ate_atingir_solo_alvo DECIMAL(10,2)

);

SELECT *
FROM alvo;

---------------------------------------------------------------------------------------------------

DROP TABLE projetil;

CREATE TABLE projetil
(

    id_projetil INT PRIMARY KEY,
    angulo_trajetoria_projetil DECIMAL(10,2),
    velocidade_inicial1_projetil DECIMAL(10,2),
    velocidade_inicial2_projetil DECIMAL(10,2),
    velocidade_usada_projetil DECIMAL(10,2),
    tempo_de_voo_projetil DECIMAL(10,2),
    tipo_de_movimento_projetil VARCHAR(30),
    existencia_resolucao_real_angulo_fornecido VARCHAR(3)

);

SELECT *
FROM projetil;