import cv2
import numpy as np

img = cv2.imread('roi.jpg')
print(img.shape)

k = np.arange(10)
print(k)
label = np.repeat(k,500)
print(label)
print(label.shape)
label = label.reshape(5000,1)
print(label.shape)
print(label)
# label = np.repeat(k,500)[:,np.newaxis]
# # print(label)
# print(label.shape)
