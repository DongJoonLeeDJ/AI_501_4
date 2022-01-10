

import numpy as np
import cv2
from sklearn.neighbors import KNeighborsClassifier

train_input = np.load('traintest.npz')['train']
train_target = np.load('traintest.npz')['target']

knclf = KNeighborsClassifier(n_neighbors=1)
knclf.fit(train_input,train_target)

def check(test):
    predvalue = knclf.predict(test)
    return predvalue

