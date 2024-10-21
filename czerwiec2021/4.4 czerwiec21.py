f = open("przyklad.txt","r")
chars = f.read()
chars_list = list(chars.split())
digitals = []
letters = []
digitals_counter_in_single_line = 0
X_counter = 0

for i in range(len(chars_list)):
    if not digitals_counter_in_single_line % 2 == 0:
        digitals.pop(-1)
    for j in range(len(chars_list[i])):
        if chars_list[i][j].isnumeric():
            digitals_counter_in_single_line += 1
            digitals.append(chars_list[i][j])

if not len(digitals) % 2 == 0:
        digitals.pop()
for k in range(0,len(digitals),2):
    x =digitals[k] + digitals[k+1]
    if 65 <= int(x) <= 90:
        letters.append(chr(int(x)))

        if int(x) == 88:
            X_counter += 1
            if X_counter == 3:
                print(''.join(letters))



