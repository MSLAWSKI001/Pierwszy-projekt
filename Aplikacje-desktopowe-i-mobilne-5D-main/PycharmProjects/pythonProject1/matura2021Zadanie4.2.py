<<<<<<< HEAD
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
index = 0

for i in range(19, len(rows), 20):
    password += rows[i][index]
    index += 1

=======
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
index = 0

for i in range(19, len(rows), 20):
    password += rows[i][index]
    index += 1

>>>>>>> 188d7b4c3bc0890ab6d9eab179d3367ae0f7bcaf
print(password)