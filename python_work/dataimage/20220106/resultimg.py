

import utils
import cv2
import Kncl

chars = utils.extract_chars('3')
'''2.png = eval(91+94)'''

result_string = ""
for char in chars:
    test = cv2.resize(char[1], (20, 20))
    test = test.reshape(-1,400)
    ret = Kncl.check(test)

    if int(ret) > -1 and int(ret)< 10:
        result_string += str(ret[0])
    if int(ret) == 10:
        result_string += '+'
    elif int(ret) == 11:
        result_string += '-'
    elif int(ret) == 12:
        result_string += '*'

print(result_string)
# print(eval("111+222"))
print(eval(result_string))

