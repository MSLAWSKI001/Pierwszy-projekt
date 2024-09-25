

f= open("przyklad.txt","r")
liczba = f.read()
liczby = list(liczba.split())

czynniki = []
max_counter_1 = 0
max_counter_2 = 0
bigger_from_other = []
bigger_from_other_2 = []
couter = 0
def rozloz(n):

    k = 2
    while n != 1:
        while n % k == 0:
            n //= k
            czynniki.append(k)
        k += 1
    return czynniki

for i in range(len(liczby)):
    czynniki.clear()

    rozloz(int(liczby[i]))

    if max_counter_1 < len(czynniki):
        max_counter_1 = len(czynniki)
        bigger_from_other.append(liczby[i])

print(bigger_from_other[-1], max_counter_1)

for j in range(len(liczby)):
    czynniki.clear()
    couter = 0
    rozloz(int(liczby[j]))

    for k in range(len(czynniki)):
        if not czynniki[k-1] == czynniki[k]:
            couter += 1

            if max_counter_2 < couter:
                max_counter_2 = couter
                bigger_from_other_2.append(liczby[j])

print(bigger_from_other_2[-1],max_counter_2)
