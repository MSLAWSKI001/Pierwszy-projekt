f = open("przyklad.txt","r")
chars = f.read()
chars_list = list(chars.split())
digitals = []
ifdigitals = []

for i in range(len(chars_list)):
    for j in range(len(chars_list[i])):
        if chars_list[i][j].isnumeric():

            digitals.append(chars_list[i][j])


for k in range(len(digitals)):
    x =digitals[k] + digitals[k+1]
    print(ascii(x))

    digitals.pop(k+1)
