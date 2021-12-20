import cv2

img = cv2.imread('digit.png')
gray_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

ret, thresh = cv2.threshold(gray_img, 60, 255, 1)

contours, hie = cv2.findContours(thresh,
                 cv2.RETR_EXTERNAL,
                 cv2.CHAIN_APPROX_SIMPLE)

print(contours)

cv2.drawContours(img,contours,-1,(0,0,255),5)

cv2.imshow('img',img)
cv2.imshow('gray_img',gray_img)
cv2.imshow('thresh',thresh)
cv2.waitKey(0)

