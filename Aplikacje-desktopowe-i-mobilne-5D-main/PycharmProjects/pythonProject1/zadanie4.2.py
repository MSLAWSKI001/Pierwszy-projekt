file = open("przyklad.txt","r")
fileNumbers = file.read()
listOfNumbers = list(fileNumbers.split())
maxAbsolute = 0
lastNumber = 0

reverseNumbers = list(fileNumbers[::-1].split())[::-1]

for i in range(len(listOfNumbers)):
    if abs(int(listOfNumbers[i]) - int(reverseNumbers[i])) > maxAbsolute:
        maxAbsolute = abs(int(listOfNumbers[i]) - int(reverseNumbers[i]))
        lastNumber=listOfNumbers[i]

print(lastNumber,maxAbsolute)
