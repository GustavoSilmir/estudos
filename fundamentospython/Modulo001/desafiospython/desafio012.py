produto = float(input('Qual o preço do produto? '))
desconto = produto - (produto * (5 / 100))
print('O preço do produto {} com 5% de desconto fica {:.2f} '.format(produto, desconto))