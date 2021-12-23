import cv2
# import pymysql

img = cv2.imread('digit.png')
gray_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

ret, thresh = cv2.threshold(gray_img, 60, 255, 1)

contours, hie = cv2.findContours(thresh,
                 cv2.RETR_EXTERNAL,
                 cv2.CHAIN_APPROX_SIMPLE)

print(contours)

for contour in contours:
    print(cv2.contourArea(contour))
    if( cv2.contourArea(contour)>100):
        # cv2.drawContours(img,contour,-1,(0,0,255),5)
        x,y,w,h = cv2.boundingRect(contour)
        cv2.rectangle(img,(x,y),(x+w,y+h),(0,0,255),3)

        roi = img[y:y+h,x:x+w]
        roi = cv2.resize(roi,(64,64))
        cv2.imshow('roi',roi)
        cv2.waitKey(0)

cv2.imshow('img',img)
cv2.imshow('gray_img',gray_img)
cv2.imshow('thresh',thresh)
cv2.waitKey(0)

