f = open("przyklad.txt","r")
liczba = f.read()
liczby = list(liczba.split())
counter = 0
first_last_char = []
for i in range(len(liczby)):
    x = liczby[i]

    if x[0] == x[len(x)-1]:
        counter += 1
        first_last_char.append(x)
print(counter, first_last_char[0])
