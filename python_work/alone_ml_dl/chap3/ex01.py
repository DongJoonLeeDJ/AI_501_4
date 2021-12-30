from sklearn.neighbors import KNeighborsRegressor
from sklearn.model_selection import train_test_split
import numpy as np

import matplotlib.pyplot as plt

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

'''
분류...
도미...1
빙어...0
 [25,150] -> 1
 [10,11] -> 0
회귀
 [8.4] -> 5.9
 [13.7] -> 32.0
 [15.0] -> 40.0
 '''

train_input,test_input,train_target,test_target = \
       train_test_split(perch_length,
                        perch_weight,
                        random_state=42)

train_input = train_input.reshape(-1,1)
test_input = test_input.reshape(-1,1)

# print(train_input[:5])
# print(train_input.shape)
#
# print(test_input[:5])
# print(test_input.shape)

knr = KNeighborsRegressor()
knr.fit(train_input,train_target)

prevalue = knr.predict([[19.6]])
print(prevalue)

x = np.arange(5,45).reshape(-1,1)

prevalue = knr.predict([[5],[6],[7],[8],[9],[10],[33]])
print(x)
print(prevalue)

# sklearn fit() 학습 -> 2차원배열
#         predict() 예측하는 함수.. -> 2차원배열..

# plt.scatter(perch_length,perch_weight)
# plt.scatter(19.6,88.6,marker='^')
# plt.scatter(33,knr.predict([[33]]),marker='D')
# plt.show()

#예측값들..
# sort_test_input = np.sort(test_input, axis=0)
# test_target = np.sort(test_target)

# pred_values = knr.predict(sort_test_input)
# print(test_input)
# print(pred_values)
#
# plt.scatter(sort_test_input,pred_values,label='prevalues')
# plt.plot(sort_test_input,pred_values)
# plt.scatter(test_input,test_target,marker='D',label='test_target')
# plt.plot(test_input,test_target)
# plt.legend(loc='lower right')
# plt.show()

# knr.n_neighbors = 2
# knr.fit(train_input,train_target)
#
# print(knr.score(train_input,train_target))
# print(knr.score(test_input,test_target))

# x = np.arange(5,45)
# print(x)
# y = np.array(range(50,450,10))
# print(y)
#
# plt.scatter(x,y)
# plt.plot(x,y)
# plt.show()






