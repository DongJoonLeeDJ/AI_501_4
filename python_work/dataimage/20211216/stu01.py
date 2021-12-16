import sys
from PyQt5.QtWidgets import *
from PyQt5.QtGui import QPixmap

import cv2


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

        self.img_filename ='hid.jpg'

        self.img_basic = cv2.imread(self.img_filename)
        '''
        b g r 
        '''
        print(self.img_basic[100,100])
        print(self.img_basic.shape)

    def ori(self):
        qm = QPixmap('hid.jpg')
        self.imlabel.setPixmap(qm)

    def copy(self):
        try:
            roi = self.img_basic[100:200,150:250]
            self.img_basic[50:150,100:200] = roi
            cv2.imwrite('hid_copy.jpg',self.img_basic)
        except Exception as e:
            print(e)
        qm = QPixmap('hid_copy.jpg')
        self.imlabel.setPixmap(qm)

    def red_remove(self):
        print('red_remove')

    def red_add(self):
        print('red_add')

    def gray_add(self):
        print('gray_add')

    def initUi(self):
        qm = QPixmap('hid.jpg')

        self.imlabel = QLabel('',self)
        self.imlabel.setPixmap(qm)

        self.btn_ori = QPushButton('원본이미지', self)
        self.btn_ori.move(350, 0)

        self.btn_copy = QPushButton('이미지복사',self)
        self.btn_copy.move(350,30)

        self.btn_red_remove = QPushButton('레드제거', self)
        self.btn_red_remove.move(350, 60)

        self.btn_red_add = QPushButton('레드처리', self)
        self.btn_red_add.move(350, 90)

        self.btn_gray_add = QPushButton('그레이처리', self)
        self.btn_gray_add.move(350, 120)

        self.btn_ori.clicked.connect(self.ori)
        self.btn_copy.clicked.connect(self.copy)
        self.btn_red_remove.clicked.connect(self.red_remove)
        self.btn_red_add.clicked.connect(self.red_add)
        self.btn_gray_add.clicked.connect(self.gray_add)

        self.setWindowTitle("opencv")
        self.move(300, 300)
        self.resize(450, 300)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
