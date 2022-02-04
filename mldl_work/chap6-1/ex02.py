import numpy as np
from sklearn.cluster import KMeans # label 값이 없는거
from sklearn.linear_model import LogisticRegression # label값이 있는거
import matplotlib.pyplot as plt


fruits = np.load('./chap6-1/fruits_300.npy')
fruits_2d = fruits.reshape(-1,10000)

km = KMeans(n_clusters=3,random_state=42)
km.fit(fruits_2d)

predvalue = km.predict([fruits_2d[0]])
print(predvalue)

predvalue = km.predict([fruits_2d[100]])
print(predvalue)

predvalue = km.predict([fruits_2d[200]])
print(predvalue)

# apple 타겟값 0 
train_target = ['apple']*100+['pineapple']*100+['banana']*100
# print(train_target)

lrclf = LogisticRegression()
lrclf.fit(fruits_2d,train_target)

predvalue = lrclf.predict([fruits_2d[0]])
print(predvalue)

predvalue = lrclf.predict([fruits_2d[100]])
print(predvalue)

predvalue = lrclf.predict([fruits_2d[200]])
print(predvalue)

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

# draw_fruits(fruits[km.labels_==0])
# draw_fruits(fruits[km.labels_==1])
# draw_fruits(fruits[km.labels_==2])

# fig,axis = plt.subplots(1,3)

# axis[0].imshow(fruits_2d[0].reshape(100,100),cmap='gray_r')
# axis[0].axis('off')
# axis[1].imshow(fruits_2d[100].reshape(100,100),cmap='gray_r')
# axis[1].axis('off')
# axis[2].imshow(fruits_2d[200].reshape(100,100),cmap='gray_r')
# axis[2].axis('off')
# plt.show()

# draw_fruits(km.cluster_centers_.reshape(-1,100,100),ratio=3)

inertia = []

for k in range(2,7):
    km = KMeans(n_clusters=k,random_state=42)
    km.fit(fruits_2d)

    inertia.append(km.inertia_)

plt.plot(range(2,7),inertia)
plt.xlabel('k')
plt.ylabel('inertia')

plt.show()

