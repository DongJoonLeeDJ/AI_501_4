from openpyxl import Workbook

wb = Workbook()
ws = wb.active

ws.title = "rpa"
wb.save('a.xlsx')
wb.close()
