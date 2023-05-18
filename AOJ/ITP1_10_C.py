import math
while True:
    a = int(input())
    sum_1 = 0
    if a == 0:
        break
    b = list(map(int, input().split()))
    c = sum(b) / len(b)
    # print(c)
    for i in b:
        sum_1 += (i - c) * (i - c)
    ans = math.sqrt(sum_1 / len(b))
    print("{:.8f}".format(ans))