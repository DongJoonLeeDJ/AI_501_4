import time

import pyautogui

aa = pyautogui.locateOnScreen('aa.PNG', confidence=0.8)
print(aa)
time.sleep(2)
pyautogui.click(aa)
time.sleep(1)
bb = pyautogui.locateOnScreen('bb.PNG', confidence=0.8)
time.sleep(2)
pyautogui.click(bb)