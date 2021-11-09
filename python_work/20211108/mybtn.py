import sys
from PyQt5.QtWidgets \
    import QApplication, QWidget, QPushButton, QVBoxLayout, QHBoxLayout
import ex04
import chapter5
from random import randint


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def initUi(self):
        btn1 = QPushButton("BTN1", self)
        btn2 = QPushButton("BTN2", self)
        btn3 = QPushButton("BTN3", self)

        vLout = QHBoxLayout()
        vLout.addStretch(1)
        vLout.addWidget(btn1)
        vLout.addWidget(btn2)
        vLout.addWidget(btn3)
        vLout.addStretch(1)

        btn1.clicked.connect(self.btn1clickd)
        btn2.clicked.connect(self.btn2clickd)

        self.setLayout(vLout)
        self.setWindowTitle("Qbutton")
        self.setGeometry(300, 300, 400, 200)
        self.show()
        
        
    def btn1clickd(self):
        ex04.loadCxlsx()

    def btn2clickd(self):
        chapter5.dxlsx(str(randint(0,100)))


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
