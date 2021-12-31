-- �л����̺��� �а����� ������ �� �ִ� �÷��� �߰�

alter table student add (hakgwa varchar2(20));

select * from student;
insert into student values ('�̵���',23,'99911','���ڰ���');
insert into student values ('������',24,'22211','�Ƶ�������');
select * from student;


alter table student rename to mystudent;


SELECT * FROM STUDENT;
select * from hakgwa;
--�а� ���̺��� ���� ä�������� �л����� ����� �� �ִ�.
insert into hakgwa values('001', '�İ�');
insert into hakgwa values('002', '���ڰ���');
insert into hakgwa values('003', '�ɸ���');
insert into hakgwa values('004', '�Ƶ�������');
insert into hakgwa values('005', '�������');
insert into hakgwa (name,code) values('�����а�','777');
insert into hakgwa (name,code) values('�Ƹ��Ե���','666');

-- dual�� �ƹ��ǹ̾��� ���̺� (dummy ���̺�)
-- lengthb ����Ʈ ũ�� üũ
select * from dual;
select lengthb('��') from dual; --����Ʈũ�� üũ
select lengthb('a') from dual;
select lengthb('1') from dual;
select length('��') from dual; --���� ���� üũ


insert into student values ('12345', '���湮', '001');
insert into student values ('22222', '���ӽ�����', '007');
-- ORA-02291: ���Ἲ ��������(C##SCOTT.STUDENT_FK1)�� ����Ǿ����ϴ�
-- �θ� Ű�� �����ϴ�
-- �������� �ʴ� ���� �Է��ϸ� �� �л��� �߰� ��ü�� �� ��.

insert into hakgwa values ('007','ī����ξ��');

select * from student;
insert into student values('11111', '�ǿ��', '002');
insert into student values('88888', '�̵���', '001');
insert into student values('43212', '���ֹ�', '001');

--�л� 5��
--�а� 8��
-- �� 40���� ���ǹ��� �����Ͱ� ����
select * from student,hakgwa; --�ƹ��ǹ̾����ڵ�!!!
select * from student s, hakgwa h where s.hakgwa_code=h.code;
select hakbeon, s.name, h.name from student s, hakgwa h where s.hakgwa_code=h.code;

--���� �ڵ�� �Ȱ���. ���� �ڵ�� student�� s��  ġȯ�ϰ�, hakgwa�� h�� ġȯ�� �� ���δ�.
select * from student, hakgwa where student.hakgwa_code=hakgwa.code;
select hakbeon, student.name, hakgwa.name 
from student, hakgwa where student.hakgwa_code=hakgwa.code;


-- 002~005, 666, 777 �л� �߰� ����...
-- �Ǵٸ� ���� ���(ANSI ǥ��)
-- ANSI SQL = �̱� ǥ�� ��ȸ���� ǥ��ȭ�� SQL��
-- inner join Ȥ�� join
-- ���� ���̺����� ��Ī�� �Ǵ� �͸� ��Ÿ��
-- �� 003 �ɸ��а� ó��... �Ҽӵ� �л��� ���� ���� �� ��Ÿ��
select * from student join hakgwa on student.hakgwa_code = hakgwa.code;
select * from student inner join hakgwa on student.hakgwa_code = hakgwa.code;

-- left join
--"���� �� student�� hakgwa"�� �̿��ؼ��� Ȯ���� ��Ÿ�� �� ����.
-- �ֳĸ�... hakgwa���̺� �ȿ� ���� ���� student������ ���� �� ����. ��, �������� �ʴ� ���� ������
-- �л� ����� �� �Ұ���
-- ���� ��Ÿ���� �ʹٸ� hakgwa�� student�� ��ġ�� ���� �ٲٸ� �ȴ�.
-- ���� ���̺��� �ִ� �� ���� �� ��Ÿ����
select * from student left join hakgwa on student.hakgwa_code = hakgwa.code;
-- right join
-- ������ ���̺��� �ִ� �͸� ���� �� ��Ÿ��
select * from student right join hakgwa on student.hakgwa_code = hakgwa.code;

-- outer join
-- Full join, mysql������ ������ ������ �ʿ��� ��
-- left join�� right join�� ��ģ ��
-- left������ ��Ÿ���� �͵�, right������ ��Ÿ���� �͵鵵 ��� �� ������ִ� ��
select * from student full join hakgwa on student.hakgwa_code = hakgwa.code;


-- self join
-- ���� �ǽ��غ� ��







