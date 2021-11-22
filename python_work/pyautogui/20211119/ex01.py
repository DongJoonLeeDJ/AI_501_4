import time

import pyautogui



# 현재 좌표에서 10,100 좌표로 이동
# pyautogui.move(10, 100, duration=1)

# 절대 좌표에서 100,100 좌표로 이동
# pyautogui.moveTo(10, 100, duration=1)

# 현재 좌표 가져오기...
pos = pyautogui.position()
print(pos)

pyautogui.click(20,748,duration=1)
time.sleep(1)
pyautogui.click(382,291,duration=1)