#구구단에서 7단 전부를 출력하는 코드를 for루프를 기반으로 작성해보자.
def dan7(dan):
    for i in range(1,10):
        print(dan,"*",i," = ",dan*i)

def dan7reverse(dan):
    for i in range(9,0,-1):
        print(dan,"*",i," = ",dan*i)


def exp(a,b):
    result = 1
    for i in range(b):
        result = result*a
    return result


def greet():
    i = eval(input("몇번인사하까요?"))
    for _ in range(i):
        print("반갑습니다.")