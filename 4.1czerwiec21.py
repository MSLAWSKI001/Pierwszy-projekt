f = open("przyklad.txt","r")
chars = f.read()
print(chars.count("0")+chars.count("1")+chars.count("2")+chars.count("3")+chars.count("4")+chars.count("5")+chars.count("6")+chars.count("7")+chars.count("8")+chars.count("9"))
