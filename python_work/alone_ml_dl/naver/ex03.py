from tensorflow import keras
import numpy as np
from tensorflow.keras.utils import to_categorical
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression

a = np.arange(-100,100,1)
# b = np.arange(100,200,1)

# train_input = np.column_stack([a,b])
train_input = a
train_target = a*3

# train_input = np.asarray(train_input)
# train_target = np.asarray(train_target)

# print(train_input[:5])
# print(train_target[:5])

# xtrain,ytrain,xtarget,ytarget = train_test_split(train_input,train_target,random_state=42)

# print(xtrain.shape)
# print(xtarget.shape)

# print(xtrain[:5])
# print(xtarget[:5])

model = keras.Sequential()
# model.add(keras.layers.Flatten(input_shape=(2,)))
# model.add(keras.layers.Dense(1))
model.add(keras.layers.Dense(units=1,activation='linear',input_dim=1))

print(model.summary())
model.compile(optimizer="adam",loss='mse',metrics=['mae'])

model.fit(train_input.reshape(-1,1),train_target,verbose=1,epochs=5)

# print(model.weights)

predvalue = model.predict([10,12,20,30])
print('predvalue')
print(predvalue)

lr = LinearRegression()
lr.fit(train_input.reshape(-1,1),train_target)

print('lrrr')
print(lr.predict([[10],[12],[20],[30]]))