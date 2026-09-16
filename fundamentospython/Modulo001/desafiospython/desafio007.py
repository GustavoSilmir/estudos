nome = input("Digite o nome do aluno: ")
nota1 = float(input("Digite a primeira nota do aluno {}: ".format(nome)))
nota2 = float(input("Digite a segunda nota do aluno {}: ".format(nome)))
media = (nota1 + nota2) / 2
print('O aluno {} teve as notas {} e {} portanto sua média é de {}'.format(nome, nota1,nota2,media))

