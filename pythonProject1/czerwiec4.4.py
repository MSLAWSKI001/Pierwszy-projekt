counter = 0
counter2 = 0
f= open("przyklad.txt","r")
number = f.read()
numbers = list(number.split())
print(numbers)
print(len(set(numbers)))
for x in range(len(numbers)):
    if numbers.count(numbers[x]) == 2:
        counter += 1

result = counter / 2
print(int(result))
for x in range(len(numbers)):
    if numbers.count(numbers[x]) == 3:
        counter2 += 1

result2 = counter2 / 2
print(int(result2))
