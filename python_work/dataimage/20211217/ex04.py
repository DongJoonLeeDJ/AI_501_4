

import cv2

hid_img = cv2.imread('hid.jpg',cv2.IMREAD_GRAYSCALE)

print(hid_img[0,0])
print(hid_img[0,1])
print(hid_img[0,2])
print(hid_img[0,3])
print(hid_img[0,4])
print(hid_img[0,5])

cv2.imshow('hid_img',hid_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(hid_img,75,255,cv2.THRESH_BINARY)
# tresh_img[0:30,0:30] = 255
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(hid_img,75,255,cv2.THRESH_BINARY_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(hid_img,75,255,cv2.THRESH_TRUNC)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(hid_img,75,255,cv2.THRESH_TOZERO)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(hid_img,75,255,cv2.THRESH_TOZERO_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)