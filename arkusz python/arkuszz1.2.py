f = open("mecz.txt", "r")
letter = f.read()
a_count = 0
b_count = 0
odj = 0
letters = list(letter)
print(letters)
x=letters.__len__()
for a in range(x):

    if letters[a] == "A":
        a_count = a_count + 1
    if letters[a] == "B":
        b_count = b_count + 1

    odj = b_count - a_count
    abs(odj)
    print(odj)
    if (a_count == 1000 and  odj != 3) or (b_count == 1000 and odj != 3):
        print(a_count)
        print(b_count)
        exit()
print(a_count)
print(b_count)