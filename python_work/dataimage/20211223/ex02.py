import cv2

img = cv2.imread('digit_image.png')
gray_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
ret, thresh = cv2.threshold(gray_img, 230, 255, 1)

contours, _ = cv2.findContours(thresh,
                               cv2.RETR_TREE,
                               cv2.CHAIN_APPROX_SIMPLE)

cv2.drawContours(img, contours, 0, 100, 3)

x,y,w,h = cv2.boundingRect(contours[0])

img = cv2.rectangle(img,(x,y),(x+w,y+h),(0,0,255),3)

cv2.imshow('img', img)
cv2.imshow('thresh', thresh)
cv2.waitKey(0)
