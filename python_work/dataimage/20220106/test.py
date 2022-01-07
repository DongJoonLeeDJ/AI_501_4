import os

print(next(os.walk('img')))

a = [10,20,30,40,50]
i = -1

def doA():
    global i
    i= i+1
    yield a[i]

# print(next(doA()))
# print(next(doA()))
# print(next(doA()))

for i in doA():
    print(i)