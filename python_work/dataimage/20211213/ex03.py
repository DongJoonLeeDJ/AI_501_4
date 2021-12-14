
import cv2

img_basic = cv2.imread('hid.jpg',cv2.IMREAD_COLOR)
cv2.imshow('basic',img_basic)
cv2.waitKey(0)
cv2.imwrite('hid_copy1.jpg',img_basic)

img_gray = cv2.cvtColor(img_basic,cv2.COLOR_BGR2GRAY)
img_gray[0:100,0:100] = 30
cv2.imshow('gray',img_gray)
cv2.waitKey(0)
cv2.imwrite('hid_gary.jpg',img_gray)

print()