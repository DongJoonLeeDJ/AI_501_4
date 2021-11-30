# from selenium import webdriver
import time
import pyautogui
import pyperclip

# chrom = webdriver('')

# def browserclick(browser,url):
#     browser.find_element('xpath',url).click()

def copystr(str):
    pyperclip.copy(str)
    pyautogui.hotkey('ctrl','v')

def browserclick(imgname):
    box = pyautogui.locateOnScreen(imgname, confidence=0.8)
    pyautogui.click(box)

def dostart(id,pw):
    box = pyautogui.locateOnScreen('chr.PNG',confidence=0.8)
    pyautogui.click(box)
    time.sleep(1)
    box = pyautogui.locateOnScreen('guest.PNG',confidence=0.8)
    pyautogui.click(box)
    time.sleep(1)

    copystr('https://kb.step.or.kr/main.do')

    pyautogui.hotkey('enter')
    time.sleep(1)
    browserclick('login.PNG')
    time.sleep(5)
    copystr(id)
    pyautogui.hotkey('tab')
    copystr(pw)
    pyautogui.hotkey('enter')
    time.sleep(2)
    #마이홈
    browserclick('myhome.PNG')
    time.sleep(1)
    #최대화
    cw = pyautogui.getActiveWindow()
    cw.maximize()
    pyautogui.scroll(-500)

    time.sleep(1)
    browserclick('more.PNG')

    time.sleep(1)
    browserclick('enter.PNG')

    time.sleep(1)
    browserclick('study.PNG')

    time.sleep(2)
    browserclick('exe.PNG')

    time.sleep(2)
    browserclick('ok.PNG')

    time.sleep(2)
    browserclick('popup.PNG')

    time.sleep(2)
    browserclick('o.PNG')

    time.sleep(2)
    browserclick('study.PNG')

    time.sleep(5)
    browserclick('play.PNG')

    for _ in range(20):
        time.sleep(60*25)
        browserclick('next.PNG')
        time.sleep(5)
        browserclick('play.PNG')
    # cw.restore()





# def dostart(id,pw):
#     try:
#         print(id)
#         print(pw)
#         print('일로오나')
#         browser = webdriver.Chrome()
#
#         browser.get('https://kb.step.or.kr/main.do')
#
#         ele = browser.find_element('xpath','/html/body/section[1]/header/div[1]/div/ul/li[1]/a')
#         ele.click()
#         time.sleep(1.5)
#
#         browser.find_element('xpath','//*[@id="id_input"]').send_keys(id)
#         browser.find_element('xpath', '//*[@id="pw_input"]').send_keys(pw)
#
#         ele = browser.find_element('xpath','//*[@id="body"]/div/div/div/div[3]')
#         ele.click()
#
#         time.sleep(0.5)
#
#         # 마이홈
#         browserclick(browser, '//*[@id="content"]/div[2]/div[1]/div[1]/div/div/div/ul/li[1]/a')
#         time.sleep(0.5)
#         browserclick(browser, '//*[@id="form1"]/div/div[3]/ul/li[1]/div/div[1]/div[2]/a')
#         time.sleep(0.5)
#         browserclick(browser, '//*[@id="tab01"]/div/table/tbody/tr[1]/td[4]/button')
#         time.sleep(0.5)
#         browserclick(browser, '/html/body/section[1]/section/div[1]/div[2]/div[3]/button')
#
#         time.sleep(5)
#         browser.close()
#         # browser.quit()
#     except Exception as e:
#         print(e)

dostart('mysky0420@naver.com','a123456789!')