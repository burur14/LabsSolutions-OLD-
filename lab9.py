def getNumOfEachChar(line):
    usedChars = ""
    result = ""
    for i in line:
        if i not in usedChars:
            result += str(i) + ": " + str(line.count(i)) + " \n"
            usedChars += i
    return result


inp = input()
res = getNumOfEachChar(inp)
print(res)
