import time
from selenium import webdriver
from PyQt5.QtGui import QPixmap
import pyautogui

def doA(se_text):
    try:

        browser = webdriver.Chrome()

        browser.get('http://www.naver.com')

        # element = browser.find_element_by_link_text('카페')
        #
        # print(element.get_attribute('href'))
        # print(element.get_attribute('class'))
        #
        # element.click()
        # time.sleep(1)
        # browser.back()
        # time.sleep(1)
        # browser.refresh()

        inputtag = browser.find_element_by_id('query')
        inputtag.send_keys(se_text)

        btntag = browser.find_element_by_xpath(
            '/html/body/div[2]/div[2]/div[1]/div/div[3]/form/fieldset/button/span[2]')
        btntag.click()

        # browser.save_screenshot('samsung.png')
        pyautogui.screenshot('samsung.png',region=(50,50,300,600))

        # time.sleep(5)
        browser.close()
        browser.quit()

    except Exception as e:
        print(e)
