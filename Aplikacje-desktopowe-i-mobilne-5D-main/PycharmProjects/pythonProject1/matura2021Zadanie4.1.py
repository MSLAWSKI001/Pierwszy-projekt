<<<<<<< HEAD
file = open('przyklad2.txt', 'r')
rows = file.read()

howManyNumbers = 0
for row in rows :
    row = row.strip()
    for char in row :
        if char.isdigit() :
            howManyNumbers += 1

print(howManyNumbers)
=======
file = open('przyklad2.txt', 'r')
rows = file.read()

howManyNumbers = 0
for row in rows :
    row = row.strip()
    for char in row :
        if char.isdigit() :
            howManyNumbers += 1

print(howManyNumbers)
>>>>>>> 188d7b4c3bc0890ab6d9eab179d3367ae0f7bcaf
