import cv2
import numpy as np
from matplotlib import pyplot as plt

np.random.seed(47)
# 각 데이터의 위치: 25 X 2 크기에 각각 0 ~ 100
trainData = np.random.randint(0, 100, (25, 2)).astype(np.float32)
# 각 데이터는 0 or 1
response = np.random.randint(0, 2, (25, 1)).astype(np.float32)

# print(trainData.shape)
# print(response.shape)
# print(trainData) # traindata 학습
# print(response)

# print(response.ravel())
# print(response.ravel() == 0)
# print(trainData[response.ravel() == 0])

# # 값이 0인 데이터를 각각 (x, y) 위치에 빨간색으로 칠합니다.
red = trainData[response.ravel() == 0]
# print(red)
plt.scatter(red[:, 0], red[:, 1], 80, 'r', '^')
# 값이 1인 데이터를 각각 (x, y) 위치에 파란색으로 칠합니다.
blue = trainData[response.ravel() == 1]
plt.scatter(blue[:, 0], blue[:, 1], 80, 'b', 's')
# plt.show()

# # (0 ~ 100, 0 ~ 100) 위치의 데이터를 하나 생성해 칠합니다.
newcomer = np.random.randint(0, 100, (3, 2)).astype(np.float32)
print(newcomer)
plt.scatter(newcomer[:, 0], newcomer[:, 1], 400, 'g', 'o')
plt.show()

# google sklearn 라이브러리...
# facebook pytorch 라이브러리
# cv.ml 라이브러리

knn = cv2.ml.KNearest_create()
knn.train(trainData, cv2.ml.ROW_SAMPLE, response)
ret, results, neighbours, dist = \
    knn.findNearest(newcomer, 3)
#
# # 가까운 3개를 찾고, 거리를 고려하여 자신을 정합니다.
print("result : ", results)
print("neighbours :", neighbours)
print("distance: ", dist)
#
# plt.show()

# insert, update, select delete
# 