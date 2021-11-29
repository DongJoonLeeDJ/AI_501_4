import sys

from PyQt5.QtWidgets import *
from PyQt5.QtGui import QPixmap
from PyQt5.QtCore import Qt

import requests
from bs4 import BeautifulSoup

import ex01


class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.initUI()

    def webmacro(self):
        ex01.doA(self.line_edit.text())
        self.lbl_img.setPixmap(QPixmap('samsung.png'))

    def beaufn(self):
        req = requests.get('https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query='+self.line_edit.text())

        html = req.text
        # print(html)
        soup = BeautifulSoup(html,'html.parser')

    def keyPressEvent(self, QKeyEvent):
        if QKeyEvent.key() == 16777220 and len(self.line_edit.text())>0:
            print("일로옴")
            self.webmacro()

    def initUI(self):
        pixmap = QPixmap('samsung.png')
        pixmap = pixmap.scaled(300,500)

        self.lbl_img = QLabel()
        self.lbl_img.setPixmap(pixmap)

        lbl_size = QLabel('Width: '+str(pixmap.width())+', Height: '+str(pixmap.height()))
        lbl_size.setAlignment(Qt.AlignCenter)

        self.line_edit = QLineEdit("")

        load_btn = QPushButton('검색')
        load_btn.clicked.connect(self.webmacro)
        
        beau_btn = QPushButton('뷰티불숩')
        beau_btn.clicked.connect(self.beaufn)

        hbox = QHBoxLayout()
        hbox.addStretch(3)
        hbox.addWidget(lbl_size)
        hbox.addWidget(self.line_edit)
        hbox.addWidget(load_btn)
        hbox.addWidget(beau_btn)


        vbox = QVBoxLayout()
        vbox.addWidget(self.lbl_img)
        vbox.addLayout(hbox)

        self.setLayout(vbox)
        self.setWindowTitle('QPixmap')
        self.move(10, 10)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())