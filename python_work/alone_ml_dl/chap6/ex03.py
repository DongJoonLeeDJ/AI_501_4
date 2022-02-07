import numpy as np
import matplotlib.pyplot as plt
from sklearn.decomposition import PCA
from sklearn.linear_model import LogisticRegression # 분류학습기

import cv2

def draw_fruits(arr,ratio = 1):
    n = len(arr)
    rows = int(np.ceil(n/10))
    cols = n if rows <2 else 10
    fig,axis = plt.subplots(rows,cols, figsize= (cols*ratio,rows*ratio),squeeze=False)

    for i in range(rows):
        for j in range(cols):
            if i *10 + j <n :
                axis[i,j].imshow(arr[i*10+j],cmap='gray_r')
            axis[i,j].axis('off')
    plt.show()

fruits = np.load('./chap6/fruits_300.npy')
fruits_2d = fruits.reshape(-1, 10000)
# draw_fruits(fruits_2d[:1].reshape(-1,100,100))

pca = PCA(n_components=50)
pca.fit(fruits_2d) # 특성값을 학습하기

fruits_pca = pca.transform(fruits_2d) # 특성값을 가지고 10000->50

print('원래값', fruits.shape)
print('만개의 특성변환', fruits_2d.shape)
print('50개의 특성변환', fruits_pca.shape)

# 지도 target...  비지도 군집화 Kmeans
lrclf = LogisticRegression()
# 0 apple 1 pineapple 2 banana
lrclf.fit(fruits_2d, np.array([0]*100+[1]*100+[2]*100))

# score = lrclf.score(fruits_pca,np.array([0]*100+[1]*100+[2]*100))
# print(score)

img = cv2.imread('img1.png')
img = cv2.cvtColor(img,cv2.COLOR_BGR2RGB)
img = cv2.cvtColor(img,cv2.COLOR_RGB2GRAY)
print(img.shape)

plt.imshow(img,cmap='gray')
plt.show()

img = cv2.resize(img,(100,100))
print(img.shape)

# cv2.imshow('img',img)
# cv2.waitKey(0)

img_2d = img.reshape(-1,10000)
prevalue = lrclf.predict(img_2d)
print(prevalue)


# img_pca = pca.transform(img.reshape(-1,10000))
# prevalue = lrclf.predict(img_pca)
# print(prevalue)

# cv2.imshow('img',img)
# cv2.waitKey(0)

# lrclf.predict

# plt.imshow(fruits[0:1].reshape(100,100),cmap='gray')
# plt.axis('off')
# plt.savefig('img1.png')