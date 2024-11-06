<<<<<<< HEAD
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
for row in rows:
    row = row.strip()
    wordFirst = row + row[0]

    if wordFirst == wordFirst[::-1]:
        password += wordFirst[len(wordFirst)  // 2]

=======
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
for row in rows:
    row = row.strip()
    optionOne = row + row[0]

    if optionOne == optionOne[::-1]:
        password += optionOne[len(optionOne)  // 2]

>>>>>>> 188d7b4c3bc0890ab6d9eab179d3367ae0f7bcaf
print(password)