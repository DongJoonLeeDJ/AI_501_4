def main():
    num = eval(input("숫자 입력하세요"))
    if num % 2 == 0:
        if num % 3 == 0:
            print("2의 배수 이면서 3의 배수 입니다.")
        else:
            print("NO")
    else:
        print("NO")

    if num % 2 == 0 and num % 3 == 0:
        print("2의 배수 이면서 3의 배수 입니다.")
    else:
        print("NO")

main()
