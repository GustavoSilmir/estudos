from random import randint
from time import sleep

itens = ('Pedra', 'Papel', 'Tesoura')
computador = randint(0, 2)

print('''Suas opções:
[ 1 ] PEDRA
[ 2 ] PAPEL
[ 3 ] TESOURA
''')

jogador = int(input('Qual é a sua jogada? ')) - 1

# Valida se o jogador digitou 1, 2 ou 3 (índices 0, 1 ou 2)
if jogador < 0 or jogador > 2:
    print('JOGADA INVÁLIDA! Escolha entre 1, 2 ou 3.')
else:
    # Só roda o suspense se a jogada for válida
    print('JO')
    sleep(0.5)
    print('KEN')
    sleep(0.5)
    print('PO!!')
    
    print('-=' * 11)
    print(f'Computador jogou: {itens[computador]}')
    print(f'Jogador jogou:    {itens[jogador]}')
    print('-=' * 11)

    if computador == 0:  # Computador jogou PEDRA
        if jogador == 0:
            print('EMPATE!')
        elif jogador == 1:
            print('JOGADOR VENCE!')
        elif jogador == 2:
            print('COMPUTADOR VENCE!')

    elif computador == 1:  # Computador jogou PAPEL
        if jogador == 0:
            print('COMPUTADOR VENCE!')
        elif jogador == 1:
            print('EMPATE!')
        elif jogador == 2:
            print('JOGADOR VENCE!')

    elif computador == 2:  # Computador jogou TESOURA
        if jogador == 0:
            print('JOGADOR VENCE!')
        elif jogador == 1:
            print('COMPUTADOR VENCE!')
        elif jogador == 2:
            print('EMPATE!')