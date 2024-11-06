<<<<<<< HEAD
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
for row in rows :
    row = row.strip()
    firstDigit = -1
    secondDigit = -1

    for char in row :
        if char.isdigit() and firstDigit == -1 :
            firstDigit = char
        elif char.isdigit() :
            secondDigit = char
            asciiCode = firstDigit + secondDigit

            if 65 <= int(asciiCode) <= 90 :
                letter = chr(int(asciiCode))
                password += letter

        if password.endswith('XXX') :
            break

print(password)
=======
file = open('przyklad2.txt', 'r')
rows = file.readlines()

password = ''
for row in rows :
    row = row.strip()
    number1 = -1

    for char in row :
        if char.isdigit() and number1 == -1 :
            number1 = char
        elif char.isdigit() :
            number2 = char
            asciiCode = number1 + number2

            if 65 <= int(asciiCode) <= 90 :
                letter = chr(int(asciiCode))
                password += letter

        if password.endswith('XXX') :
            break

print(password)
>>>>>>> 188d7b4c3bc0890ab6d9eab179d3367ae0f7bcaf
