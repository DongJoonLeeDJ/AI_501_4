'''
4. 리스트에 저장되어 있는 모든 값의 합을 계산해서 그 결과를 반환하는 함수를 반들어보자.
예를 들어서 함수의 이름이 sum_all이라 하면 다음과 같은 실행 결과를 보여야 한다.
예시)
    result = sum_all([1,2,3,4,5])
    print(result)
    15
5. 인자로 전달된 리스트에 저장되어 있는 모든 값들을 역순으로 출력하는 함수를 만들어보자. 예를 들어서
함수의 이름이 show_reverse라고 하면, 다음과 같은 실행 결과를 보여야한다.
예시)
    result = show_reverse([1,2,3,4,5])
    print(result)
    5,4,3,2,1
함수를 잘 만들었다면 다음과 같이 문자열을 대상으로도 동작을 하니, 다음과 같이 문자열을 대상으로도 동작
하는지 확인해보기 바란다.
    result = show_reverse("ABCDEF")
    print(result)

    FEDCBA
'''

from aa import AA

myA = AA()
result = myA.sum_all([1,2,3,4,5])
print("result = ",result)

result = myA.reverse([1,2,3,4,5])
print("result = ",result)

result = myA.reverse("ABCDEF")
print("result = ",result)

result = myA.reverse("ABC")
print("result = ",result)

result = myA.reverse("123123")
print("result = ",result)