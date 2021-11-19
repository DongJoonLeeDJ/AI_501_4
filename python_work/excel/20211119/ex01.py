import sys
from PyQt5.QtWidgets import *
import exexcel as bbb


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def makefile(self):
        bbb.makebasic()

    def manjumfn(self):
        bbb.dmajum()
        QMessageBox.information(self,'title','10점으로 다바꿈')

    def initUi(self):
        self.filebtn = QPushButton("파일만들기")
        self.manjunbtn = QPushButton("퀴즈2만점만들기")
        self.총점버튼 = QPushButton("총점버튼")
        self.성적버튼 = QPushButton("성적버튼")

        self.hbox = QHBoxLayout()
        self.hbox.addStretch(1)
        self.hbox.addWidget(self.filebtn)
        self.hbox.addWidget(self.manjunbtn)
        self.hbox.addStretch(1)

        self.hbox2 = QHBoxLayout()
        self.hbox2.addStretch(1)
        self.hbox2.addWidget(self.총점버튼)
        self.hbox2.addWidget(self.성적버튼)
        self.hbox2.addStretch(1)

        # 세로로된 레이아웃 만들기
        self.vbox = QVBoxLayout()
        # 세로로된 레이아웃에 버튼 넣기
        self.vbox.addStretch(3)
        self.vbox.addLayout(self.hbox)
        self.vbox.addLayout(self.hbox2)
        self.vbox.addStretch(1)

        self.setLayout(self.vbox)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(200, 200)
        self.show()

        # 버튼에 이벤트 달기
        self.filebtn.clicked.connect(self.makefile)
        self.manjunbtn.clicked.connect(self.manjumfn)
        self.총점버튼.clicked.connect(bbb.총점함수)
        self.성적버튼.clicked.connect(bbb.성적함수)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
