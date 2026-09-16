n1 = float(input('Primeira nota: '))
n2 = float(input('Segunda nota: '))
media = (n1 + n2) / 2
print('Com a nota {:.1f} e {:.1f}.Sua média foi de {:.1f}'.format(n1,n2,media))
if 7 > media >= 5:
    print('O aluno está em RECUPERAÇÃO.')
elif media < 5:
    print('O ALUNO ESTÁ REPROVRADO')
else:
    print('O ALUNO ESTA APROVADO!')