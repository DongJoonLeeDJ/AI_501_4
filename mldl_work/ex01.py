from unicodedata import decimal
from sklearn.linear_model import LinearRegression #회귀..
import numpy as np

train_input = np.array([[1,2,3],[4,5,6],[7,8,9]])
train_target = [1,2,3]

lr = LinearRegression()
lr.fit(train_input,train_target)

preditvalue = lr.predict([[10,11,12],[8,9,10],[9,10,11]])
print(np.round(preditvalue,decimals=2))





