from tensorflow import keras
import numpy as np
from tensorflow.keras.utils import to_categorical
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression

a = np.arange(-100,100,1)

train_input = a #[-100,-99,-98,-97,-96, ... 98,99]
train_target = a*3 #[ -300, -297... 297]

model = keras.Sequential()
model.add(keras.layers.Dense(1,input_shape = (1,)))

print(model.summary())
model.compile(optimizer="adam", loss='mse') 
# 경사하강법... 
# 하이퍼 파라메타... adam... rmsprop....
# 최소제곱법(mse) 회귀...
# crossenropy 분류

# 학습을 해라...
# 조기 종료...
model.fit(train_input.reshape(-1,1), train_target, verbose=1, epochs=900)

predvalue = model.predict([10,12,20,30])

print('predvalue')
print(predvalue)

model.save('./model-hole.h5')

# lr = LinearRegression()
# lr.fit(train_input.reshape(-1,1),train_target)

# print('lrrr')
# print(lr.predict([[10],[12],[20],[30]]))