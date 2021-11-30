import sys
from PyQt5.QtWidgets import *
from PyQt5 import Qt,QtCore
import webma


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def start(self):
        # try:
        #     a = self.tableWidget.cellWidget(0, 0).isChecked()
        #     print(a)
        #     a = self.tableWidget.cellWidget(1, 0).isChecked()
        #     print(a)
        # except Exception as e:
        #     print(e)

        id = self.tableWidget.item(0,2).text()
        pw = self.tableWidget.item(0,3).text()
        webma.dostart(id,pw)


    def initUi(self):
        self.qbtn = QPushButton("시작")
        self.qbtn.clicked.connect(self.start)

        self.tableWidget = QTableWidget()
        self.tableWidget.setRowCount(10)
        # 체크박스 이름 아이디 비번
        self.tableWidget.setColumnCount(4)
        self.tableWidget.setHorizontalHeaderLabels(["선택", "이름","아이디","비번"])

        self.tableWidget.horizontalHeader()\
            .setSectionResizeMode(QHeaderView.Stretch)

        # 정렬
        # item = QTableWidgetItem(QCheckBox())
        # item.setTextAlignment(Qt.AlignHCenter)
        # self.tableWidget.setAlignment(QtCore.Qt.AlignCenter)

        for row in range(10):
            self.tableWidget.setCellWidget(row, 0 , QCheckBox())


        self.tableWidget.setItem(0, 1, QTableWidgetItem('승훈'))
        self.tableWidget.setItem(0, 2, QTableWidgetItem('mysky0420@naver.com'))
        self.tableWidget.setItem(0, 3, QTableWidgetItem('a123456789!'))

        hbox = QVBoxLayout()
        hbox.addWidget(self.qbtn)
        hbox.addWidget(self.tableWidget)

        self.setLayout(hbox)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(400, 200)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
