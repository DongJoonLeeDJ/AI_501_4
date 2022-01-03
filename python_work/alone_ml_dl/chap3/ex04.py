import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression

from sklearn.preprocessing import StandardScaler
from sklearn.preprocessing import PolynomialFeatures

# 1,2,3 2,6,3 -> 10
# 4,5,6 20,30,24 -> 20

# scale 비율.. 배율.. x좌표... 0~45 y좌표.. 0 ~1000좌표 표준변차..

df = pd.read_csv('https://bit.ly/perch_csv_data')
perch_full = df.to_numpy()

print(perch_full[:5])
print(perch_full.shape)

perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0]
)

print(perch_weight[:5])
print(perch_weight.shape)

train_input, test_input, train_target, test_target \
    = train_test_split(perch_full, perch_weight, random_state=42)

print(train_input[:5])
print(train_target[:5])

lr = LinearRegression()
lr.fit(train_input, train_target)

score = lr.score(test_input, test_target)
print('훈련예측 점수', score)

pred = lr.predict([[36, 10.61, 6.74]])
print('예측되는값', pred, '실제값', train_target[4])

'''
    degree 하이퍼 파라메타...
    1,2,3, 항개수..변수개수..특성개수 
    ->
    항이 많으면 많을수록 학습이 잘된다..
    
    항이 너무 많으면 학습했을때 학습 데이터로는 정확한 값이 나오지만
    테스트 데이터로는 예측값을 알 수 없다..
'''
pf = PolynomialFeatures(degree=2,include_bias=False)
pf.fit(train_input)

train_poly = pf.transform(train_input)
test_poly = pf.transform(test_input)
# print(pf.get_feature_names())
# print(train_input[1])
# print(train_poly[1])

lr = LinearRegression()
lr.fit(train_poly,train_target)

poly_score = lr.score(test_poly,test_target)
# print('9개의 항으로 학습 했을 때 학습기 점수',poly_score)

mydata = pf.transform([[36, 10.61, 6.74]])
# print(mydata)
pred = lr.predict(mydata)
# print('pred',pred)
