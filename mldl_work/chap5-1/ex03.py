import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.preprocessing import StandardScaler
from sklearn.tree import DecisionTreeClassifier
import matplotlib.pyplot as plt
from sklearn.tree import plot_tree

wine = pd.read_csv('https://bit.ly/wine_csv_data')
# print(wine.head())
# print(wine.info())

data = wine[['alcohol','sugar','pH']].to_numpy()
target = wine['class'].to_numpy()
# print(data[:10])
# print(target[:10])

train_input,test_input,train_target,test_target \
    = train_test_split(data,target,random_state=42,test_size=0.2)

# print(train_input.shape,test_input.shape)

ss = StandardScaler()
ss.fit(train_input,train_target)

# 데이터의 표준편차로 변경...
train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

# print(train_scaled[:5])
lr = LogisticRegression()
lr.fit(train_scaled,train_target)

train_score = lr.score(train_scaled,train_target)
test_score = lr.score(test_scaled,test_target)

print('lr 알고리즘 훈련 점수',train_score)
print('lr 알고리즘 테스트 점수',test_score)

dtclf = DecisionTreeClassifier(max_depth=3, random_state=42)
dtclf.fit(train_scaled,train_target)

train_score = dtclf.score(train_scaled,train_target)
test_score = dtclf.score(test_scaled,test_target)

print('dtclf 알고리즘 훈련 점수',train_score)
print('dtclf 알고리즘 테스트 점수',test_score)

plt.figure(figsize=(10,7))
plot_tree(dtclf, max_depth=3, filled=True, feature_names=['alcohol','sugar','pH'])
plt.show()

