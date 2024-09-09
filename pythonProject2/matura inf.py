print("podaj liczbę")
n = (int(input()))
b = 0
mylist = []
while n > 0:
    i = n % 2

    mylist.append(i)
    n = n//2

reversed_list = mylist[::-1]

print(reversed_list)
x= reversed_list.__len__()

for a in range(x):
    if not reversed_list[a-1] == reversed_list[a]:
        b = b + 1

if mylist[0] == 1:
    b = b + 1

print("odpowiedź: "+str(b))


