import math
an = float(input('Digite o ângulo que você deseja: '))
seno = math.sin(math.radians(an))
print('O ângulo de {} tem o Seno de {:.2f}'.format(an, seno))
cosseno = math.cos(math.radians(an))
print('O ângulo de {} tem o Cosseno de {:.2f}'.format(an, cosseno))
tan = math.tan(math.radians(an))
print('O ângulo de {} tem o Tangente de {:.2f}'.format(an, tan))