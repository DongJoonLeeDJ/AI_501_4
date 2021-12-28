CREATE TABLE MYDBHAKGWA
(
    CODE CHAR(3) PRIMARY KEY,
    NAME VARCHAR2(30)  --최대 10글자. 한글일 경우 1글자당 3바이트
);

CREATE TABLE MYDBSTUDENT
(
    HAKBEON VARCHAR2(10) PRIMARY KEY,
    NAME VARCHAR2(60), --최대20글자. 한글일 경우 1글자당 3바이트
    AGE INT,
    HAKGWACODE CHAR(3), -- 학과테이블의 code를 참조하는 외래키
    FOREIGN KEY(HAKGWACODE) REFERENCES MYDBHAKGWA(CODE)
);

INSERT INTO MYDBHAKGWA VALUES ('001','컴공');
INSERT INTO MYDBHAKGWA VALUES ('002','아동가족학');

-- 학생을 추가하려고 한다.
-- 현재는 학생이 컴공이거나 아동가족학이어야 한다.
-- 심리학 등은 아직 존재하지 않으므로, 심리학과 학생은 추가할 수 없다.
INSERT INTO mydbstudent VALUES('12345A','이동준',33,'001');
INSERT INTO mydbstudent VALUES('12345B','류경문',23,'001');
INSERT INTO mydbstudent VALUES('12345C','윤혜림',20,'002');
INSERT INTO mydbstudent VALUES('12345D','장상은',25,'002');
INSERT INTO mydbstudent VALUES('12345E','구혜진',27,'002');
--INSERT INTO mydbstudent VALUES('12345EA','구혜진2',27,'009'); -- 추가 안 됨
SELECT * FROM MYDBHAKGWA;
SELECT * FROM MYDBSTUDENT;








