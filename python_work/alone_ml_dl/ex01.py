import sys

from PyQt5.QtGui import QPixmap
from PyQt5.QtWidgets import *
import ex03


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()
    
    # 그래프 만들어서 저장하고 보여줄 함수
    def doA(self):
        # ex03 안에 있는 doA 함수 호출하기
        ex03.doA()

        # 화면에 보여주기...
        pm = QPixmap('bream.jpg')
        self.qlabel.setPixmap(pm)
        self.qlabel.resize(pm.width(),pm.height())

    def initUi(self):
        self.qlabel = QLabel('label',self)
        pm = QPixmap('cat.jpg')
        self.qlabel.setPixmap(pm)

        self.btn = QPushButton("그래프보기",self)
        self.btn.move(700,150)
        self.btn.clicked.connect(self.doA)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(800, 600)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
