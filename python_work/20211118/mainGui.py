import sys
from PyQt5.QtWidgets import *
from scoreExcel import ScoreExcel


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()   #화면생성
        self.initEvent() #시그널생성 이벤트함수

    def append(self):
        try:
            ScoreExcel().appendrow(100,70,50)
        except Exception as e:
            print(e)

    def delete(self):
        ScoreExcel().appendrow()

    def create(self):
        ScoreExcel().appendrow()

    def initEvent(self):
        self.add_btn.clicked.connect(self.append)
        self.del_btn.clicked.connect(self.delete)
        self.create_btn.clicked.connect(self.create)

    def initUi(self):
        self.qtable = QTableWidget(self)

        self.qtable.setRowCount(10)
        self.qtable.setColumnCount(5)

        self.qtable.setHorizontalHeaderLabels(['국어', '영어', '수학', '총점', '평균'])
        self.qtable.horizontalHeader()\
            .setSectionResizeMode(QHeaderView.Stretch)

        self.qtable.move(60,120)
        self.qtable.setFixedSize(500,250)

        kor_label = QLabel("국어", self)
        kor_label.move(50, 40)
        eng_label = QLabel("영어", self)
        eng_label.move(50, 65)
        math_label = QLabel("수학", self)
        math_label.move(50, 90)

        self.kor_edit = QLineEdit("100",self)
        self.kor_edit.move(100, 37)
        self.eng_edit = QLineEdit("80", self)
        self.eng_edit.move(100, 62)
        self.math_edit = QLineEdit("50", self)
        self.math_edit.move(100, 87)

        self.add_btn = QPushButton("추가",self)
        self.add_btn.move(500,30)
        self.del_btn = QPushButton("삭제", self)
        self.del_btn.move(500, 55)
        self.create_btn = QPushButton("파일생성", self)
        self.create_btn.move(500, 80)

        self.setWindowTitle("score pg")
        self.move(300, 300)
        self.resize(600, 400)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
