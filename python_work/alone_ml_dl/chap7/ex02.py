import numpy as np
import csv
import seaborn as sns
import matplotlib.pyplot as plt
from collections import Counter
import pandas as pd
from sklearn import datasets

# train 데이터 Load
train = pd.read_csv('./chap7/train.csv')

train.head(2)
train.info()

Gender_mapping = {'Female':1, 'Male':2}
train['Gender'] = train['Gender'].map(Gender_mapping)

Customer_mapping = {'disloyal Customer':10, 'Loyal Customer':11}
train['Customer Type'] = train['Customer Type'].map(Customer_mapping)

Class_mapping = {'Eco':20, 'Business':21,'Eco Plus':22}
train['Class'] = train['Class'].map(Class_mapping)

Travel_mapping = {'Business travel':15,'Personal Travel':16}
train['Type of Travel'] = train['Type of Travel'].map(Travel_mapping)

# 학습시킬값 나누기
X_train = train.iloc[:,1:-1]
Y_train = train.target

train.info()    # 유형 확인
test = pd.read_csv('./chap7/test.csv')

test.head(2)
test.info()   # 유형 확인
# 문자로 된것들 모두 숫자로 바꿔주기
Gender_mapping = {'Female':1, 'Male':2}
test['Gender'] = test['Gender'].map(Gender_mapping)

Customer_mapping = {'disloyal Customer':10, 'Loyal Customer':11}
test['Customer Type'] = test['Customer Type'].map(Customer_mapping)

Class_mapping = {'Eco':20, 'Business':21,'Eco Plus':22}
test['Class'] = test['Class'].map(Class_mapping)

Travel_mapping = {'Business travel':15,'Personal Travel':16}
test['Type of Travel'] = test['Type of Travel'].map(Travel_mapping)

X_test = test.iloc[:,1:]
test.info()   # 모두 제대로 바뀐것을 확인합니다.

from sklearn.model_selection import cross_val_score
from sklearn.ensemble import RandomForestClassifier

classifier = RandomForestClassifier()     # 랜덤포레트스
classifier.fit(X_train, Y_train)          # 학습

prediction = classifier.predict(X_test)   # 예측
print(prediction)

submission = pd.DataFrame({
    "id": test["id"],
    "target":prediction
})

submission.to_csv("./chap7/submission2.csv", index=False)