
import pandas as pd
import numpy as np
from tensorflow import keras
import matplotlib.pyplot as plt
import random
import os
from sklearn.model_selection import train_test_split

path = './dogs-vs-cats'
# 데이터 형상 관련 상수 정의
IMAGE_WIDTH=128
IMAGE_HEIGHT=128
IMAGE_SIZE=(IMAGE_WIDTH, IMAGE_HEIGHT)
IMAGE_CHANNEL=3

# print(os.listdir(path))
# 학습 데이터 준비
filenames = os.listdir(path+"\\train\\train")

# print(filenames)

dog_cnt = 0
cat_cnt = 0
categories=[]
for filename in filenames:
    category=filename.split(".")[0]
    if category =="dog":
        categories.append(1)
        dog_cnt+=1
    else:
        categories.append(0)
        cat_cnt+=1

df=pd.DataFrame(
    {"filename":filenames,
    "category":categories}
)

# 데이터 확인(막대그래프)
# dataname = ['cat','dog']
# datacnt = [12500,12500]
#
# plt.figure(figsize=(10,10))
# xtick_label_position = list(range(len(dataname)))
# plt.xticks(xtick_label_position, dataname)
#
# plt.bar(xtick_label_position,datacnt)
#
# plt.title('Cat_vs_Dog')
# plt.xlabel("Kind")
# plt.ylabel("How Many?")
# plt.show()

# 레이어 1 생성
model = keras.Sequential()
model.add(keras.layers.Conv2D(32, (3,3), activation="relu",
input_shape=(IMAGE_HEIGHT, IMAGE_WIDTH, IMAGE_CHANNEL)))
model.add(keras.layers.BatchNormalization())
# 10000 개 32... 개씩 뽑아서 학습을 진행
model.add(keras.layers.MaxPool2D(pool_size=(2,2)))
# MaxPool2
model.add(keras.layers.Dropout(0.25))

# 레이어 2 생성
model.add(keras.layers.Conv2D(64, (3,3), activation="relu"))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.MaxPool2D(pool_size=(2,2)))
model.add(keras.layers.Dropout(0.25))

# 레이어 3 생성
model.add(keras.layers.Conv2D(128, (3,3), activation="relu"))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.MaxPool2D(pool_size=(2,2)))
model.add(keras.layers.Dropout(0.25))

# 전체 연결
model.add(keras.layers.Flatten())
model.add(keras.layers.Dense(512, activation='relu'))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.Dropout(0.5))

# 0:모름  1:개 2:고양이
model.add(keras.layers.Dense(2,activation="softmax"))

# 모델 실행 옵션. 다중 타겟 rmsprop
model.compile(loss="categorical_crossentropy", optimizer="rmsprop", metrics=['accuracy'])
model.summary()
# : callback 함수의 일종, learning rate가
# 더이상 업데이트가 되지 않으면, 학습을 중단하여라
earlystop = keras.callbacks.EarlyStopping(patience=10)
learning_rate_reducation=keras.callbacks.ReduceLROnPlateau(
    monitor="val_accuracy",
    patience= 2,
    factor= 0.5,
    min_lr=0.0001,
    verbose=1
)
callbacks = [earlystop, learning_rate_reducation]

df['category']=df['category'].replace({0: 'cat', 1 : 'dog'})

# 데이터 분리
train_df, validate_df = train_test_split(df, test_size=0.2, random_state=42)

train_df = train_df.reset_index(drop=True)
validate_df = validate_df.reset_index(drop=True)

# train_df['category'].value_counts()
# validate_df['category'].value_counts()

# 트레이닝 데이터의 제너레이터 설정
total_train = train_df.shape[0]
total_validate = validate_df.shape[0]
batch_size = 15

train_dategen = keras.preprocessing.image.ImageDataGenerator(
    rotation_range=15,
    rescale=1./255,
    shear_range=0.1,
    zoom_range=0.2,
    horizontal_flip=True,
    width_shift_range=0.1,
    height_shift_range=0.1
)

train_generator = train_dategen.flow_from_dataframe(
    train_df,
    path+"\\train\\train",
    x_col="filename",
    y_col="category",
    target_size=IMAGE_SIZE,
    class_mode= "categorical",
    batch_size= batch_size
)

# 검증 이미지이기에 사진 그대로 쓰겠다.라는 의미
validate_dategen = keras.preprocessing.image.ImageDataGenerator(rescale=1./255)

validation_generator = validate_dategen.flow_from_dataframe(
    validate_df,
    path+"\\train\\train",
    x_col="filename",
    y_col="category",
    target_size=IMAGE_SIZE,
    class_mode = "categorical",
    batch_size= batch_size
)
# 샘플 데이터 확인
example_df = train_df.sample(n=1).reset_index(drop=True)
print(example_df)

example_generator = train_dategen.flow_from_dataframe(
    example_df,
    path+"\\train\\train",
    x_col = "filename",
    y_col="category",
    target_size = IMAGE_SIZE,
    class_mode = "categorical"
)

plt.figure(figsize=(10,10))
for i in range(0,15):
    plt.subplot(5,3,i+1)
    for xBatch, yBatch in example_generator:
        image = xBatch[0]
        plt.imshow(image)
        break
plt.tight_layout()
# plt.show()

# 트레이닝 시작
# 전체 데이터를 3번 사용해서 학습함
# 인터벌과 비슷한듯 하다
epochs = 3
#
history = model.fit_generator(
    train_generator,
    epochs = epochs,
    steps_per_epoch= total_train/batch_size,
    validation_data= validation_generator,
    validation_steps=total_validate/batch_size,
    callbacks = callbacks
)
# # 모델 저장
model.save("model.h5")

# 테스트 준비
# 파일지정
filenames = os.listdir(path+"\\test1\\test1")

test_df = pd.DataFrame({"filename":filenames})
# 0(고양이)의 갯수
nbsamples = test_df.shape[0]

print(nbsamples)

test_datagen = keras.preprocessing.image.ImageDataGenerator(rescale=1./255)

test_generator = test_datagen.flow_from_dataframe(
    test_df,
    path+"\\test1\\test1",
    x_col="filename",
    y_col= None,
    target_size=IMAGE_SIZE,
    class_mode= None,
    batch_size= batch_size,
    shuffle = False
)
# 예측
predict=model.predict_generator(test_generator,
                                steps=nbsamples/batch_size,
                                callbacks=callbacks)
test_df['category']=np.argmax(predict, axis=1)

# 테스트샘플 랜덤 추출후 확인
test_df['category']=test_df['category'].replace({0:'cat',1:"dog"})
ex_df = test_df.sample(n = 1).reset_index(drop=True)
print(ex_df)

ex_generator = test_datagen.flow_from_dataframe(
    ex_df,
    path+"\\test1\\test1",
    x_col = "filename",
    y_col = None,
    target_size=IMAGE_SIZE,
    class_mode=None
)

test_sample = list(ex_df.filename)

sample = ""
for test in test_sample:
    sample += test

print(test)

image = keras.utils.load_img(path+"\\test1\\test1"+sample)
plt.figure(figsize=(8,8))
plt.imshow(image)

plt.tight_layout()
plt.show()

