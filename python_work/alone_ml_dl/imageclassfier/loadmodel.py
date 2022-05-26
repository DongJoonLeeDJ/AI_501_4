from flask_cors import CORS, cross_origin
from flask import Flask, render_template, request
from keras.preprocessing.image import ImageDataGenerator, img_to_array, load_img
import pandas as pd
import numpy as np
from tensorflow import keras
import os

path = './imageclassfier/dogs-vs-cats'

IMAGE_WIDTH = 128
IMAGE_HEIGHT = 128
IMAGE_SIZE = (IMAGE_WIDTH, IMAGE_HEIGHT)
IMAGE_CHANNEL = 3

model = keras.Sequential()
model.add(keras.layers.Conv2D(32, (3, 3), activation="relu", input_shape=(IMAGE_HEIGHT, IMAGE_WIDTH, IMAGE_CHANNEL)))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.MaxPool2D(pool_size=(2, 2)))
model.add(keras.layers.Dropout(0.25))

# 레이어 2 생성
model.add(keras.layers.Conv2D(64, (3, 3), activation="relu"))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.MaxPool2D(pool_size=(2, 2)))
model.add(keras.layers.Dropout(0.25))

# 레이어 3 생성
model.add(keras.layers.Conv2D(128, (3, 3), activation="relu"))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.MaxPool2D(pool_size=(2, 2)))
model.add(keras.layers.Dropout(0.25))

# 전체 연결
model.add(keras.layers.Flatten())
model.add(keras.layers.Dense(512, activation='relu'))
model.add(keras.layers.BatchNormalization())
model.add(keras.layers.Dropout(0.5))

# 0:모름  1:개 2:고양이
model.add(keras.layers.Dense(2, activation="softmax"))

# 모델 실행 옵션. 다중 타겟 rmsprop
model.compile(loss="categorical_crossentropy",
              optimizer="rmsprop", metrics=['accuracy'])
model.summary()

model.load_weights('./imageclassfier/model.h5')


datagen = ImageDataGenerator(
    rotation_range=40,
    width_shift_range=0.2,
    height_shift_range=0.2,
    shear_range=0.2,
    zoom_range=0.2,
    horizontal_flip=True,
    fill_mode='nearest')

img = load_img(path+"\\test1\\test1\\521.jpg", target_size=(128, 128))
x = img_to_array(img)
# this is a Numpy array with shape (1, 3, 150, 150)
# x = x.reshape((1,) + x.shape)

# i = 0
# for batch in datagen.flow(x, batch_size=1,
#                           save_to_dir=path+'\\preview', save_prefix='cat', save_format='jpeg'):
#     i += 1
#     if i > 20:
#         break

img = load_img(path+"\\test1\\test1\\270.jpg", target_size=(128, 128))


# plt.imshow(img)
# plt.show()

inputdata = np.array(img)
inputdata = inputdata.reshape(1, 128, 128, 3)
print(inputdata.shape)
testdata = model.predict(inputdata/255.0)
# x = img_to_array(img)
# print(x/255.0)
# inputdata = x/255.0
# testdata = model.predict(inputdata)
print(np.argmax(testdata))

app = Flask(__name__)
cors = CORS(app, resources={r"/fileupload": {"origins": "*"}})
app.config['CORS_HEADERS'] = 'Content-Type'

# 일반적인 라우트 방식입니다.


@ app.route('/')
def board():
    return render_template('index.html')


image_path = path+"/preview/"


@ app.route('/fileupload', methods=['POST'])
@cross_origin(origin='localhost', headers=['Content- Type', 'Authorization'])
def file_upload():
    result = ""
    try:
        ff = request.files['file']
        ff.save(os.path.join(image_path, ff.filename))
        img = load_img(os.path.join(image_path, ff.filename),
                    target_size=(128, 128))
        inputdata = np.array(img)
        inputdata = inputdata.reshape(1, 128, 128, 3)
        print(inputdata.shape)
        testdata = model.predict(inputdata/255.0)
        result = '고양이' if np.argmax(testdata) == 0 else '개'
    except Exception as e:
        print(e)
    return "result = "+result


app.run(host="localhost", port=5001)

# asdfasdf

# filenames = os.listdir(path+"\\test1\\test1")
# test_df = pd.DataFrame({"filename": filenames})
# batch_size = 15
# earlystop = keras.callbacks.EarlyStopping(patience=10)
# learning_rate_reducation = keras.callbacks.ReduceLROnPlateau(
#     monitor="val_accuracy",
#     patience=2,
#     factor=0.5,
#     min_lr=0.0001,
#     verbose=1
# )
# callbacks = [earlystop, learning_rate_reducation]

# # 0(고양이)의 갯수
# nbsamples = test_df.shape[0]

# test_datagen = keras.preprocessing.image.ImageDataGenerator(rescale=1./255)

# test_generator = test_datagen.flow_from_dataframe(
#     test_df,
#     path+"\\test1\\test1",
#     x_col="filename",
#     y_col=None,
#     target_size=IMAGE_SIZE,
#     class_mode=None,
#     batch_size=batch_size,
#     shuffle=False
# )

# # test_image = path+"\\test1\\test1\\531.jpg"
# # model.predict(test_image)

# # 예측
# predict = model.predict_generator(test_generator,
#                                   steps=nbsamples/batch_size,
#                                   callbacks=callbacks)
# test_df['category'] = np.argmax(predict, axis=1)

# # 테스트샘플 랜덤 추출후 확인
# test_df['category'] = test_df['category'].replace({0: 'cat', 1: "dog"})
# ex_df = test_df.sample(n=1).reset_index(drop=True)
# print(ex_df)

# ex_generator = test_datagen.flow_from_dataframe(
#     ex_df,
#     path+"\\test1\\test1",
#     x_col="filename",
#     y_col=None,
#     target_size=IMAGE_SIZE,
#     class_mode=None
# )

# test_sample = list(ex_df.filename)

# sample = ""
# for test in test_sample:
#     sample += test

# print(test)

# image = keras.utils.load_img(path+"\\test1\\test1\\"+sample)
# plt.figure(figsize=(8, 8))
# plt.imshow(image)

# plt.tight_layout()
# plt.show()
