import sys
from PyQt5 import uic
from PyQt5 import QtWidgets
from xlsx import Customer_Email
from PyQt5.QtWidgets import *

form_class2 = uic.loadUiType('window1.ui')[0]

class Window1(QMainWindow, form_class2):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.xl = Customer_Email()
        # self.le = ""
        self.pushButton.clicked.connect(self.customer)
        # print(self.lineEdit.text(),'asdasd')

    def customer(self):#라인텍스트 안글자가 출력

        try:
            print('일로오나')
            print(self.info_line.text())
            # print(self.lineEdit_2.text())
            # self.le = self.lineEdit.text()
            # print(self.le)
            # self.xl.SaveEmail(self.le)
        except Exception as e:
            print(e)
        # self.close()



# if __name__ == '__main__':
#     app = QApplication(sys.argv)
#     mywindow = Window1()
#     mywindow.show()
#     sys.exit(app.exec_())