
# a = [1,2,3,4]
#
# a.append('문자열')
# a.append(55)
#
# print(a)

b = dict(a=44,c=22,d=33,b=11)

print(b)
print(b['a'])


for temp in b.items():
    print(temp)

alist = sorted(b.items() , key = lambda x : x[0])
print(alist)

blist = sorted(b.items() , key = lambda x : x[1])
print(blist)
