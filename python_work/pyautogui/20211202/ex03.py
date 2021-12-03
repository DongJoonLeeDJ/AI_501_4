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
               ' 날짜 ' + self.date + \
               ' 별점 ' + self.star + \
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

score_result = html.select('.score_result > ul > li')

review_list = []

# review_list 한개씩 찾아서 추가
for idx, li in enumerate(score_result):
    star_jumsu = li.find('div', class_='star_score').text.strip()   # 점수
    score_reple = li.find('div',class_='score_reple')               # div...
    reple = score_reple.find('p').text.strip()
    date = score_reple.findAll('em')[1].text
    like, hate = li.findAll('strong')[0].text,li.findAll('strong')[1].text
    review_list.append(Review(reple,date,star_jumsu,like,hate))

# review_list 출력해보기
for review in review_list:
    print(review)
