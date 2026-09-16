import math
co = float(input('Comprimento do cateto oposto: '))
ca = float(input('Comprimento do cateto adjacente: '))
#hi = (co ** 2 + ca ** 2) ** (1/2) maneria correta da matemática
#abaixo maneira importando módulos
hi = math.hypot(co,ca)
print('O valor da hipotenusa é {:.2f}'.format(hi))
