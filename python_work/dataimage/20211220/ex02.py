import cv2
import numpy as np

img = cv2.imread('cat.jpg',cv2.IMREAD_COLOR)

cv2.line(img,(50,50),(100,150),(0,0,255),1)
cv2.line(img,(100,150),(150,50),(0,0,255),1)
cv2.rectangle(img,(0,0),(50,50),(255,0,0),-1)
cv2.putText(img,
            'lion',
            (50,60),
            cv2.FONT_HERSHEY_DUPLEX,
            2,
            (255,255,255)
            )

rabbit_img = cv2.imread('rabbit.jpg',cv2.IMREAD_COLOR)

cv2.circle(rabbit_img,(50,50),10,(0,0,255),5)
points = np.array([[30,30],[100,40],[70,10],[100,120]])
cv2.polylines(rabbit_img,[points],
              False,(255,0,0),5)
cv2.putText(rabbit_img,
            'rabbit',
            (50,60),
            cv2.FONT_HERSHEY_DUPLEX,
            2,
            (255,255,255)
            )

cv2.imshow('cat',img)
cv2.imshow('rabbit',rabbit_img)
cv2.waitKey(0)

