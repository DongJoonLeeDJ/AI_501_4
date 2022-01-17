import pandas as pd
import numpy as np

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler

from sklearn.linear_model import SGDClassifier
from sklearn.linear_model import LogisticRegression

import matplotlib.pyplot as plt

'''
    python 
    웹.. 코로나.. 확률.. 그래프..
'''
# from sklearn.datasets import load_wine

fish = pd.read_csv('https://bit.ly/fish_csv_data')

# print(fish.describe())

fish_input = fish[['Weight','Length','Diagonal','Height','Width']].to_numpy()
fish_target = fish['Species'].to_numpy()

# print(fish_input[:5])
# print(fish_target[:5])

train_input,test_input,train_target,test_target\
    = train_test_split(fish_input,fish_target,random_state=42)

ss = StandardScaler()
ss.fit(train_input,train_target)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

# print(train_scaled[:5])
# print(train_target[:5])

lr = LogisticRegression()
lr.fit(train_scaled,train_target)

# print("로지스틱리그레이션분류")
# print(lr.score(train_scaled,train_target))
# print(lr.score(test_scaled,test_target))

sgdclf = SGDClassifier(loss='log',max_iter=10,random_state=42)
sgdclf.fit(train_scaled,train_target)

# print("sdgclassfier분류")
# print(sgdclf.score(train_scaled,train_target))
# print(sgdclf.score(test_scaled,test_target))

sclf = SGDClassifier(loss='log',random_state=42)

train_score = []
test_score = []

classes = np.unique(train_target)
print(classes)

for _ in range(0,300):
    sclf.partial_fit(train_scaled,train_target,classes=classes)

    train_score.append(sclf.score(train_scaled,train_target))
    test_score.append(sclf.score(test_scaled, test_target))

print(train_score)
print(test_score)

plt.plot(train_score,label='train_score')
plt.plot(test_score,label='test_score')
plt.legend(loc='lower right')
plt.xlabel('epoch')
plt.ylabel('accuracy')
plt.savefig('traintestscore.png')











