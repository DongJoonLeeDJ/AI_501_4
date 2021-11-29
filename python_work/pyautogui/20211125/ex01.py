import sys
import time
import mypaint
from PyQt5.QtWidgets import *


class MyApp(QWidget):
    def __init__(self):
        super().__init__()

        self.initUi()

    def initUi(self):
        self.mpaintbtn = QPushButton("그림판", self)
        self.mpaintbtn.move(30, 20)
        self.mpaintbtn.clicked.connect(mypaint.doms)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(400, 200)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
