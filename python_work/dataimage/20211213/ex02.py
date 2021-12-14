
import cv2

# b g r

img = cv2.imread('hid.jpg',cv2.IMREAD_COLOR)

print(img.shape)
print(img[100,100])

cv2.imshow('창의제먹',img)
retvalue = cv2.waitKey(0)
print(retvalue)
if retvalue == 49 :
    print('1을 입력했네요')
if retvalue == 50 :
    print('2을 입력했네요')
cv2.imwrite('hid_copy.jpg',img)