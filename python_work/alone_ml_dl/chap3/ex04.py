import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression

df = pd.read_csv('https://bit.ly/perch_csv_data')
perch_full = df.to_numpy()

print(perch_full[:5])
print(perch_full.shape)

perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0]
)

print(perch_weight[:5])
print(perch_weight.shape)

train_input, test_input, train_target, test_target \
    = train_test_split(perch_full, perch_weight, random_state=42)

print(train_input[:5])
print(train_target[:5])

lr = LinearRegression()
lr.fit(train_input, train_target)

score = lr.score(test_input, test_target)
print('훈련예측 점수', score)

pred = lr.predict([[36, 10.61, 6.74]])
print('예측되는값', pred, '실제값', train_target[4])

