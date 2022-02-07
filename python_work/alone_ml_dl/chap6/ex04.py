from flask import Flask, render_template
from sklearn.linear_model import LinearRegression
from sklearn.linear_model import LogisticRegression
import pandas as pd

app = Flask(__name__)

@app.route('/')
def home():
    fish_data = pd.read_csv('https://bit.ly/fish_csv_data')

    train_input = [[1,2,3],[2,3,4],[3,4,5],[4,5,6]]
    train_target = [1,2,3,4]

    lr = LinearRegression()
    lr.fit(train_input,train_target)

    prevalue = lr.predict([[5,6,7]])
    return render_template('index.html', prevalue=prevalue)

if __name__ == '__main__':
    app.run(debug=True)