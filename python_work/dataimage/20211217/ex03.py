import cv2


oriimg = cv2.imread('hid.jpg')
oriimg = cv2.resize(oriimg,(250,222))
cv2.imwrite('hid250220.jpg',oriimg)