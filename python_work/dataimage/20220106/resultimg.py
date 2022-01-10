

import utils
import cv2
import Kncl
import re

def get_result(filename):
    try:
        chars = utils.extract_chars(filename)

        result_string = ""
        yon = ""
        for char in chars:
            test = cv2.resize(char[1], (20, 20))
            test = test.reshape(-1,400)
            ret = Kncl.check(test)

            if int(ret) > -1 and int(ret)< 10:
                result_string += str(ret[0])
            if int(ret) == 10:
                result_string += '+'
                yon = "+"
            elif int(ret) == 11:
                result_string += '-'
                yon = "-"
            elif int(ret) == 12:
                result_string += '*'
                yon = "*"
        temp = re.split('\+|\-|\*',result_string)
        result_string = str(int(temp[0]))+yon+str(int(temp[1]))
        print(result_string)

        return eval(result_string)
    except Exception as e:
        print(e)
