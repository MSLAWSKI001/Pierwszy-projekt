counter = 0
counterSecond = 0
file= open("przyklad.txt","r")
fileNumbers = file.read()
listOfNumbers = list(fileNumbers.split())

for i in range(len(listOfNumbers)):
    if listOfNumbers.count(listOfNumbers[i]) == 2:
        counter += 1
print(len(set(listOfNumbers)))

for i in range(len(listOfNumbers)):
    if listOfNumbers.count(listOfNumbers[i]) == 3:
        counterSecond += 1
result = counter / 2
print(int(result))

resultSecond = counterSecond / 3
print(int(resultSecond))
