f = open("przyklad.txt","r")
chars = f.read()
chars_list = list(chars.split())
palidroms = []
letters = []

for i in range(len(chars_list)):

    if chars_list[i][1:] == (chars_list[i][1:])[::-1] or (chars_list[i][1:])[::-1] == chars_list[i][1:]:
        palidroms.append(chars_list[i])
for j in range(len(palidroms)):
    letters .append(palidroms[j][25])
print(''.join(letters))