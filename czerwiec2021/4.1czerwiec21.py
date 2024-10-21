f = open("przyklad.txt","r")
chars = f.read()
ans = 0
for i in range(10):
    ans += (chars.count(str(i)))
print(ans)

