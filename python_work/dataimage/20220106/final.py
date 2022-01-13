
from selenium import webdriver  #크롬브라우저
import urllib.request   #파일다운로드
import time
import resultimg

web = webdriver.Chrome()
web.get('http://192.168.51.3:10000/')
time.sleep(1)
web.find_element('id','start').click()

for i in range(1,31):
    time.sleep(0.5)
    img = web.find_element('id','img'+str(i))
    src = img.get_attribute('src')

    name = './img/'+str(i)+'.png'

    # download the image
    urllib.request.urlretrieve(src,name)

    ret = resultimg.get_result(str(i))
    web.find_element('id','ans').send_keys(ret)
    web.find_element('id','submit').click()

time.sleep(5)
web.quit()

