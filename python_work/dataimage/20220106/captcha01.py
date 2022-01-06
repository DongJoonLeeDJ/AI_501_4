# print(eval('58*66'))

import cv2
import numpy as np

digit1 = cv2.imread('img/1.png')

print(digit1.shape)
cv2.imshow('digit1',digit1)
cv2.waitKey(0)

# blue 색깔에 해당되는 부분
gselect = digit1[:,:,0] == 255
digit1[gselect] = 0
cv2.imshow('digit2',digit1)

# green 색깔에 해당되는 부분
gselect = digit1[:,:,1] == 255
digit1[gselect] = 0
cv2.imshow('digit3',digit1)

# red 색깔에 해당하는 부분
gselect = digit1[:,:,2] <= 171
digit1[gselect] = 0
cv2.imshow('digit4',digit1)

cv2.waitKey(0)