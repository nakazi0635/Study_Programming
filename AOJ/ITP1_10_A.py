str_1 = input()
q = int(input())
for i in range(q):
    x = [a for a in input().split()]
    a = int(x[1])
    b = int(x[2])
    if x[0] == 'replace':
        p = x[3]
        str_1 = str_1[:a] + p + str_1[b + 1:]
    elif x[0] == 'print':
        print(str_1[a:b + 1])
    else:
        c = str_1[a:b + 1]
        str_1 = str_1[:a] + c[::-1] + str_1[b + 1:]