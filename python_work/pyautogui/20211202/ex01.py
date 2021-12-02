


def doA(*args, **dictargs):
    print(args) # tuple
    a, b, c, d = args
    print(a)
    print(b)
    print(c)
    print(d)
    print(dictargs)
    for key, value in dictargs.items():
        print('key = ',key)
        print('value = ', value)


doA(11, 22, 'cc', 'bb', aa='aaa', bb='bbb')
