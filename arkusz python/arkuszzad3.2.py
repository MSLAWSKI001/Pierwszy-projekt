from sympy import *

f = open("liczby_przyklad.txt","r")
n = f.read()
counter = 0
letters = list(n.split())

print(letters)

dlugosc = letters.__len__()

for i in range(dlugosc):
    if print(isprime(int(letters[i]) - 1)):
        counter = counter + 1
print(counter)