def czy_pierwsza(n):
    if n == 2:
        return True
    if n % 2 == 0 or n <= 1:
        return False

    pierw = int(n**0.5) + 1
    for dzielnik in range(3, pierw, 2):
        if n % dzielnik == 0:
            return False
    return True


f =open("przyklad.txt","r")
number = f.read()
numbers = list(number.split())
print(numbers)
reversed_numbers = list(number[::-1].split())[::-1]
print(reversed_numbers)
for x in range(len(numbers)):
    if czy_pierwsza(int(numbers[x])) and czy_pierwsza(int(reversed_numbers[x])):
        print(numbers[x])