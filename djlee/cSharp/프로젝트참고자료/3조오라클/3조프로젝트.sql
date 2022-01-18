CREATE TABLE 회사(
회사이름 VARCHAR2 (40) PRIMARY KEY,
전화번호 VARCHAR2 (30),
회사메일 VARCHAR2 (40),
대표 VARCHAR2 (20),
본사위치 VARCHAR2 (80)
);

INSERT INTO 회사 VALUES 
('3조', '053-333-1234', 'team3@naver.com', '이준헌', '대구 동구 동대구로 1');

CREATE TABLE 고객 (
    고객번호 VARCHAR2(40) PRIMARY KEY,
    고객이름 VARCHAR2(40),
    전화번호 VARCHAR2(20),
    주민등록번호 VARCHAR2(20),
    이메일 VARCHAR2(40),
    주소 VARCHAR2(80)
);

INSERT INTO 고객 VALUES ('C1', '최학준', '010-2898-9819', '951007-1455241', 'cgw981@naver.com', '대전광역시 서구 둔산북로 56');
INSERT INTO 고객 VALUES ('C2', '백창경', '010-2245-6353', '950908-1452452', 'qwre@naver.com', '경상북도 구미시 송정동 461-6');
INSERT INTO 고객 VALUES ('C3', '허나영', '010-4255-4776', '970907-2424141', 'giskdud@naver.com', '경상북도 울진군 금남면 성류남길 4');
INSERT INTO 고객 VALUES ('C4', '양희창', '010-2746-6373', '961007-1455241', 'gmckddl@naver.com', '전라북도 전주시 완산구 풍남동3가 23-10');
INSERT INTO 고객 VALUES ('C5', '홍문기', '010-6603-5355', '950502-1455241', 'ans@naver.com', '충청남도 당진시 순성면 순성로 473');
INSERT INTO 고객 VALUES ('C6', '황금빛', '010-3366-5556', '970706-2455223', 'goldright@naver.com', '서울 강남구 역삼동 234-12');
INSERT INTO 고객 VALUES ('C7', '정소연', '010-2505-5034', '970407-2455241', 'thdusdl@naver.com', '충청남도 공주시 신관동 612-5');
INSERT INTO 고객 VALUES ('C8', '선우은미', '010-2050-6690', '970222-2155241', 'dmsaldi@naver.com', '경상북도 봉화군 춘양면 서벽리 1389');
INSERT INTO 고객 VALUES ('C9', '신혜성', '010-2099-9995', '970527-1459241', 'gPTMD@naver.com', '서울 강남구 테헤란로 610');
INSERT INTO 고객 VALUES ('C10', '정소연', '010-5999-3002', '970817-1442421', 'tjdgnsl@naver.com', '전라남도 여수 오동도로 61-13');

CREATE TABLE 업주 (
    업주번호 VARCHAR2(40) PRIMARY KEY,
    업주이름 VARCHAR2(40),
    사업자번호 NUMBER(30),
    업주주민등록번호 VARCHAR2(40),
    핸드폰번호 VARCHAR2(40),
    업주이메일 VARCHAR2(40)
);

INSERT INTO 업주 VALUES ('M1', '진예인', '15823684', '874235-8435424', '010-4682-4464', 'whek54@naver.com');
INSERT INTO 업주 VALUES ('M2', '나유진', '84265123', '241598-2165423', '010-8678-7789', 'cngks123@naver.com');
INSERT INTO 업주 VALUES ('M3', '김유진', '12364152', '778641-3312355', '010-3352-7351', 'wlektj33@naver.com');
INSERT INTO 업주 VALUES ('M4', '정찬영', '48234461', '984257-2134853', '010-8874-5663', 'kosh5099@naver.com');
INSERT INTO 업주 VALUES ('M5', '김예원', '42565332', '895643-3429766', '010-7632-9952', 'wldkrjt1@naver.com');
INSERT INTO 업주 VALUES ('M6', '정준경', '42562635', '132468-8724651', '010-2245-8824', 'wlektj77@naver.com');
INSERT INTO 업주 VALUES ('M7', '이시연', '78945665', '621764-1217531', '010-6645-3321', 'nnmwl186@naver.com');
INSERT INTO 업주 VALUES ('M8', '이지은', '42865946', '175354-4576589', '010-7332-6654', 'wlsdf99@naver.com');
INSERT INTO 업주 VALUES ('M9', '정재헌', '72446724', '321975-6523545', '010-9921-2254', 'zdyywe1@naver.com');
INSERT INTO 업주 VALUES ('M10', '김혜민', '54466464', '249875-8851344', '010-5882-4553', 'lwkss354@naver.com');

CREATE TABLE 사업장(
업주번호 VARCHAR2 (40),
사업장이름 VARCHAR2 (80),
사업장주소 VARCHAR2 (80),
PRIMARY KEY (사업장주소),
FOREIGN KEY (업주번호) REFERENCES 업주(업주번호) ON DELETE CASCADE
);

INSERT INTO 사업장 VALUES('M1', '신라호텔', '서울 중구 동호로 249');
INSERT INTO 사업장 VALUES('M2', '인터불고호텔', '대구 수성구 팔현길 212');
INSERT INTO 사업장 VALUES('M3', '컨티넨탈호텔', '전남 목포시 북항로 149');
INSERT INTO 사업장 VALUES('M4', '힐튼호텔', '경북 경주 보문로484-7');
INSERT INTO 사업장 VALUES('M5', '웨스틴호텔', '부산 해운대구 동백로 67');
INSERT INTO 사업장 VALUES('M6', '아난티', '경남 남해군 남면 남서대로 1179번길 40-109');
INSERT INTO 사업장 VALUES('M7', '롯데호텔', '서울 중구 을지로 30');
INSERT INTO 사업장 VALUES('M8', '메리어트호텔', '서울 영등포구 여의대로 8');
INSERT INTO 사업장 VALUES('M9', '켄싱턴호텔', '서울 영등포구 국회대로76길 16');
INSERT INTO 사업장 VALUES('M10', '한화리조트', '경기 양평군 옥천면 신촌길 188');

CREATE TABLE 사업장_정보(
일련번호 VARCHAR2 (40)PRIMARY KEY,
사업장주소 VARCHAR2 (80),
방타입 VARCHAR2 (40),
방개수 NUMBER(10),
요금 NUMBER(35),
FOREIGN KEY (사업장주소) REFERENCES 사업장 (사업장주소) ON DELETE CASCADE
);

INSERT INTO 사업장_정보 VALUES('A1-S1', '서울 중구 동호로 249', '스위트', 10, 200000);
INSERT INTO 사업장_정보 VALUES('A1-D', '서울 중구 동호로 249', '디럭스', 5, 150000);
INSERT INTO 사업장_정보 VALUES('A1-S2', '서울 중구 동호로 249', '스탠다드', 6, 100000);
INSERT INTO 사업장_정보 VALUES('A2-O', '대구 수성구 팔현길 212', '독채', 1, 200000);
INSERT INTO 사업장_정보 VALUES('A3-S1', '경북 경주 보문로484-7', '스위트', 7, 150000);
INSERT INTO 사업장_정보 VALUES('A3-D', '경북 경주 보문로484-7', '디럭스', 8, 100000);
INSERT INTO 사업장_정보 VALUES('A3-S2', '경북 경주 보문로484-7', '스탠다드', 6, 80000);
INSERT INTO 사업장_정보 VALUES('A4-S1', '부산 해운대구 동백로 67', '스위트', 5, 180000);
INSERT INTO 사업장_정보 VALUES('A4-D', '부산 해운대구 동백로 67', '디럭스', 6, 140000);
INSERT INTO 사업장_정보 VALUES('A4-S2', '부산 해운대구 동백로 67', '스탠다드', 3, 120000);
INSERT INTO 사업장_정보 VALUES('A5-S1', '서울 영등포구 여의대로 8', '스위트', 5, 150000);
INSERT INTO 사업장_정보 VALUES('A5-D', '서울 영등포구 여의대로 8', '디럭스', 6, 120000);
INSERT INTO 사업장_정보 VALUES('A5-S2', '서울 영등포구 여의대로 8', '스탠다드', 6, 90000);
INSERT INTO 사업장_정보 VALUES('A6-S1', '전남 목포시 북항로 149', '스위트', 7, 120000);
INSERT INTO 사업장_정보 VALUES('A6-D', '전남 목포시 북항로 149', '디럭스', 8, 80000);
INSERT INTO 사업장_정보 VALUES('A6-S2', '전남 목포시 북항로 149', '스탠다드', 6, 60000);
INSERT INTO 사업장_정보 VALUES('A7-S1', '경남 남해군 남면 남서대로 1179번길 40-109', '스위트', 7, 120000);
INSERT INTO 사업장_정보 VALUES('A7-D', '경남 남해군 남면 남서대로 1179번길 40-109', '디럭스', 8, 80000);
INSERT INTO 사업장_정보 VALUES('A7-S2', '경남 남해군 남면 남서대로 1179번길 40-109', '스탠다드', 6, 60000);
INSERT INTO 사업장_정보 VALUES('A8-S1', '서울 중구 을지로 30', '스위트', 7, 150000);
INSERT INTO 사업장_정보 VALUES('A8-D', '서울 중구 을지로 30', '디럭스', 8, 120000);
INSERT INTO 사업장_정보 VALUES('A8-S2', '서울 중구 을지로 30', '스탠다드', 6, 90000);
INSERT INTO 사업장_정보 VALUES('A9-S1', '서울 영등포구 국회대로76길 16', '스위트', 7, 150000);
INSERT INTO 사업장_정보 VALUES('A9-D', '서울 영등포구 국회대로76길 16', '디럭스', 8, 120000);
INSERT INTO 사업장_정보 VALUES('A9-S2', '서울 영등포구 국회대로76길 16', '스탠다드', 6, 90000);
INSERT INTO 사업장_정보 VALUES('A10-S1', '경기 양평군 옥천면 신촌길 188', '스위트', 7, 150000);
INSERT INTO 사업장_정보 VALUES('A10-D', '경기 양평군 옥천면 신촌길 188', '디럭스', 8, 120000);
INSERT INTO 사업장_정보 VALUES('A10-S2', '경기 양평군 옥천면 신촌길 188', '스탠다드', 6, 90000);

CREATE TABLE 예약내역(
예약번호 VARCHAR2 (40)PRIMARY KEY,
일련번호 VARCHAR2 (40),
고객번호 VARCHAR2 (40),
예약시작일 DATE,
예약종료일 DATE,
인원수 NUMBER(20),
결제방식 VARCHAR2 (40),
FOREIGN KEY (일련번호) REFERENCES 사업장_정보(일련번호) ON DELETE CASCADE,
FOREIGN KEY (고객번호) REFERENCES 고객(고객번호) ON DELETE CASCADE
);

INSERT INTO 예약내역 VALUES('R1', 'A3-D', 'C2', TO_DATE('2021-04-10','YYYY-MM-DD'), TO_DATE('2021-04-11','YYYY-MM-DD'), 3, '카드');
INSERT INTO 예약내역 VALUES('R2', 'A3-D', 'C3', TO_DATE('2021-04-13','YYYY-MM-DD'), TO_DATE('2021-04-15','YYYY-MM-DD'), 2, '카드');
INSERT INTO 예약내역 VALUES('R3', 'A3-D', 'C4', TO_DATE('2021-04-15','YYYY-MM-DD'), TO_DATE('2021-04-17','YYYY-MM-DD'), 4, '계좌이체');
INSERT INTO 예약내역 VALUES('R4', 'A1-S1', 'C1', TO_DATE('2021-04-05','YYYY-MM-DD'), TO_DATE('2021-04-06','YYYY-MM-DD'), 3, '소액결제');
INSERT INTO 예약내역 VALUES('R5', 'A6-S2', 'C1', TO_DATE('2021-03-10','YYYY-MM-DD'), TO_DATE('2021-03-11','YYYY-MM-DD'), 1, '카카오페이');
INSERT INTO 예약내역 VALUES('R6', 'A4-D', 'C6', TO_DATE('2021-04-20','YYYY-MM-DD'), TO_DATE('2021-04-23','YYYY-MM-DD'), 5, '네이버페이');
INSERT INTO 예약내역 VALUES('R7', 'A9-S2', 'C7', TO_DATE('2021-03-15','YYYY-MM-DD'), TO_DATE('2021-03-17','YYYY-MM-DD'), 3, '카드');
INSERT INTO 예약내역 VALUES('R8', 'A10-S1', 'C8', TO_DATE('2021-03-30','YYYY-MM-DD'), TO_DATE('2021-04-01','YYYY-MM-DD'), 2, '계좌이체');
INSERT INTO 예약내역 VALUES('R9', 'A8-S2', 'C9', TO_DATE('2021-03-23','YYYY-MM-DD'), TO_DATE('2021-03-24','YYYY-MM-DD'), 2, '카드');
INSERT INTO 예약내역 VALUES('R10', 'A8-S2', 'C10', TO_DATE('2021-03-26','YYYY-MM-DD'), TO_DATE('2021-03-28','YYYY-MM-DD'), 4, '카드');

CREATE VIEW 총사업장정보
AS SELECT * FROM 사업장 NATURAL JOIN 사업장_정보;

