import urllib.request
import requests
from bs4 import BeautifulSoup

a = urllib.request.urlopen('http://www.naver.com').read()

print(a)
a = requests.get('http://www.naver.com')
# a = BeautifulSoup(a.text,'html.parser')
f = open('a.html','w',encoding='utf-8')
f.write(a.text)
f.close()