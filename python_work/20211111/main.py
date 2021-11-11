import sys
from PyQt5.QtWidgets import *
from myExcel import MExcel

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()
        self.m = MExcel()

    ''' 화면을 만드는 내용...'''
    def initUi(self):
        label_1 = QLabel("입력1", self);
        label_1.move(20, 35)
        label_2 = QLabel("입력2", self);
        label_2.move(20, 65)
        label_3 = QLabel("입력3", self);
        label_3.move(20, 95)

        self.lineEdit1 = QLineEdit("aaa",self)
        self.lineEdit1.setFixedSize(65,20)
        self.lineEdit1.move(70,32)

        self.lineEdit2 = QLineEdit("bbb", self)
        self.lineEdit2.setFixedSize(65, 20)
        self.lineEdit2.move(70, 64)

        self.lineEdit3 = QLineEdit("ccc", self)
        self.lineEdit3.setFixedSize(65, 20)
        self.lineEdit3.move(70, 92)

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
        a = self.lineEdit1.text()
        b = self.lineEdit2.text()
        c = self.lineEdit3.text()

        self.m.save(a,b,c)

    def btnloadfunc(self):
        self.m.load()

    def btncreatefunc(self):
        self.m.create()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
