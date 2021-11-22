import pyautogui

# pyautogui.move(100,100,duration=1) #상대좌표 이동
# pyautogui.moveTo(100,100,duration=1) #절대좌표 이동

print('현재좌표',pyautogui.position())

pyautogui.click(-938,7,duration=1)