import re
from tensorflow.keras.preprocessing.text import Tokenizer
from tensorflow.keras.preprocessing.sequence import pad_sequences
from konlpy.tag import Okt
from tensorflow import keras

from flask import jsonify
from flask import Flask, request, abort,render_template

import os
os.environ['TF_CPP_MIN_LOG_LEVEL'] = '3'

app = Flask(__name__)

model = keras.models.Sequential()
model.add(keras.layers.Embedding(19416, 100))
model.add(keras.layers.LSTM(128))
model.add(keras.layers.Dense(1, activation='sigmoid'))

# model.load_weights('best_model.h5')
# model.save('best_hole_model.h5')
# 가중치를 저장합니다
# model.save_weights('./checkpoints/my_checkpoint')

# 새로운 모델 객체를 만듭니다
# 가중치를 복원합니다
model.load_weights('best-model.h5')


okt = Okt()
tokenizer = Tokenizer()
stopwords = ['의', '가', '이', '은', '들', '는', '좀', '잘', '걍', '과', '도', '를', '으로', '자', '에', '와', '한', '하다']
max_len = 30

def loadmodel_predict(new_sentence):
  new_sentence = re.sub(r'[^ㄱ-ㅎㅏ-ㅣ가-힣 ]','', new_sentence)
  new_sentence = okt.morphs(new_sentence, stem=True) # 토큰화
  new_sentence = [word for word in new_sentence if not word in stopwords] # 불용어 제거
  encoded = tokenizer.texts_to_sequences([new_sentence]) # 정수 인코딩
  pad_new = pad_sequences(encoded, maxlen = max_len) # 패딩
  score = float(model.predict(pad_new)) # 예측
  if(score > 0.5):
    print("{:.2f}% 확률로 긍정 리뷰입니다.\n".format(score * 100))
    return "{:.2f}% 확률로 긍정 리뷰입니다.\n".format(score * 100)
  else:
    print("{:.2f}% 확률로 부정 리뷰입니다.\n".format((1 - score) * 100))
    return "{:.2f}% 확률로 부정 리뷰입니다.\n".format(score * 100)

predvalue = loadmodel_predict('이 영화 개꿀잼 ㅋㅋㅋ')
print(predvalue)
predvalue = loadmodel_predict('이 영화 핵노잼 ㅠㅠ')
print(predvalue)

predvalue = loadmodel_predict('이딴게 영화냐 ㅉㅉ')
print(predvalue)

predvalue = loadmodel_predict('감독 뭐하는 놈이냐?')
print(predvalue)

predvalue = loadmodel_predict('와 개쩐다 정말 세계관 최강자들의 영화다')
print(predvalue)

from flask import jsonify
from flask import Flask, request, abort,render_template

app = Flask(__name__)

@app.route('/')
def hello_world():
    return 'hihihihi!'

@app.route('/keyboard')
def keyboard():
    return jsonify({'type': 'text',"aa":"bb"})

@app.route('/aa')
def aa():
    return "aa"

@app.route("/html")
def html():
    data = request.args.get('data');
    if len(data) == 0 :
      return render_template('a.html',result='data param need')
    print(data)
    result = loadmodel_predict(data)
    return render_template('a.html',result=result)




app.run()