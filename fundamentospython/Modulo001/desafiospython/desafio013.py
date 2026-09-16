sal = float(input('Qual salário do funcionário?R$: '))
ajuste = sal + (sal * (15 / 100))
print('O salário R$ {:.2f} com reajuste passa a ser {:.2f}'.format(sal, ajuste))