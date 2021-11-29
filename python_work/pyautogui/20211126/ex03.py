import time
from selenium import webdriver

browser = webdriver.Chrome()

browser.get('http://www.naver.com')
time.sleep(2)
browser.execute_script('window.scrollTo(0, 1080)')
