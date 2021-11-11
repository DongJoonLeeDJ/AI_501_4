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
        btn.setText("asdfasdf");

        lineText = QLineEdit(self)
        lineText.setText("qqq")
        lineText.setBaseSize(100,50)
        lineText.move(50,50)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(400, 200)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
