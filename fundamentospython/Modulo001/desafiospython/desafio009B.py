valor = int(input('Digite um valor: '))
contador = 1
while (contador <= 10):
    multi = valor * contador
    print('{} x {} = {}'.format(valor,contador,multi))
    contador = contador + 1