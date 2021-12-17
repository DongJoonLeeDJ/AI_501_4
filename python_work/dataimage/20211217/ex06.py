import cv2
import os

# path = '/home/test/test/data'
# filePath = os.path.join(path, "aa.avi")
filePath = "wildlife.mp4"
print(filePath)

if os.path.isfile(filePath):  # 해당 파일이 있는지 확인
    # 영상 객체(파일) 가져오기
    cap = cv2.VideoCapture(filePath)
else:
    print("파일이 존재하지 않습니다.")

# cap = cv2.VideoCapture(filePath)

# 프레임을 정수형으로 형 변환
frameWidth = int(cap.get(cv2.CAP_PROP_FRAME_WIDTH))  # 영상의 넓이(가로) 프레임
frameHeight = int(cap.get(cv2.CAP_PROP_FRAME_HEIGHT))  # 영상의 높이(세로) 프레임

frame_size = (frameWidth, frameHeight)
print('frame_size={}'.format(frame_size))

frameRate = 33

save_img = 0
while True:
    save_img += 1

    # 한 장의 이미지(frame)를 가져오기
    # 영상 : 이미지(프레임)의 연속
    # 정상적으로 읽어왔는지 -> retval
    # 읽어온 프레임 -> frame
    retval, frame = cap.read()
    if not (retval):  # 프레임정보를 정상적으로 읽지 못하면
        break  # while문을 빠져나가기

    gray_frame = cv2.cvtColor(frame,cv2.COLOR_BGR2GRAY)

    adtaframe = cv2.adaptiveThreshold(gray_frame, 255,
                                    cv2.ADAPTIVE_THRESH_GAUSSIAN_C,
                                    cv2.THRESH_BINARY, 21, 3)
    cv2.imshow('frame', frame)  # 프레임 보여주기
    cv2.imshow('garyframe', gray_frame)  # 프레임 보여주기
    cv2.imshow('adtaframe', adtaframe)  # 프레임 보여주기
    key = cv2.waitKey(frameRate)  # frameRate msec동안 한 프레임을 보여준다

    if save_img == 10:
        cv2.imwrite('aa1.jpg',frame)
        cv2.imwrite('aa2.jpg', gray_frame)
        cv2.imwrite('aa3.jpg', adtaframe)

    # 키 입력을 받으면 키값을 key로 저장 -> esc == 27(아스키코드)
    if key == 27:
        break  # while문을 빠져나가기

if cap.isOpened():  # 영상 파일(카메라)이 정상적으로 열렸는지(초기화되었는지) 여부
    cap.release()  # 영상 파일(카메라) 사용을 종료

cv2.destroyAllWindows()