f= open("przyklad.txt","r")
number = f.read()
numbers = list(number.split())
maxabs = 0
last_numbers = []
print(numbers)
reverse_numbers = list(number[::-1].split())[::-1]
print(reverse_numbers)
for x in range(len(numbers)):
    y = 0
    y = int(numbers[x]) - int(reverse_numbers[x])
    if abs(y) > maxabs:
        maxabs = abs(y)
        last_numbers.append(numbers[x])
print(last_numbers[-1],maxabs)