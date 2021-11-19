# for idx,value in enumerate(range(10,0,-1)):
#     print('idx',idx)
#     print('value', value)

# a = [0,1,2,3,4,5 ]
# b = ['a','b','c','d','e']
#
# for aele,bele in zip(a,b):
#     print('aele',aele,'bele',bele)


dica = {"a": 1, "b": 2, "c": 3}

for key in dica.keys():
    print(key)

for value in dica.values():
    print(value)

for key, value in dica.items():
    print('key', key, 'value', value)
