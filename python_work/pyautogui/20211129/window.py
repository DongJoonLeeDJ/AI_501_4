import sys
from PyQt5 import uic
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import *
from openpyxl import Workbook
from openpyxl import load_workbook
from PyQt5.QtGui import *

import window1
import test
from xlsx import Customer_Email

form_class = uic.loadUiType('MainWindow.ui')[0]


class MainWindow(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.le =None
        self.xl = Customer_Email()
        self.pushButton.clicked.connect(self.window1)
        self.pushButton_5.clicked.connect(self.makexl)

    def window1(self):  # 버튼으로 아이디 입력창 호출
        try:
            test.Test(self)
        except Exception as e:
            print(e)

    def makexl(self):
        self.xl.CreateEmail_xl()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())