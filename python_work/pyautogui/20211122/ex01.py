import pyautogui
import a

# __main__
print(pyautogui.__path__) #pyautogui 설치위치
# print(a.__path__) #pyautogui 설치위치

print('ex01에서...',__name__)
a.doA()

def main():
    print("main 입니다.")

if __name__ == '__main__':
    main()