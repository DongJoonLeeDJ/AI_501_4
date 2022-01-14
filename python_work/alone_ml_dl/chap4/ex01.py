
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.neighbors import KNeighborsClassifier
import numpy as np

import matplotlib.pyplot as plt

fish = pd.read_csv('https://bit.ly/fish_csv_data')
# print(fish)
# print(pd.unique(fish['Species']))

fish_input = fish[['Weight','Length','Diagonal','Height','Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

print(fish_input.shape)
print(fish_target.shape)

train_input,test_input,train_target,test_target = \
    train_test_split(fish_input,fish_target,random_state=42)

print(train_input.shape)
print(test_input.shape)
print(train_target.shape)
print(test_target.shape)

print(train_input[:5])

ss = StandardScaler() #표준편차 PolynomalFeatures 열의갯수를늘리는거
ss.fit(train_input,train_target)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

print(train_scaled[:5])

train_score = []
test_score = []
for hip in range(1,6):
    knclf = KNeighborsClassifier(n_neighbors=hip)
    knclf.fit(train_scaled,train_target)

    ta_score = knclf.score(train_scaled,train_target)
    te_score = knclf.score(test_scaled,test_target)
    train_score.append(ta_score)
    test_score.append(te_score)

# plt.plot(train_score)
# plt.plot(test_score)
# plt.xlabel('n_neighbors')
# plt.ylabel('scores')
# plt.show()

knclf = KNeighborsClassifier(n_neighbors=5)
knclf.fit(train_scaled,train_target)

print(knclf.classes_)
proba = knclf.predict_proba([test_scaled[3]])
print(np.round(proba,decimals=5))

dis,indexes = knclf.kneighbors([test_scaled[3]])
print(train_target[indexes])

# z = np.arange(-5,5,0.1) # a*x + b*y + c*z = z
# phi = 1 / (1+np.exp(-z)) # 시그모이드 함수..
#
# plt.plot(z,phi)
# plt.xlabel('z')
# plt.ylabel('phi')
# plt.show()

# 인덱싱, 슬라이싱 [:-1]
# char_arr = np.array(['A', 'B', 'C', 'D', 'E'])
# print(char_arr[[True, False, True, False, False]])
#
# ary = np.array([1,2,3,4,5])
# print(ary[[True,False,True,True,False]])

bream_smelt_indexes = (train_target=='Bream') | (train_target=='Smelt')
# print(bream_smelt_indexes)

train_bream_smelt = train_scaled[bream_smelt_indexes] # Bream과 Smelt 의 특성값 5개씩 있는 x 119??
target_bream_smelt = train_target[bream_smelt_indexes] # Bream과 Smelt 의 특성값 5개씩 있는 x 40???

print(train_bream_smelt.shape)
print(target_bream_smelt.shape)

from sklearn.linear_model import LogisticRegression

# bream smelt 이진 분류..
lr = LogisticRegression()
lr.fit(train_bream_smelt,target_bream_smelt)

predvalue = lr.predict(train_bream_smelt[:5])
print(train_bream_smelt[:5])
print(predvalue)

predprovalue = lr.predict_proba(train_bream_smelt[:5])
print(predprovalue)

'''
    학습기를 통해서 학습을 하고.. 그 예측값이 제일 정확한거를 찾는거를 개발하는 학문...
'''
print('차수 가중치','절편 바이어스')
print(lr.coef_, lr.intercept_)

z값들 = lr.decision_function(train_bream_smelt[:5])
print(z값들[0],z값들[1],z값들[2])

from scipy.special import expit

print(expit(z값들))



