--1. Employee ���̺� ����
--���, �̸�, ����, ���� 
--(�ڷ���, ����, pk �˾Ƽ� ����)
create table Employee(
 sabeon number primary key, --pk: primary key, �⺻Ű, ����� �ֹι�ȣó�� �� ��ü�� �����ϰ� ���� ��
 name varchar2(20) not null, --�ѱ� �� 6����, ������� 20����. ������ �� ��
 age int,
 JikGeup varchar2(30) --�ѱ۷� 10���ڱ���, ������ڴ� 30����
);

--2. �ּ� 5�� �̻��� ������ �Է��ϱ�
insert into Employee values(2009038033, 'lee', 33, 'senior');

--���� �÷��� ������ �𸣰ų�, �÷��� ������ ������ְ� ���� ���
--�÷�=column=��
insert into Employee (sabeon, name, age, JikGeup) 
values (2021000111, 'park', 19, 'manager');

--�Ϻ� ���� ���� �� ���� ���
insert into Employee (sabeon, name) values ('2021000122','kim');

select * from Employee;

update Employee set age=77, JikGeup='beginner' where sabeon='2021000122';

insert into Employee values('2021000113', 'choi', 55, 'senior');
insert into Employee values('2021000114', 'Jang', 47, 'manager');
--insert into Employee values('2021000114', '�̵���', 33, 'ȸ���');

--����)     2009038033 'lee' 33 'senior'
--         2021000111 'park' 19 'manager'
--         2021000122 'kim' 77 'beginner'
--         2021000113 'choi' 55 'senior'
--         2021000114 'Jang' 47 'manager'
--
--3. ���̰� 30�� ������ ����� ������  'beginner'�� �����ϱ�
update Employee set jikgeup='beginner' where age<=30;
select * from Employee;
--4. ���̰� 50�� �̻��� ����� ������ 'manager'�� �����ϱ�
update Employee set jikgeup='manager' where age>=50;
select * from Employee;
--5. ���̰� 70�� �̻��� ����� �����ϱ�
delete from Employee where age>=70;
--6. ��� ��ȸ�غ���
select * from Employee;
--7. ������ senior�� ��� ��ȸ�غ���
select * from Employee where jikgeup = 'senior';

-- ���� �� ���� ����
select * from Employee order by age; --���� ����
select * from Employee order by age desc; --���� ����
-- Ư�� �÷��� ����
select sabeon, age from Employee;
-- Ư�� �÷��� �̸� ����(as Ű���� ���� ����)
select sabeon as "�����ȣ", age as "����" from Employee;

-- �̸� �ȿ� a ��� ���ڰ� �ִ� ����� ��ȸ�ϱ�
-- a�� �ձ��ڴ� �ϳ��� ���ų� 1���� �̻��̰�
-- a�� �ޱ��ڵ� �ϳ��� ���ų� 1���� �̻��̴�.
-- % : 0���� �̻�
select * from employee where name like '%a%';

commit;
--commit�� �ڵ������� �ϰ� �ϰ� ������
show autocommit; --���� commit�� �ڵ����� �Ǵ��� Ȯ���غ���
set autocommit on; --off��� �ش� �ڵ� �ۼ��ϱ�





