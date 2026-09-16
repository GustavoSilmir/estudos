#exercicio apenas opcional, pois a biblioteca nao funciona mais tocar mp3 e nem baixei arquivos
import pygame #teria que instalar o pacote pygame - não baixei ele 
pygame.init()
pygame.mixer.music.load('localdoarquivo.mp3')
pygame.mixer.music.play()
pygame.event.wait()