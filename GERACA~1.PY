# CEFSA - Centro Educacional da Fundação Salvador Arena
# FESA - Faculdade Engenheiro Salvador Arena
# PBL - Projeto Integrador Entre Disciplinas
# Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

# -----Alunos Envolvidos------

# Erikson Vieira Queiroz - RA: 082220021
# Enzo Brito Alves de Oliveira - RA: 082220040
# Guilherme Alve Barbosa - RA: 082220014
# Heitor Santos Ferreira - RA: 081230042
# Tainara do Nascimento Casimiro - RA: 082220011
# William Santim - RA: 082220033

# Engenharia de Computação - Terceiro Semestre - EC3

# -----Disciplinas Envolvidas-----
# Programação Orientada a Objetos | Professora Leide Vieira
# Calculo Avançado | Professor Daniel Giglio
# Física Geral e Experimental II | Professor João Lamesa
# Banco de Dados II | Professor Flávio Viotti

# Importando bibliotecas
import time as tm
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd
import os

# Exibindo cabeçalho
print("#--------------------------------#")
print("Iniciando processamento do gráfico")
print("#--------------------------------#")
print("")

# Localizando pasta onde o arquivo que contém os dados simulados se localiza
pasta_documentos = os.path.expanduser('~\oneDrive\Documentos\PBLGeracaoGrafico')

# Percorrendo pasta e localizando todos os arquivos
files = os.listdir(pasta_documentos)

# Listando arquivos
for file in files:
    print(file)
    arquivo_dados_simulacao = pd.read_table(f'{pasta_documentos}\{file}', sep=';', dtype=str, engine='python').astype(str)
print("")

# Convertendo arquivo para um DataFrame em pandas
df_arquivo_dados_simulacao = pd.DataFrame(arquivo_dados_simulacao)

#---------------#
# Obtendo dados para o projetil
print("#---Capturando os dados para o projétil---#")
print("")
tm.sleep(1)
df_dados_projetil = pd.DataFrame() # Cria novo DataFrame que ira guardar apenas os dados do projetil
df_dados_projetil = df_arquivo_dados_simulacao[["TempoDeVooProjetil", "MaximoTempoDeVooProjetil", "PosicaoEmYProjetil", "MaximoPosicaoEmYProjetil"]] # Selecionando apenas as colunas necessárias do DataFrame Principal
print(df_dados_projetil)
print("")
tm.sleep(1)

# Tratando os valores da coluna "PosicaoEmYProjetil" e exibindo valor na tela
projetil_posicao_em_y = df_dados_projetil["PosicaoEmYProjetil"].tolist()
projetil_posicao_em_y = projetil_posicao_em_y[0]
projetil_posicao_em_y = projetil_posicao_em_y.replace(',', '.')
projetil_posicao_em_y = float(projetil_posicao_em_y)
print(f"Posição em Y obtida para o projetil: {projetil_posicao_em_y}")
print("")
tm.sleep(1)

# Tratando os valores da coluna "MaximoPosicaoEmYProjetil" e exibindo valor na tela
projetil_max_posicao_em_y = df_dados_projetil["MaximoPosicaoEmYProjetil"].tolist()
projetil_max_posicao_em_y = projetil_max_posicao_em_y[0]
projetil_max_posicao_em_y = projetil_max_posicao_em_y.replace(',', '.')
projetil_max_posicao_em_y = float(projetil_max_posicao_em_y)
print(f"Posição máxima em Y obtida para o projetil: {projetil_max_posicao_em_y}")
print("")
tm.sleep(1)

# Tratando os valores da coluna "TempoDeVooProjetil" e exibindo valor na tela
projetil_tempo_voo = df_dados_projetil["TempoDeVooProjetil"].tolist()
projetil_tempo_voo = projetil_tempo_voo[0]
projetil_tempo_voo = projetil_tempo_voo.replace(',', '.')
projetil_tempo_voo = float(projetil_tempo_voo)
print(f"Tempo de voo obtido: {projetil_tempo_voo}")
print("")
tm.sleep(1)

# Tratando os valores da coluna "MaximoTempoDeVooProjetil" e exibindo valor na tela
projetil_max_tempo_voo = df_dados_projetil["MaximoTempoDeVooProjetil"].tolist()
projetil_max_tempo_voo = projetil_max_tempo_voo[0]
projetil_max_tempo_voo = projetil_max_tempo_voo.replace(',', '.')
projetil_max_tempo_voo = float(projetil_max_tempo_voo)
print(f"Tempo de voo máximo obtido para o projetil: {projetil_max_tempo_voo}")
print("")
tm.sleep(1)
print("")
print("#----------------------------#")
print("")

#---------------#

#Obtendo dados para o alvo 
print("#---Capturando os dados para o alvo---#")
print("")
df_dados_alvo = pd.DataFrame() # Cria novo dataFrame que irá comportar apenas os dados do alvo
df_dados_alvo = df_arquivo_dados_simulacao[["AlturaInicialAlvo", "PosicaoEmYAlvo", "MaximoPosicaoEmYAlvo"]] # Seleciona apenas as colunas que competem valores do alvo
print(df_dados_alvo)
print("")
tm.sleep(1)

# Tratando os valores da coluna "AlturaInicialAlvo" e exibindo valor na tela
alvo_altura_inicial = df_dados_alvo["AlturaInicialAlvo"].tolist()
alvo_altura_inicial = alvo_altura_inicial[0]
alvo_altura_inicial = alvo_altura_inicial.replace(',', '.')
alvo_altura_inicial = float(alvo_altura_inicial)
print(f"Altrura inicial obtida para o alvo: {alvo_altura_inicial}")
print("")
tm.sleep(1)

# Tratando os valores da coluna "PosicaoEmYAlvo" e exibindo valor na tela
alvo_posicao_em_y = df_dados_alvo["PosicaoEmYAlvo"].tolist()
alvo_posicao_em_y = alvo_posicao_em_y[0]
alvo_posicao_em_y = alvo_posicao_em_y.replace(',', '.')
alvo_posicao_em_y = float(alvo_posicao_em_y)
print(f"Posição em Y obtida para o alvo: {alvo_posicao_em_y}")
print("")
tm.sleep(1)

# Tratando os valores da coluna "MaximoPosicaoEmYAlvo" e exibindo valor na tela
alvo_max_posicao_em_y = df_dados_alvo["MaximoPosicaoEmYAlvo"].tolist()
alvo_max_posicao_em_y = alvo_max_posicao_em_y[0]
alvo_max_posicao_em_y = alvo_max_posicao_em_y.replace(',', '.')
alvo_max_posicao_em_y = float(alvo_max_posicao_em_y)
print(f"Posição máxima em Y obtida para o alvo: {alvo_max_posicao_em_y}")
print("")
tm.sleep(1)
print("")
print("#----------------------------#")
print("")

#---------------#

#Realiza conjunção de valores que serão exibidos no gráfico
print("#---Calculando arrays para serem implementados no gráfico---#")
print("")
tm.sleep(1)

print("-> Arrays de tempos <-")
tempos_projetil = np.linspace(0, projetil_tempo_voo, num=100)
tempos_alvo = np.linspace(0, projetil_max_tempo_voo, num=100)
print(tempos_projetil)
print("")

# Criando lista de posições do alvo
print("-> Arrays de alturas para o alvo <-")
alturas_alvo = np.linspace(alvo_altura_inicial, alvo_max_posicao_em_y, num=100)
print(alturas_alvo)
print("")

# Criando lista de posições do projetil
print("-> Arrays de alturas para o projetil <-")
alturas_projetil = np.linspace(0, projetil_posicao_em_y, num=100)
print(alturas_projetil)
print("")
tm.sleep(1)

print("")
print("#----------------------------#")
print("")

print("Gerando gráfico em... 5")
tm.sleep(1)
print("4")
tm.sleep(1)
print("3")
tm.sleep(1)
print("2")
tm.sleep(1)
print("1")
tm.sleep(1)
print("...")
tm.sleep(1)

# Realiza plotagem do gráfico
plt.plot(tempos_projetil, alturas_projetil, label='Projétil')
plt.plot(tempos_alvo, alturas_alvo, label='Alvo')
plt.xlabel('Tempo (s)')
plt.ylabel('Altura do Solo (m)')
plt.legend()
plt.title('Gráfico de Linhas Cruzadas')
plt.show()