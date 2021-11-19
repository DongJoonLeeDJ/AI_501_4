import sys
from PyQt5.QtWidgets import *


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def makefile(self):
        print("기본파일생성")

    def manjumfn(self):
        print("만점")

    def initUi(self):
        self.filebtn = QPushButton("파일만들기")
        self.manjunbtn = QPushButton("퀴즈2만점만들기")

        self.hbox = QHBoxLayout()
        self.hbox.addStretch(1)
        self.hbox.addWidget(self.filebtn)
        self.hbox.addWidget(self.manjunbtn)
        self.hbox.addStretch(1)

        # 세로로된 레이아웃 만들기
        self.vbox = QVBoxLayout()
        # 세로로된 레이아웃에 버튼 넣기
        self.vbox.addStretch(5)
        self.vbox.addLayout(self.hbox)
        self.vbox.addStretch(1)

        self.setLayout(self.vbox)
        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(200, 200)
        self.show()

        # 버튼에 이벤트 달기
        self.filebtn.clicked.connect(self.makefile)
        self.manjunbtn.clicked.connect(self.manjumfn)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
