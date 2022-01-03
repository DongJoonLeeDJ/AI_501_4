'''
    y = 3x + 1
    y = 4x +
'''

# 선행회귀 학습기

from sklearn.linear_model import LinearRegression

# def doFx(x):
#     return (4 * x ** 2) + x + 1


lr = LinearRegression()

# print(doFx(1))
# print(doFx(2))
# print(doFx(3))

lr.fit(
    [[1, 2], [2, 3], [3, 4], [5, 6.5]],
    [6, 19, 40, 50]
)
''' weight, bias '''
print(lr.coef_, lr.intercept_)

pred = lr.predict([[4, 5]])
print('predvalue = ', pred)
