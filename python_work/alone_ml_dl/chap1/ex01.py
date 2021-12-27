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
        try:
            ex03.doA()
        except Exception as e:
            print(e)

        # 화면에 보여주기...
        pm = QPixmap('Graph.jpg')
        self.qlabel.setPixmap(pm)
        self.qlabel.resize(pm.width(),pm.height())

    def doB(self):
        ret = ex03.doB()
        self.infolabel.setText(str(ret))
        print(str(ret))
        if 'bream' in str(ret):
            pm = QPixmap('bream.png')
            self.infolabel.setPixmap(pm)
            self.infolabel.resize(pm.width(), pm.height())
        else:
            pm = QPixmap('smelt.png')
            self.infolabel.setPixmap(pm)
            self.infolabel.resize(pm.width(), pm.height())

    def doC(self):
        ex03.doC(int(self.inputX.text()), int(self.inputY.text()))

        pm = QPixmap('Graph.jpg')
        self.qlabel.setPixmap(pm)
        self.qlabel.resize(pm.width(), pm.height())


    def initUi(self):
        self.qlabel = QLabel('label')
        pm = QPixmap('Graph.jpg')
        self.qlabel.setPixmap(pm)
        self.qlabel.resize(640, 480)

        self.gra_btn = QPushButton("그래프보기")
        self.gra_btn.clicked.connect(self.doA)

        self.pre_btn = QPushButton("예측하기")
        self.pre_btn.clicked.connect(self.doB)

        self.glayout = QGridLayout()
        self.glayout.addWidget(self.qlabel,0,0)
        self.glayout.setColumnStretch(0,1)

        self.vlayout = QVBoxLayout()
        self.vlayout.addStretch(1)
        self.vlayout.addWidget(self.gra_btn)
        self.vlayout.addWidget(self.pre_btn)

        self.inputX = QLineEdit('10')
        self.inputY = QLineEdit('10')

        self.hlayout1 = QHBoxLayout()
        self.hlayout1.addWidget(QLabel('X'))
        self.hlayout1.addWidget(QLabel('Y'))

        self.vlayout.addLayout(self.hlayout1, 0)

        self.hlayout2 = QHBoxLayout()
        self.hlayout2.addWidget(self.inputX)
        self.hlayout2.addWidget(self.inputY)

        self.vlayout.addLayout(self.hlayout2,0)

        self.data_btn = QPushButton("Data바꾸기")
        self.data_btn.clicked.connect(self.doC)
        
        self.vlayout.addWidget(self.data_btn)

        self.infolabel = QLabel('결과')
        self.vlayout.addWidget(self.infolabel)

        self.vlayout.addStretch(3)
        self.glayout.addLayout(self.vlayout, 0, 2)

        self.setLayout(self.glayout)
        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(800, 500)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
