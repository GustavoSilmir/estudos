def fatorial(n, show=False):
    """
    -> Doc string para usar o help
    """
    f = 1
    for c in range(n, 0, -1):
        if show:
            print(c, end='')
            if c > 1:
                print(' X ', end='')
            else:
                print(' = ', end='')
        f *= c
    return f


# Programa Principal
help(fatorial)
print(fatorial(5, show=True))