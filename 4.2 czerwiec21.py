
f= open("przyklad.txt","r")
chars = f.read()
chars_list = list(chars.split())
word_list = []

for x in range(0,50):
    word_list.append(chars_list[20*x +19][x])
print(''.join(word_list))