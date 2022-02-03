from re import sub
import pandas as pd
from pytest import param
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import cross_validate

wine = pd.read_csv('https://bit.ly/wine_csv_data')

# print(wine.head())

data = wine[['alcohol','sugar','pH']].to_numpy()
target = wine['class'].to_numpy()

print(data.shape)
print(target.shape)

train_input, test_input, train_target,test_target = \
    train_test_split(data,target,random_state=42)

sub_input, val_input,sub_target,val_target = \
    train_test_split(train_input,train_target,random_state=42)

print('훈련데이터 갯수',train_input.shape)
print('테스트데이터 갯수',test_input.shape)
print('서브데이터',sub_input.shape)
print('검증데이터',val_input.shape)

dtclf = DecisionTreeClassifier()
dtclf.fit(sub_input,sub_target)

subsocre = dtclf.score(sub_input,sub_target)
valscore = dtclf.score(val_input,val_target)
testscore = dtclf.score(test_input,test_target)

# print(subsocre)
# print(valscore)
# print(testscore)

scores = cross_validate(DecisionTreeClassifier(),train_input,train_target)
print(scores)

import numpy as np
print(np.mean(scores['test_score']))

from sklearn.model_selection import StratifiedKFold

splitter = StratifiedKFold(n_splits=10,shuffle=True,random_state=42)

scores = cross_validate(DecisionTreeClassifier(),train_input,train_target,cv=splitter)
print(scores)

from sklearn.model_selection import GridSearchCV

params = {  'min_impurity_decrease':[0.0001,0.0002,0.0003,0.0004,0.0005],
            'max_depth':[1,2,3,4,5,6,7,8,9,10],
            'min_samples_split':[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20]
            }

gs = GridSearchCV(DecisionTreeClassifier(random_state=42),params,n_jobs=-1)
gs.fit(train_input,train_target)

dt = gs.best_estimator_
print(dt.score(train_input,train_target))

best_param = gs.best_params_
print(best_param)

# for i in [1,2,3,4,5]:
#     KNeighborsClassifier(n_neighbors=i)
