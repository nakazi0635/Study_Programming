import math
a = int(input())
b = list(map(int, input().split()))
c = list(map(int, input().split()))
sum_1 = 0
for i in range(a):
    sum_1 += abs(b[i] - c[i])
print("{:.6f}".format(sum_1))
sum_2 = 0
for i in range(a):
    sum_2 += pow(abs(b[i] - c[i]), 2)
sum_2 = math.sqrt(sum_2)
print("{:.6f}".format(sum_2))
sum_3 = 0
for i in range(a):
    sum_3 += abs(b[i] - c[i]) * abs(b[i] - c[i]) * abs(b[i] - c[i])
print("{:.6f}".format(sum_3 ** (1 / 3)))
chev = []
for i in range(a):
    chev.append(abs(b[i] - c[i]))
print("{:.6f}".format(max(chev)))