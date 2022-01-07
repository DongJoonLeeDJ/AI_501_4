import cv2
import numpy as np

blue = 0
green = 1
red = 2

def resize20(img):
    resized = cv2.resize(img,(20,20))
    return resized.reshape(-1,400).astype(np.float32)

def get_chars(img, wcolor):
    other_color1 = (wcolor + 1) % 3
    other_color2 = (wcolor + 2) % 3
    # blue 색깔에 해당되는 부분
    gselect = img[:, :, other_color1] == 255
    img[gselect] = 0
    # green 색깔에 해당되는 부분
    gselect = img[:, :, other_color2] == 255
    img[gselect] = 0
    # red 색깔에 해당하는 부분
    gselect = img[:, :, wcolor] < 170
    img[gselect] = 0

    gselect = img[:, :, wcolor] != 0
    img[gselect] = 255
    return img

def extract_chars(filename):
    chars = []
    colors = [green, blue, red]
    oriimg = cv2.imread('img/'+str(filename)+'.png')
    for color in colors:
        color_img = get_chars(oriimg.copy(), color)
        gray_img = cv2.cvtColor(color_img, cv2.COLOR_BGR2GRAY)
        ret, thresh_img = cv2.threshold(gray_img, 127, 255, 0)


        contours, _ = cv2.findContours(thresh_img, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

        color_img = cv2.drawContours(color_img, contours, -1, (255, 0, 0), 3)
        # cv2.imshow('thresh_img', thresh_img)
        # cv2.imshow('color_img', color_img)
        for contour in contours:
            area = cv2.contourArea(contour)
            if (area) > 50:
                x, y, width, height = cv2.boundingRect(contour)
                roi = gray_img[y:y+height,x:x+width]
                chars.append((x,roi))
                # print('x = ',x)
                # cv2.imwrite('roi.png',roi)
                # print(cv2.resize(roi,(20,20)))

    chars = sorted(chars, key=lambda char:char[0])
    return chars