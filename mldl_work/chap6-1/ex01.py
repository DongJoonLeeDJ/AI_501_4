import numpy as np
import matplotlib.pyplot as plt

fruits = np.load('./chap6-1/fruits_300.npy')

print(fruits.shape)

# fig,axis = plt.subplots(1,2)
# axis[0].imshow(fruits[100],cmap='gray_r')
# axis[1].imshow(fruits[200],cmap='gray_r')
# plt.show()

apple = fruits[0:100].reshape(-1,10000)
pineapple = fruits[100:200].reshape(-1,10000)
banana = fruits[200:].reshape(-1,10000)

# print(apple.shape)
# print(np.mean(apple.mean(axis=1)))

# print(pineapple.shape)
# print(pineapple.mean(axis=1))

# print(banana.shape)
# print(banana.mean(axis=1))

# plt.hist(np.mean(apple,axis=1),alpha=0.8)
# plt.hist(np.mean(pineapple,axis=1),alpha=0.8)
# plt.hist(np.mean(banana,axis=1),alpha=0.8)
# plt.legend(['apple','pineapple','banana'])
# plt.show()

# fig,axis = plt.subplots(1,3,figsize=(20,5))

# axis[0].bar(range(10000),np.mean(apple,axis=0))
# axis[1].bar(range(10000),np.mean(pineapple,axis=0))
# axis[2].bar(range(10000),np.mean(banana,axis=0))
# plt.show()

# print(apple.shape)
# print(apple.mean(axis=0))

# print(pineapple.shape)
# print(pineapple.mean(axis=0))

# print(banana.shape)
# print(banana.mean(axis=0))

# plt.imshow(fruits[0],cmap='gray')
# plt.show()

# plt.imshow(fruits[1],cmap='gray_r')
# plt.show()

# plt.imshow(fruits[100])
# plt.show()

# plt.imshow(fruits[200])
# plt.show()

apple_mean = np.mean(apple, axis =0).reshape(100,100)
pineapple_mean = np.mean(pineapple, axis =0).reshape(100,100)
banana_mean = np.mean(banana, axis =0).reshape(100,100)

# _,axis = plt.subplots(1,3,figsize=(15,3))
# axis[0].imshow(apple_mean,cmap='gray_r')
# axis[1].imshow(pineapple_mean,cmap='gray_r')
# axis[2].imshow(banana_mean,cmap='gray_r')
# plt.show()

abs_diff = np.abs(fruits - banana_mean)
abs_mean = np.mean(abs_diff,axis=(1,2))
print(abs_mean)
print(abs_mean.shape)

apple_index = np.argsort(abs_mean)[:100]
fig,axis = plt.subplots(10,10,figsize=(10,10))
for i in range(10):
    for j in range(10):
        axis[i,j].imshow(fruits[apple_index[i*10+j]],cmap='gray_r')
        axis[i,j].axis('off')
plt.show()

