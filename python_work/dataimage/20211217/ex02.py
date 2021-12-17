
import  cv2
import numpy as np
import matplotlib.pyplot as plt

catimg = cv2.imread('cat.jpg')
rabbitimg = cv2.imread('hid250220.jpg')

# 250,222
# cv2.resize(catimg,None,fx=)

sumimg = cv2.add(catimg,rabbitimg)
plt.imshow(cv2.cvtColor(sumimg,cv2.COLOR_BGR2RGB))
plt.show()
# cv2.imshow('sumimg',sumimg)
# cv2.waitKey(0)

sumnpimg = np.add(catimg,rabbitimg)
plt.imshow(cv2.cvtColor(sumnpimg,cv2.COLOR_BGR2RGB))
plt.show()
# cv2.imshow('sumnpimg',sumnpimg)
# cv2.waitKey(0)