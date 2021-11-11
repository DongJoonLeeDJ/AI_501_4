import sys
from PyQt5.QtWidgets import *

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    ''' 화면을 만드는 내용...'''
    def initUi(self):
        label_1 = QLabel("입력1", self);
        label_1.move(20, 35)
        label_2 = QLabel("입력2", self);
        label_2.move(20, 65)
        label_3 = QLabel("입력3", self);
        label_3.move(20, 95)

        lineEdit1 = QLineEdit("aaa",self)
        lineEdit1.setFixedSize(65,20)
        lineEdit1.move(70,32)
        lineEdit2 = QLineEdit("bbb", self)
        lineEdit2.setFixedSize(65, 20)
        lineEdit2.move(70, 64)
        lineEdit3 = QLineEdit("ccc", self)
        lineEdit3.setFixedSize(65, 20)
        lineEdit3.move(70, 92)

        btnsave = QPushButton("저장",self)
        btnsave.move(150,30)
        btnload = QPushButton(self)
        btnload.setText("불러오기")
        btnload.move(150, 60)
        btncreate = QPushButton(self)
        btncreate.setText("Excel생성")
        btncreate.move(150, 90)

        btnsave.clicked.connect(self.btnsavefunc)
        btnload.clicked.connect(self.btnloadfunc)
        btncreate.clicked.connect(self.btncreatefunc)
        
        self.setWindowTitle("excel...")
        self.move(300, 300)
        self.resize(230, 150)
        self.show()

    ''' 엑셀에 있는 내용을 save'''
    def btnsavefunc(self):
        print("btnsave")

    def btnloadfunc(self):
        print("btnload")

    def btncreatefunc(self):
        print("btncreate")


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
