import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import re
import urllib.request
from konlpy.tag import Okt
from tqdm import tqdm
from tensorflow.keras.preprocessing.text import Tokenizer
from tensorflow.keras.preprocessing.sequence import pad_sequences

# 네이버 영화 리뷰 분류하기 좋아요... 싫어요..
# 훈련데이터 다운로드
# urllib.request.urlretrieve("https://raw.githubusercontent.com/e9t/nsmc/master/ratings_train.txt", filename="ratings_train.txt")
# urllib.request.urlretrieve("https://raw.githubusercontent.com/e9t/nsmc/master/ratings_test.txt", filename="ratings_test.txt")

train_data = pd.read_table('ratings_train.txt')
test_data = pd.read_table('ratings_test.txt')

print('훈련용 리뷰 개수 :',len(train_data)) # 훈련용 리뷰 개수 출력

print(train_data[:5]) # 상위 5개 출력
print(test_data[:5]) # 상위 5개 출력

# train_data 의 데이터 중복 유무를 확인
train_data['document'].nunique()
train_data['label'].nunique()

# document 의 열의 중복 제거
train_data.drop_duplicates(subset=['document'], inplace=True)