a, b = map(int, input().split())
array1 = [list(map(int, input().split()))for i in range(a)]
# print(array1)
array2 = [int(input()) for i in range(b)]
# print(array2)
array3 = [0 for i in range(a)]
# print(array3)
for i in range(a):
    for j in range(b):
        # print(array1[i][0] * array2[0],array1[i][1] * array2[i],array1[i][2] * array2[2],array1[i][3] * array2[3])
        array3[i] += array1[i][j] * array2[j]
for i in array3:
    print(i)
