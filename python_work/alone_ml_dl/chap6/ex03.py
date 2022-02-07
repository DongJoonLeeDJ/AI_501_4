import numpy as np
import matplotlib.pyplot as plt
from sklearn.decomposition import PCA
from sklearn.linear_model import LogisticRegression # 분류학습기

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
lrclf.fit(fruits_pca, np.array([0]*100+[1]*100+[2]*100))

score = lrclf.score(fruits_pca,np.array([0]*100+[1]*100+[2]*100))
print(score)



lrclf.predict

# plt.imshow(fruits[200:201].reshape(100,100),cmap='gray_r')
# plt.axis('off')
# plt.savefig('img3.png')