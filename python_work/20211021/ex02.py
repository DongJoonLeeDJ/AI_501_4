from myfunc import doC

# doC()
'''
eval 함수는 
문자열로 들어왔는걸 확인해서...
1) 함수 호출이면 함수 호출도 해주고
2) 1+2 계산도 해준다..
3) 숫자가 들어왔으면 숫자 타입으로 변경

단축키
ctrl + z 뒤로 가기
ctrl + y 앞으로 가기
'''

result = eval(input("뭐든 넣어요"))
print(result)


'''
    자바에서는 문자열 + 숫자형이면
    자동으로 문자열 연산을 한다.
    하지만 파이썬에서는 문자열 + 숫자형이면
    can only concatenate str (not "int") to str
    에러가 생긴다.
'''