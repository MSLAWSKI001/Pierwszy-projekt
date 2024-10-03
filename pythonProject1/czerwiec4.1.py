f = open("przyklad.txt","r")
number = f.read()
number = number[::-1]
numbers = list(number.split())[::-1]

for x in range(len(numbers)):

    if int(numbers[x]) % 17 == 0:
        print(numbers[x])
