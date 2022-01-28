from konlpy.corpus import kolaw
c = kolaw.open('constitution.txt').read()
from sklearn.linear_model import SGDRegressor

print(c[:1000])

from konlpy.tag import *

okt = Okt()
nouns = okt.nouns(c[:40])
print(nouns)
