import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
import matplotlib.pyplot as plt

fish_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7, 30.0, 30.0, 30.7, 31.0, 31.0,
                31.5, 32.0, 32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0, 34.0, 34.5, 35.0,
                35.0, 35.0, 35.0, 36.0, 36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0, 9.8,
                10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
fish_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0, 500.0, 390.0, 450.0, 500.0, 475.0, 500.0,
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0, 610.0, 650.0, 575.0, 685.0, 620.0, 680.0,
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0, 920.0, 955.0, 925.0, 975.0, 950.0, 6.7,
                7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]

fish_data = np.column_stack((fish_length,fish_weight))
fish_target = np.concatenate((np.ones(35),np.zeros(14)))
# fish_target = fish_target.reshape(-1,1)

print(fish_data.shape)
print(fish_target.shape)

train_input,test_input,train_target,test_target \
    = train_test_split(fish_data,
                       fish_target,
                       random_state=42)

print(train_input.shape)
print(test_input.shape)

# 25 150 bream 이 나놔야 하는데 smelt가 나온다..

'''
    인공지능 
    학습기 -> 훈련데이터, 테스트데이터..
    학습기 성능...
'''
knclf = KNeighborsClassifier()

print(train_input[:5])

mean = np.mean(train_input,axis=0)
std = np.std(train_input,axis=0)

train_scaled = (train_input-mean)/std
test_scaled = (test_input-mean)/std

print(train_scaled[:5])
print(test_scaled[:5])

from sklearn.preprocessing import StandardScaler

ss = StandardScaler()
ss.fit(train_input,train_target)

train_scaled = ss.transform(train_input)
print(train_scaled[:5])
print(test_scaled[:5])

knclf.fit(train_scaled,train_target)
score = knclf.score(test_scaled,test_target)
print(score)

newcom = [[25,150]]
newcom = (newcom-mean)/std
print('직접 구한 newcom = ',newcom)

newcom = ss.transform([[25,150]])
print('strandardscaler로구한 newcom =',newcom)
prevalue = knclf.predict(newcom)
print(prevalue)

plt.scatter(train_scaled[:,0],train_scaled[:,1])
plt.show()


'''
    머신러닝 딥러닝..
    학습을 잘해서... 예측값...
'''

# knclf.fit(train_input,train_target)
#
# score = knclf.score(test_input,test_target)
# print('학습기 점수',score)
#
# prevalue = knclf.predict([[25,150]])
# print('예측값',prevalue)
#
# distances, indexes = knclf.kneighbors([[25,150]])
#
# print(distances)
# print(indexes)
# print(train_input[indexes])
#
# preproba = knclf.predict_proba([[25,150]])
# print('예측확률',preproba)
#
#
# plt.scatter(train_input[:,0],train_input[:,1])
# plt.scatter(25,150,marker='^')
# plt.xlim((0, 1000))
# plt.scatter(train_input[indexes,0], train_input[indexes,1], marker='D')
#
# plt.show()


