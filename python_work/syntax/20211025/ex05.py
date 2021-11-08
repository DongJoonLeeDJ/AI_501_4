
# str = "this is 'apple'"
# print(str)
#
# str = 'this is "apple"'
# print(str)
#
# str = "this is \"apple\""
# print(str)
#
# str = 'this is \'apple\''
# print(str)

myT = tuple(range(0,100))+tuple(range(100,0,-1))
print(myT)

myT = tuple(a for a in range(0,100))+tuple(range(100,0,-1))
print(myT)