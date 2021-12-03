import urllib.request  # python 기본 라이브러리
import requests  # 라이브러리설치 필요
from bs4 import BeautifulSoup


class Review:
    def __init__(self, comment, date, star, good, bad):
        self.comment = comment
        self.date = date
        self.star = star
        self.good = good
        self.bad = bad

    def __str__(self):
        return '내용 ' + self.comment + \
               ' 날짜 ' + self.date +   \
               ' 별점 ' + self.star +   \
               ' 좋아요 ' + self.good + \
               ' 싫어요 ' + self.bad


url = 'https://movie.naver.com/movie/bi/mi/basic.naver?code=36944'

'''
html = urllib.request.urlopen(url).read()
print(html)
html.parser = html 번역기... xml.parser = xml 번역기... json.parser = json 번역기
html = BeautifulSoup(html,'html.parser')
print(html)'''

req = requests.get(url)
html = BeautifulSoup(req.text.strip(), 'html.parser')
# print(html)
review_list = []

review_list.append(Review('이영화참잘만틈','20110101','10','400','300'))
review_list.append(Review('이영화인간이만든게아님','20120401','9','111','7'))
review_list.append(Review('로맨스영화..좋음','20120301','7','200','30'))

for review in review_list:
    print(review)
