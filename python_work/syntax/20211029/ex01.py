'''
1. 문자열 "The Espresso Spirit"을 다음과 같이 선언하자.
    str = "The Espresso Spirit"

   그리고 한번은 모두 대문자로 바꿔서 출력하고,
   또 한번은 모두 소문자로 바꿔서 출력해보자.
   그리고 마지막에 원본 그대로 출력을 한번 더 하자.
'''
'''
2.
   우리나라의 주민등록 번호는 다음과 같은 구조이다.
        "070609-2011xxx"
        "090716-1012xxx"
    이 중에서 앞의 여섯자리는 생년월일 정보이다. 따라서 문자열로 표현된 위의 주민등록번호에서
   생년월일 정보만 꺼내서 출력하고자 하니, 이러한 기능을 제공하는 함수를 만들어보자.
   예를 들어서 함수의 이름이 birth_only라고 하면 이 함수를 대상으로 다음과 같은 결과를 보여야 한다.

   a = birth_only("070609-2011xxx")
   print(a)
   070609
   a = birth_only("090716-1012xxx")
   print(a)
   090716
'''

str = "The Espresso Spirit"
print(str.upper())
print(str.lower())
print(str)



def birth_only(birth):
    return  birth[:6]
# alt + enter


a = birth_only("070609-2011xxx")
print(a)


a = birth_only("090716-1012xxx")
print(a)
