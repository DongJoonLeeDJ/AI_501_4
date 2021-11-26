import sys
import time
import pyautogui
from PyQt5.QtWidgets import *


class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initUi()

    def doms(self):
        try:
            time.sleep(3)
            box = pyautogui.locateOnScreen('font.PNG', confidence=0.8)
            pyautogui.click(box)
            pyautogui.click()
            pyautogui.move(10,200,duration=1)
            pyautogui.click()
        except Exception as e:
            print(e)

    def initUi(self):
        self.mpaintbtn = QPushButton("그림판", self)
        self.mpaintbtn.move(30, 20)
        self.mpaintbtn.clicked.connect(self.doms)

        self.setWindowTitle("First App")
        self.move(300, 300)
        self.resize(400, 200)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())
