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

#Importando bibliotecas
import subprocess
import sys
import os
import time as tm

#Exibindo cabeçalho do programa
print("#-------------------------------------------------#")
print("Iniciando verificação de instalação das bibliotecas")
print("#-------------------------------------------------#")
print("")
tm.sleep(1)

#Criando função que verifica a instalação das bibliotecas
def verificar_instalacao(biblioteca):

    #Tenta realizar a conferencia de instalação
    try:
        subprocess.check_call([sys.executable, "-m", "pip", "show", biblioteca])
        return True
    
    #Caso o ocorra algum erro, exibe a mensagem de erro e retorna o atributo de falso
    except subprocess.CalledProcessError:
        return False
    
# Cria função que instala as bibliotecas
def instalar_bibliotecas(biblioteca):

    #Caso a biblioteca já esteja instalada, retorna a mensagem ao usuário dizendo que a mesma já se econtra instalada
    if verificar_instalacao(biblioteca):
        print (f"A biblioteca {biblioteca} já está instalada")
        print("")
        print("#----------------------------#")
        print("")

    # Caso retorne falso, a instalação da biblioteca é realizada
    else:

        # Cria laço de tentativa, onde o script tenta realizar a instalação de maneira comum, usando os statements sistemicos do pip install, descartando a função master por '-m'
        try:
            subprocess.check_call([sys.executable, "-m", "pip", "install", biblioteca])
            print(f"Instalação bem-sucedida! Biblioteca {biblioteca} instalada com sucesso!")
            print("")
            print("#----------------------------#")
            print("")

        # Caso a instalação por meios comuns retorne algum erro, uma exceção é gerada e retorna uma mensagem de erro
        except subprocess.CalledProcessError as e:
            print(f"Erro durante a instalação da biblioteca {biblioteca}: {e}")
            print("")
            print("#----------------------------#")
            print("")

# Passa a lista de bibliotecas que serão instaladas
lista_bibliotecas_instalacao = ["matplotlib", "numpy", "requests", "pandas"]

# Cria laço de repetição para o uso da função de instalar biblioteca
for biblioteca in lista_bibliotecas_instalacao:
    instalar_bibliotecas(biblioteca)

# Exibe cabeçalho final
print("#-------------------------------------------------------#")
print("Conferencia e instalação de pacotes realizada com sucesso")
print("#-------------------------------------------------------#")
tm.sleep(5)