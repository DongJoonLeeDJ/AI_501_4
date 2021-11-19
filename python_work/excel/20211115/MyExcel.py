
from openpyxl import *

class MyExcel():
    def savefn(self,kor,eng,math,tot,avg):
        wb = load_workbook("a.xlsx")
        ws = wb.active
        ws.append([kor,eng,math,tot,avg])
        wb.save('a.xlsx')
        wb.close()

    def loadfn(self):
        print("MyExcel loadfn")

    def createfn(self):
        wb = Workbook()
        ws = wb.active
        ws.append(['국어','영어','수학','총점','평균'])
        wb.save('a.xlsx')
        wb.close()
