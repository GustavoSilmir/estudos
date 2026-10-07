def area(larg,comp):
    a = larg * comp
    print(f'A Área de um tereno {larg}x{comp} é de {a}m².')

print(' Controle de Terrenos')
print('-' * 30)
l = float(input('LARGURA (m): '))
c = float(input('Comprimento (m): '))
area(l,c)