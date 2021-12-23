import cv2

'''
    html,css,javascript,jquery,oracle,mysql
    c,java,jsp,python,
    
    spring springboot c#
'''

# rgb -> gray -> threshold -> findcontours

img = cv2.imread('digit.png')
gary_img = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# ret 0 ,1 반환 해서 성공하면 0 실패하면 1을 반환한다.
# 임계점 처리 하고 컨투어를 찾아야만 찾아짐...
ret, thresh = cv2.threshold(gary_img, 60, 255, 1)

# contours 비슷한거 나오는거 hie 계층도 hie는 안씀...
contours, hie = cv2.findContours(thresh,
                                 cv2.RETR_EXTERNAL,
                                 cv2.CHAIN_APPROX_SIMPLE)
cv2.drawContours(img, contours, 1, (255, 0, 0), 4)

digit_num = 0
for contour in contours:
    print(cv2.contourArea(contour))
    if cv2.contourArea(contour)>1000:
        x, y, w, h = cv2.boundingRect(contour)
        roi = img[y:y + h, x:x + w]
        cv2.imwrite('roi'+str(digit_num)+'.jpg', roi)
        digit_num += 1

# x,y,w,h = cv2.boundingRect(contours[5])
#
# roi = img[y:y+h,x:x+w]
# cv2.imwrite('roi1.jpg',roi)

# print(contours)
# cv2.imwrite('condigit.jpg',img)

cv2.imshow('img', img)
# cv2.imshow('gary_img', gary_img)
# cv2.imshow('thresh', thresh)
cv2.waitKey(0)
