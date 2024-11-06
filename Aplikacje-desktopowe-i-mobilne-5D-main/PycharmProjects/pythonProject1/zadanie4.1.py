file = open("przyklad.txt","r")
fileNumbers = file.read()

fileNumbers = fileNumbers[::-1]

numbersSplited = list(fileNumbers.split())

print(numbersSplited)

for i in range(len(numbersSplited)):

    if int(numbersSplited[i]) % 17 == 0:
        print(numbersSplited[i])