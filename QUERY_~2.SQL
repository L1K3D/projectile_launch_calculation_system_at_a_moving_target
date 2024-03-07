USE PBLDB;

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