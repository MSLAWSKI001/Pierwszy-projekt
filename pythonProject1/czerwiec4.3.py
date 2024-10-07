def czy_pierwsza(n):

    for x in range(2,n//2):
        if n % x == 0:
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