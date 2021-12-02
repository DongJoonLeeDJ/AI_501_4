


import requests
from bs4 import BeautifulSoup

req = requests.get('http://www.dowellcomputer.com/main.jsp')

# print(req)
# print(req.text)

html = BeautifulSoup(req.text,'html.parser')
links = html.select('td>a')

print(links)
print(len(links))

for a in links:
    # print(a)
    if a.has_attr('href'):
        # if a.text in 'notice':
        #     print(a.text)
        if a.get('href').find('notice') !=-1:
            print(a.text)



'''
너무.. 잘할...
프래그래밍..

달리기 .. 15초... 10초.. 
3년차... 5년차... ....350...

300...
 
실력이.. 거의차이가...


    BeautifulSoup
    find 함수... -> html 태그를 찾을때.. 
    select함수... -> css 선택자...

'''

