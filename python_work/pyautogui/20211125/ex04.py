class A:
    def __init__(self,age,name):
        self.age = age
        self.name = name

    def __str__(self) -> str:
        return self.name+" : "+str(self.age)


a = [A(10,"aaa"),A(20,"bbb"),A(5,"ccc")]

a.sort(key = lambda aa:aa.age)

for ele in a:
    print(ele)


b = ["aaa",(12,33),[11,22,33]]
c = b
c[0]="bbb"

c[2][1]=33

print(b)
print(c)
print("리스트함수로 복사")

b = ["aaa",(12,33),[11,22,33]]
c = list(b)

c[0]="bbb"
c[1]=(1111,222)
c[2][1]=100

print(b)
print(c)