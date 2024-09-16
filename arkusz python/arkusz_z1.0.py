f = open("mecz_przyklad.txt", "r")
b = 0
letter = f.read()
letters = list(letter)
print(letters)
x=letters.__len__()
for a in range(x):
    if not letters[a-1] == letters[a]:
        b+=1
print(b)

