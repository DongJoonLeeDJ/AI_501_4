from tensorflow import keras
import numpy as np

model = keras.models.load_model('./model-hole.h5')

predvalue = model.predict([10,12,20,30])

print('predvalue')
print(predvalue)