from sklearn.neighbors import KNeighborsRegressor
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression
import numpy as np
import matplotlib.pyplot as plt

'''
    KNeighborsRegressor 이웃되는회귀... -> x좌표 늘어나도 y좌표가 늘어나지 않는다
    LinearRegression 선형회귀... -> 단항 회귀.. x좌표 음수 y 좌표...
    항..-> 다항회귀.. 학습... 조금 나은 성능보인다..
'''

perch_length = np.array(
    [8.4, 13.7, 15.0, 16.2, 17.4, 18.0, 18.7, 19.0, 19.6, 20.0,
     21.0, 21.0, 21.0, 21.3, 22.0, 22.0, 22.0, 22.0, 22.0, 22.5,
     22.5, 22.7, 23.0, 23.5, 24.0, 24.0, 24.6, 25.0, 25.6, 26.5,
     27.3, 27.5, 27.5, 27.5, 28.0, 28.7, 30.0, 32.8, 34.5, 35.0,
     36.5, 36.0, 37.0, 37.0, 39.0, 39.0, 39.0, 40.0, 40.0, 40.0,
     40.0, 42.0, 43.0, 43.0, 43.5, 44.0]
)
perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0]
)

train_input, test_input, train_target, test_target \
    = train_test_split(perch_length, perch_weight, random_state=42)

train_input = train_input.reshape(-1, 1)
test_input = test_input.reshape(-1, 1)

# print(train_input[:5])

# 데이터분석, 데이터 전처리, 학습하고, 예측...
knr = KNeighborsRegressor(n_neighbors=3)
knr.fit(train_input, train_target)

pred = knr.predict([[50], [100]])
print('pred', pred)

dis, idxs = knr.kneighbors([[50]])

# pred = knr.predict([[100]])
# print(pred)

lr = LinearRegression()
lr.fit(train_input, train_target)

lrpred = lr.predict([[15], [50], [100]])
print('lrpred', lrpred)

print('a = ',lr.coef_,'b = ',lr.intercept_)

train_poly = np.column_stack((train_input**2,train_input))
test_poly = np.column_stack((test_input**2,test_input))

print(train_poly[:5])
print(train_target[:5])
# print(test_poly[:5])

polylr = LinearRegression()
polylr.fit(train_poly,train_target)

print('a = b = ',polylr.coef_,'c = ',polylr.intercept_)

# 학습하는 항(특성)의 개수를 늘리고 있습니다. 특성공학..
# polynomal 특성

plt.scatter(perch_length, perch_weight)
plt.scatter([50], [1033])
plt.scatter(train_input[idxs], train_target[idxs])
plt.plot([15, 50], [15*lr.coef_+lr.intercept_, 50*lr.coef_+lr.intercept_])

x = np.arange(0, 50)
y = polylr.coef_[0]+x**2 + polylr.coef_[1]*x + polylr.intercept_

plt.plot(x, y)

plt.xlabel('length')
plt.ylabel('weight')
plt.show()
