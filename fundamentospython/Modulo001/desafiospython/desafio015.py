dias = int(input("Quantos dias alugado? "))
km = float(input("Quantos km rodados? "))
pago = (dias * 60) + (km * 0.15)
print("O total a pagar por {} dias e {}km rodados é de R${:.2f}".format(dias, km, pago))