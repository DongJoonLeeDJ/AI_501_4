import matplotlib.pyplot as plt
from sklearn.neighbors import KNeighborsClassifier
import numpy as np

bream_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7,
                    30.0, 30.0, 30.7, 31.0, 31.0, 31.5, 32.0,
                    32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0,
                    34.0, 34.5, 35.0, 35.0, 35.0, 35.0, 36.0,
                    36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0]
bream_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0,
                500.0, 390.0, 450.0, 500.0, 475.0, 500.0,
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0,
                610.0, 650.0, 575.0, 685.0, 620.0, 680.0,
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0,
                920.0, 955.0, 925.0, 975.0, 950.0]

smelt_length = [9.8, 10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
smelt_weight = [6.7, 7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]


test_data = [[10, 11], [30, 400]]
test_data = np.array(test_data)

def doC(x,y):
    global test_data
    test_data = np.array([[x,y]])
    doA()

def doA():
    plt.scatter(bream_length, bream_weight,label='bream')
    plt.scatter(smelt_length, smelt_weight,label='smelt')

    # print(test_data[:, 0])
    # print(test_data[:, 1])
    plt.scatter(test_data[:,0], test_data[:,1], marker='^')
    plt.legend(loc='lower right')

    plt.xlabel('length')
    plt.ylabel('weight')
    plt.savefig('Graph.jpg')
    plt.close()

def doB():
    length = bream_length+smelt_length
    weight = bream_weight+smelt_weight
    fish_data = [[x,y] for x,y in zip(length,weight)]
    # print(fish_data) # train_data 훈련데이터
    fish_target = ['bream']*35 + ['smelt']*14
    # print(fish_target)

    # 개발자가 직접 파라메타를 주는 것을 하이퍼 파라메타라고 한다.
    kclf = KNeighborsClassifier(n_neighbors=5)
    kclf.fit(fish_data,fish_target)

    prevalue = kclf.predict(test_data)
    return prevalue


doB()
