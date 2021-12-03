# /app.py
from flask import Flask, render_template, request

#Flask 객체 인스턴스 생성
app = Flask(__name__)

@app.route('/',methods=('GET', 'POST')) # 접속하는 url
def index():
    return "aaaa"


if __name__=="__main__":
    app.run(debug=True)