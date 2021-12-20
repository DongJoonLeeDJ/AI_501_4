import cv2
import numpy as np


def doA(x):
    # print(x, '이거 연결됨')
    r = cv2.getTrackbarPos('R', "Image")
    g = cv2.getTrackbarPos('G', "Image")
    b = cv2.getTrackbarPos('B', "Image")
    img[:] = [b, g, r]

    cv2.imshow('Image', img)


img = np.full((300, 300, 3), 255, dtype=np.uint8)

cv2.namedWindow('Image')

cv2.createTrackbar('R', 'Image', 0, 255, doA)
cv2.createTrackbar('G', 'Image', 0, 255, doA)
cv2.createTrackbar('B', 'Image', 0, 255, doA)

# print(img[0:10,0:10])
# img[0:50,0:50] = [255,255,255]
# print(img.shape)

cv2.line(img,(0,0),(100,100),(100,100,100),10)

cv2.imshow("Image", img)
cv2.waitKey(0)
