

file =open("przyklad.txt","r")
fileNumbers = file.read()
listOfNumbers = list(fileNumbers.split())

def isFirst(number):

    for i in range(2,number//2):
        if number % i == 0:
            return False
    return True

reversedNumbers = list(fileNumbers[::-1].split())[::-1]

for i in range(len(listOfNumbers)):
    if isFirst(int(listOfNumbers[i])) and isFirst(int(reversedNumbers[i])):
        print(listOfNumbers[i])