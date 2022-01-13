
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.neighbors import KNeighborsClassifier
import numpy as np

import matplotlib.pyplot as plt

fish = pd.read_csv('https://bit.ly/fish_csv_data')
# print(fish)
# print(pd.unique(fish['Species']))

fish_input = fish[['Weight','Length','Diagonal','Height','Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

print(fish_input.shape)
print(fish_target.shape)

train_input,test_input,train_target,test_target = \
    train_test_split(fish_input,fish_target,random_state=42)

print(train_input.shape)
print(test_input.shape)
print(train_target.shape)
print(test_target.shape)

print(train_input[:5])

ss = StandardScaler() #표준편차 PolynomalFeatures 열의갯수를늘리는거
ss.fit(train_input,train_target)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

print(train_scaled[:5])

train_score = []
test_score = []
for hip in range(1,6):
    knclf = KNeighborsClassifier(n_neighbors=hip)
    knclf.fit(train_scaled,train_target)

    ta_score = knclf.score(train_scaled,train_target)
    te_score = knclf.score(test_scaled,test_target)
    train_score.append(ta_score)
    test_score.append(te_score)

# plt.plot(train_score)
# plt.plot(test_score)
# plt.show()

knclf = KNeighborsClassifier(n_neighbors=3)
knclf.fit(train_scaled,train_target)

print(knclf.classes_)
proba = knclf.predict_proba([test_scaled[3]])
print(np.round(proba,decimals=5))

dis,indexes = knclf.kneighbors([test_scaled[3]])
print(train_target[indexes])


