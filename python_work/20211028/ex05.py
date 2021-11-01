from flask import Flask,render_template

app = Flask(__name__)

@app.route("/")
def index():
    return "index"

@app.route("/aa/<ap1>")
def aa(ap1):
    return render_template("a.html",ap1=ap1)

@app.route("/bb/<int:bp1>")
def bb(bp1):
    result = ""
    for i in range(1,bp1):
        result += str(i)+"*"+str(i)+"="+str(int(i)*int(i))
    print("result = ",result)
    return render_template("b.html",bp1=result)


@app.route("/cc")
def cc():
    return render_template("c.html")

if __name__ == '__main__':
    app.run(debug=True)