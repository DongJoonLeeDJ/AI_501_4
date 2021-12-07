
# A very simple Flask Hello World app for you to get started with...
from flask import jsonify
from flask import Flask, request, abort,render_template
from bs4 import BeautifulSoup
import requests

app = Flask(__name__)

@app.route('/')
def hello_world():
    return 'hihihihi!'

@app.route('/keyboard')
def keyboard():
    return jsonify({'type': 'text',"aa":"bb"})

@app.route('/search',methods=['GET'])
def aa():
    jongmok = request.args.get("jongmok")
    req = requests.get('https://www.google.com/finance/quote/'+jongmok)
    soup = BeautifulSoup(req.text,"html.parser")
    divs = soup.find_all('ul',class_='sbnBtf')
    # div = BeautifulSoup(divs,"html.parser")
    # print(div.select('ul'))
    print(divs)
    for div in divs:
        a = div.find_all('ul')
        print(a)
        # print(div)
    return 'aaa'

@app.route("/html")
def html():
    return render_template('a.html')

if __name__ =='__main__':
    app.run()