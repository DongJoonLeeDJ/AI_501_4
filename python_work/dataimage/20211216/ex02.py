import cv2

img = cv2.imread('hid.jpg')

print(img.shape)

# opencv,ml,dl-> 3월중순..

w = img.shape[0] / 2
h = img.shape[1] / 2

M = cv2.getRotationMatrix2D(center=(w, h), angle=-30, scale=0.5)
print(M)
aaaa = cv2.warpAffine(img, M, (img.shape[0], img.shape[1]))
cv2.imshow('asdasd', aaaa)
cv2.imwrite('hid30.jpg',aaaa)
cv2.waitKey(0)
