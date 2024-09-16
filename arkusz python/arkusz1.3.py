f = open("mecz_przyklad.txt", "r")
letter = f.read()
letters = list(letter)
print(letters)

streak_a = 0
streak_b = 0
goodstreak_a = 0
goodstreak_b = 0

x=letters.__len__()-1
for a in range(x):
    if letters[a - 1] == letters[a] and letters[a-1] == "A":
        streak_a+=1
        streak_b = 0
    else:
        streak_b+=1
        streak_a = 0
    if streak_a == 10:
        goodstreak_a+= 1
    if streak_b == 10:
        goodstreak_b += 1
print(goodstreak_a)
print(goodstreak_b)