
import requests

html = requests.get('http://192.168.51.3:8080/aa/a.jsp')
print(html.text)