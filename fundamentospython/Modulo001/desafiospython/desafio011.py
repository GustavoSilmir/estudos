altura = float(input('Qual altura da sua parede em m²? '))
largura = float(input('Qual a largura da sua parede em m²? '))
area = altura * largura
tinta = area / 2
print('Para pintar uma parede de {} m² será necessário {:.2f} litros de tinta'.format(area,tinta))