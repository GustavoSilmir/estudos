teclado = input("Digite alguma coisa: ")

somente_numero = teclado.isdigit()
apenas_letras = teclado.isalpha()
alfa_numero = teclado.isalnum()
tudo_maiusculo = teclado.isupper()
tudo_minusculo = teclado.islower()

print(f"Tem somente Números? {somente_numero}")
print(f"Tem somente Letras? {apenas_letras}")
print(f"Tem Números e Letras? {alfa_numero}")
print(f"Tudo Maiusculo? {tudo_maiusculo}")
print(f"Tudo Minúsculo? {tudo_minusculo}")