str = input()
usedChars = ""
for i in str:
    if i not in usedChars:
        print(i, ": ", str.count(i), " ")
        usedChars += i