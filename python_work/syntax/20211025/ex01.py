'''
    1. 정수형 나눗셈의 결과를 출력하는 함수를 만들어보자.
    그래서 이 함수가 호출되면 다음의 실행 결과를 보이도록 해보자.
    int_div(5,2)        # 5나누기 2의 몫과 나머지는?
    몫 : 2
    나머지 : 1
    2. 두 수 사이의 모든 정수의 합을 구하는 코드를 작성하되
    함수 형태로 정의해서 다음의 실행 결과를 보이도록 해보자
    (함수 이름이 bet_sum이라 가정하였다.)
     bet_sum(2,5)    # 2와 5사이의 수 3과 4의 합은?
    7
     bet_sum(1,5)    # 1과 5 사이의 수 2,3,4의 합은?
    9
'''

def int_div(a,b):
    print("몫 ",a//b)
    print("나머지",a%b)


def bet_sum(a,b):
    sum = 0
    for i in range(a+1,b):
        sum += i
    return sum


int_div(5,2)
print(bet_sum(2,5))
print(bet_sum(1,5))


