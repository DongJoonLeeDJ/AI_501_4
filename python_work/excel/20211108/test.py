import sys
from PyQt5.QtWidgets import *


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def initUi(self):

        mylabel = QLabel(self)
        mylabel.setText("asdf")
        mylabel.move(100,100)

        btn = QPushButton(self)
        btn.move(300,30)
        btn.setText("asdfasdf");
        btn.clicked.connect(self.makerow)

        lineText = QLineEdit(self)
        lineText.setText("qqq")
        lineText.setBaseSize(100,50)
        lineText.move(50,50)

        self.tableWidget = QTableWidget(self)
        self.tableWidget.setRowCount(7)
        self.tableWidget.setColumnCount(5)
        self.tableWidget.setItem(1,1,QTableWidgetItem('1112'))
        # self.tableWidget.setFixedSize(200,200)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(400, 400)
        self.show()
    def makerow(self):
        self.tableWidget.setRowCount(self.tableWidget.rowCount()+1)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
