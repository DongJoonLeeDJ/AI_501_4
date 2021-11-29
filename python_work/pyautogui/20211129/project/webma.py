from selenium import webdriver
import time

# chrom = webdriver('')

def dostart(id,pw):
    print(id)
    print(pw)
    print('일로오나')
    browser = webdriver.Chrome()

    browser.get('https://kb.step.or.kr/main.do')

    time.sleep(5)

    browser.close()
    browser.quit()
