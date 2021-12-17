
import  cv2
import numpy as np

catimg = cv2.imread('cat.jpg')
rabbitimg = cv2.imread('rabbit.jpg')

# 250,222
# cv2.resize(catimg,None,fx=)

sumimg = cv2.add(catimg,rabbitimg)
cv2.imshow('sumimg',sumimg)
cv2.waitKey(0)

sumnpimg = np.add(catimg,rabbitimg)
cv2.imshow('sumnpimg',sumnpimg)
cv2.waitKey(0)