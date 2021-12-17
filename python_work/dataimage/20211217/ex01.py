import cv2

catimg = cv2.imread("cat.jpg")
print(catimg.shape)

center_y = catimg.shape[0] / 2
center_x = catimg.shape[1] / 2

cv2.imshow('catimg', catimg)
cv2.waitKey(0)

for angle in range(0,181,10):
    M = cv2.getRotationMatrix2D(
                (center_x, center_y), angle, 0.5)
    print(M)
    warpcat = cv2.warpAffine(catimg, M, (catimg.shape[0], catimg.shape[1]))

    cv2.imshow('warpcat', warpcat)
    cv2.waitKey(0)

cv2.re
