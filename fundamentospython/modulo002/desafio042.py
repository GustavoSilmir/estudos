print("-=" * 20)
print("Analisador de Triângulos")
print("-=" * 20)

r1 = float(input("Primeiro segmento: "))
r2 = float(input("Segundo segmento: "))
r3 = float(input("Terceiro segmento: "))

if r1 < r2 + r3 and r2 < r1 + r3 and r3 < r1 + r2:
    # Adicionei um espaço no final da string para a palavra não ficar grudada
    print("Os segmentos acima PODEM FORMAR UM TRIÂNGULO ", end="")

    if r1 == r2 == r3:  # Corrigido: r1 == r2 == r3
        print("EQUILÁTERO!")
    elif r1 != r2 and r2 != r3 and r1 != r3:  # Corrigido: comparações explícitas
        print("ESCALENO!")
    else:
        print("ISÓSCELES!")
else:
    print("Os segmentos acima NÃO PODEM FORMAR TRIÂNGULO!")