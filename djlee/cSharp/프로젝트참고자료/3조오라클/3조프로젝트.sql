CREATE TABLE ȸ��(
ȸ���̸� VARCHAR2 (40) PRIMARY KEY,
��ȭ��ȣ VARCHAR2 (30),
ȸ����� VARCHAR2 (40),
��ǥ VARCHAR2 (20),
������ġ VARCHAR2 (80)
);

INSERT INTO ȸ�� VALUES 
('3��', '053-333-1234', 'team3@naver.com', '������', '�뱸 ���� ���뱸�� 1');

CREATE TABLE �� (
    ����ȣ VARCHAR2(40) PRIMARY KEY,
    ���̸� VARCHAR2(40),
    ��ȭ��ȣ VARCHAR2(20),
    �ֹε�Ϲ�ȣ VARCHAR2(20),
    �̸��� VARCHAR2(40),
    �ּ� VARCHAR2(80)
);

INSERT INTO �� VALUES ('C1', '������', '010-2898-9819', '951007-1455241', 'cgw981@naver.com', '���������� ���� �л�Ϸ� 56');
INSERT INTO �� VALUES ('C2', '��â��', '010-2245-6353', '950908-1452452', 'qwre@naver.com', '���ϵ� ���̽� ������ 461-6');
INSERT INTO �� VALUES ('C3', '�㳪��', '010-4255-4776', '970907-2424141', 'giskdud@naver.com', '���ϵ� ������ �ݳ��� �������� 4');
INSERT INTO �� VALUES ('C4', '����â', '010-2746-6373', '961007-1455241', 'gmckddl@naver.com', '����ϵ� ���ֽ� �ϻ걸 ǳ����3�� 23-10');
INSERT INTO �� VALUES ('C5', 'ȫ����', '010-6603-5355', '950502-1455241', 'ans@naver.com', '��û���� ������ ������ ������ 473');
INSERT INTO �� VALUES ('C6', 'Ȳ�ݺ�', '010-3366-5556', '970706-2455223', 'goldright@naver.com', '���� ������ ���ﵿ 234-12');
INSERT INTO �� VALUES ('C7', '���ҿ�', '010-2505-5034', '970407-2455241', 'thdusdl@naver.com', '��û���� ���ֽ� �Ű��� 612-5');
INSERT INTO �� VALUES ('C8', '��������', '010-2050-6690', '970222-2155241', 'dmsaldi@naver.com', '���ϵ� ��ȭ�� ���� ������ 1389');
INSERT INTO �� VALUES ('C9', '������', '010-2099-9995', '970527-1459241', 'gPTMD@naver.com', '���� ������ ������� 610');
INSERT INTO �� VALUES ('C10', '���ҿ�', '010-5999-3002', '970817-1442421', 'tjdgnsl@naver.com', '���󳲵� ���� �������� 61-13');

CREATE TABLE ���� (
    ���ֹ�ȣ VARCHAR2(40) PRIMARY KEY,
    �����̸� VARCHAR2(40),
    ����ڹ�ȣ NUMBER(30),
    �����ֹε�Ϲ�ȣ VARCHAR2(40),
    �ڵ�����ȣ VARCHAR2(40),
    �����̸��� VARCHAR2(40)
);

INSERT INTO ���� VALUES ('M1', '������', '15823684', '874235-8435424', '010-4682-4464', 'whek54@naver.com');
INSERT INTO ���� VALUES ('M2', '������', '84265123', '241598-2165423', '010-8678-7789', 'cngks123@naver.com');
INSERT INTO ���� VALUES ('M3', '������', '12364152', '778641-3312355', '010-3352-7351', 'wlektj33@naver.com');
INSERT INTO ���� VALUES ('M4', '������', '48234461', '984257-2134853', '010-8874-5663', 'kosh5099@naver.com');
INSERT INTO ���� VALUES ('M5', '�迹��', '42565332', '895643-3429766', '010-7632-9952', 'wldkrjt1@naver.com');
INSERT INTO ���� VALUES ('M6', '���ذ�', '42562635', '132468-8724651', '010-2245-8824', 'wlektj77@naver.com');
INSERT INTO ���� VALUES ('M7', '�̽ÿ�', '78945665', '621764-1217531', '010-6645-3321', 'nnmwl186@naver.com');
INSERT INTO ���� VALUES ('M8', '������', '42865946', '175354-4576589', '010-7332-6654', 'wlsdf99@naver.com');
INSERT INTO ���� VALUES ('M9', '������', '72446724', '321975-6523545', '010-9921-2254', 'zdyywe1@naver.com');
INSERT INTO ���� VALUES ('M10', '������', '54466464', '249875-8851344', '010-5882-4553', 'lwkss354@naver.com');

CREATE TABLE �����(
���ֹ�ȣ VARCHAR2 (40),
������̸� VARCHAR2 (80),
������ּ� VARCHAR2 (80),
PRIMARY KEY (������ּ�),
FOREIGN KEY (���ֹ�ȣ) REFERENCES ����(���ֹ�ȣ) ON DELETE CASCADE
);

INSERT INTO ����� VALUES('M1', '�Ŷ�ȣ��', '���� �߱� ��ȣ�� 249');
INSERT INTO ����� VALUES('M2', '���ͺҰ�ȣ��', '�뱸 ������ ������ 212');
INSERT INTO ����� VALUES('M3', '��Ƽ��Żȣ��', '���� ������ ���׷� 149');
INSERT INTO ����� VALUES('M4', '��ưȣ��', '��� ���� ������484-7');
INSERT INTO ����� VALUES('M5', '����ƾȣ��', '�λ� �ؿ�뱸 ����� 67');
INSERT INTO ����� VALUES('M6', '�Ƴ�Ƽ', '�泲 ���ر� ���� ������� 1179���� 40-109');
INSERT INTO ����� VALUES('M7', '�Ե�ȣ��', '���� �߱� ������ 30');
INSERT INTO ����� VALUES('M8', '�޸���Ʈȣ��', '���� �������� ���Ǵ�� 8');
INSERT INTO ����� VALUES('M9', '�˽���ȣ��', '���� �������� ��ȸ���76�� 16');
INSERT INTO ����� VALUES('M10', '��ȭ����Ʈ', '��� ���� ��õ�� ���̱� 188');

CREATE TABLE �����_����(
�Ϸù�ȣ VARCHAR2 (40)PRIMARY KEY,
������ּ� VARCHAR2 (80),
��Ÿ�� VARCHAR2 (40),
�氳�� NUMBER(10),
��� NUMBER(35),
FOREIGN KEY (������ּ�) REFERENCES ����� (������ּ�) ON DELETE CASCADE
);

INSERT INTO �����_���� VALUES('A1-S1', '���� �߱� ��ȣ�� 249', '����Ʈ', 10, 200000);
INSERT INTO �����_���� VALUES('A1-D', '���� �߱� ��ȣ�� 249', '�𷰽�', 5, 150000);
INSERT INTO �����_���� VALUES('A1-S2', '���� �߱� ��ȣ�� 249', '���Ĵٵ�', 6, 100000);
INSERT INTO �����_���� VALUES('A2-O', '�뱸 ������ ������ 212', '��ä', 1, 200000);
INSERT INTO �����_���� VALUES('A3-S1', '��� ���� ������484-7', '����Ʈ', 7, 150000);
INSERT INTO �����_���� VALUES('A3-D', '��� ���� ������484-7', '�𷰽�', 8, 100000);
INSERT INTO �����_���� VALUES('A3-S2', '��� ���� ������484-7', '���Ĵٵ�', 6, 80000);
INSERT INTO �����_���� VALUES('A4-S1', '�λ� �ؿ�뱸 ����� 67', '����Ʈ', 5, 180000);
INSERT INTO �����_���� VALUES('A4-D', '�λ� �ؿ�뱸 ����� 67', '�𷰽�', 6, 140000);
INSERT INTO �����_���� VALUES('A4-S2', '�λ� �ؿ�뱸 ����� 67', '���Ĵٵ�', 3, 120000);
INSERT INTO �����_���� VALUES('A5-S1', '���� �������� ���Ǵ�� 8', '����Ʈ', 5, 150000);
INSERT INTO �����_���� VALUES('A5-D', '���� �������� ���Ǵ�� 8', '�𷰽�', 6, 120000);
INSERT INTO �����_���� VALUES('A5-S2', '���� �������� ���Ǵ�� 8', '���Ĵٵ�', 6, 90000);
INSERT INTO �����_���� VALUES('A6-S1', '���� ������ ���׷� 149', '����Ʈ', 7, 120000);
INSERT INTO �����_���� VALUES('A6-D', '���� ������ ���׷� 149', '�𷰽�', 8, 80000);
INSERT INTO �����_���� VALUES('A6-S2', '���� ������ ���׷� 149', '���Ĵٵ�', 6, 60000);
INSERT INTO �����_���� VALUES('A7-S1', '�泲 ���ر� ���� ������� 1179���� 40-109', '����Ʈ', 7, 120000);
INSERT INTO �����_���� VALUES('A7-D', '�泲 ���ر� ���� ������� 1179���� 40-109', '�𷰽�', 8, 80000);
INSERT INTO �����_���� VALUES('A7-S2', '�泲 ���ر� ���� ������� 1179���� 40-109', '���Ĵٵ�', 6, 60000);
INSERT INTO �����_���� VALUES('A8-S1', '���� �߱� ������ 30', '����Ʈ', 7, 150000);
INSERT INTO �����_���� VALUES('A8-D', '���� �߱� ������ 30', '�𷰽�', 8, 120000);
INSERT INTO �����_���� VALUES('A8-S2', '���� �߱� ������ 30', '���Ĵٵ�', 6, 90000);
INSERT INTO �����_���� VALUES('A9-S1', '���� �������� ��ȸ���76�� 16', '����Ʈ', 7, 150000);
INSERT INTO �����_���� VALUES('A9-D', '���� �������� ��ȸ���76�� 16', '�𷰽�', 8, 120000);
INSERT INTO �����_���� VALUES('A9-S2', '���� �������� ��ȸ���76�� 16', '���Ĵٵ�', 6, 90000);
INSERT INTO �����_���� VALUES('A10-S1', '��� ���� ��õ�� ���̱� 188', '����Ʈ', 7, 150000);
INSERT INTO �����_���� VALUES('A10-D', '��� ���� ��õ�� ���̱� 188', '�𷰽�', 8, 120000);
INSERT INTO �����_���� VALUES('A10-S2', '��� ���� ��õ�� ���̱� 188', '���Ĵٵ�', 6, 90000);

CREATE TABLE ���೻��(
�����ȣ VARCHAR2 (40)PRIMARY KEY,
�Ϸù�ȣ VARCHAR2 (40),
����ȣ VARCHAR2 (40),
��������� DATE,
���������� DATE,
�ο��� NUMBER(20),
������� VARCHAR2 (40),
FOREIGN KEY (�Ϸù�ȣ) REFERENCES �����_����(�Ϸù�ȣ) ON DELETE CASCADE,
FOREIGN KEY (����ȣ) REFERENCES ��(����ȣ) ON DELETE CASCADE
);

INSERT INTO ���೻�� VALUES('R1', 'A3-D', 'C2', TO_DATE('2021-04-10','YYYY-MM-DD'), TO_DATE('2021-04-11','YYYY-MM-DD'), 3, 'ī��');
INSERT INTO ���೻�� VALUES('R2', 'A3-D', 'C3', TO_DATE('2021-04-13','YYYY-MM-DD'), TO_DATE('2021-04-15','YYYY-MM-DD'), 2, 'ī��');
INSERT INTO ���೻�� VALUES('R3', 'A3-D', 'C4', TO_DATE('2021-04-15','YYYY-MM-DD'), TO_DATE('2021-04-17','YYYY-MM-DD'), 4, '������ü');
INSERT INTO ���೻�� VALUES('R4', 'A1-S1', 'C1', TO_DATE('2021-04-05','YYYY-MM-DD'), TO_DATE('2021-04-06','YYYY-MM-DD'), 3, '�Ҿװ���');
INSERT INTO ���೻�� VALUES('R5', 'A6-S2', 'C1', TO_DATE('2021-03-10','YYYY-MM-DD'), TO_DATE('2021-03-11','YYYY-MM-DD'), 1, 'īī������');
INSERT INTO ���೻�� VALUES('R6', 'A4-D', 'C6', TO_DATE('2021-04-20','YYYY-MM-DD'), TO_DATE('2021-04-23','YYYY-MM-DD'), 5, '���̹�����');
INSERT INTO ���೻�� VALUES('R7', 'A9-S2', 'C7', TO_DATE('2021-03-15','YYYY-MM-DD'), TO_DATE('2021-03-17','YYYY-MM-DD'), 3, 'ī��');
INSERT INTO ���೻�� VALUES('R8', 'A10-S1', 'C8', TO_DATE('2021-03-30','YYYY-MM-DD'), TO_DATE('2021-04-01','YYYY-MM-DD'), 2, '������ü');
INSERT INTO ���೻�� VALUES('R9', 'A8-S2', 'C9', TO_DATE('2021-03-23','YYYY-MM-DD'), TO_DATE('2021-03-24','YYYY-MM-DD'), 2, 'ī��');
INSERT INTO ���೻�� VALUES('R10', 'A8-S2', 'C10', TO_DATE('2021-03-26','YYYY-MM-DD'), TO_DATE('2021-03-28','YYYY-MM-DD'), 4, 'ī��');

CREATE VIEW �ѻ��������
AS SELECT * FROM ����� NATURAL JOIN �����_����;

