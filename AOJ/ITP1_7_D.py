a, b, c = map(int, input().split())
array1 = [list(map(int, input().split())) for i in range(a)]
array2 = [list(map(int, input().split())) for i in range(b)]
c = []
for i in range(len(array1)):
    row = []
    for j in range(len(array2[0])):
        sum = 0
        for k in range(len(array2)):
            sum += array1[i][k] * array2[k][j]
        row.append(sum)
    c.append(row)

for i in c:
    for j in i:
        print(j, end=" ")
    print()
