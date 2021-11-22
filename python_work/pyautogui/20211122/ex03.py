import pyautogui
import time

pyautogui.PAUSE = 1

# for i in range(5):
#     pyautogui.move(100,100)
#
#
# img = pyautogui.screenshot()
# img.save('a.png')

# r g b
# 233,212,255
for i in range(5):
    time.sleep(3)   # 1초 쉼,,,
    x,y = pyautogui.position()
    pi = pyautogui.pixel(x,y)
    print('r g b',pi)









