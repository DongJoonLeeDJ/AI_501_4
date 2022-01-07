
import os
import utils
import cv2

chars = utils.extract_chars('5')

for char in chars:
    resized = cv2.resize(char[1], (20, 20))
    cv2.imshow('img',resized)
    input = cv2.waitKey(0)

    if input >=48 and input <=57:
        input = input - 48
        filename = len(next(os.walk('./train_data/'+str(input)))[2])
        filename = str(filename+1)
        cv2.imwrite('./train_data/'+str(input)+'/'+filename+'.png',resized)
    if input == ord('a') or input ==ord('b') or input ==ord('c'):
        input = input- 87
        filename = len(next(os.walk('./train_data/' + str(input)))[2])
        filename = str(filename + 1)
        cv2.imwrite('./train_data/' + str(input) + '/' + filename + '.png', resized)


