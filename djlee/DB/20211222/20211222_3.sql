-- drop �����϶�
drop table mytable;

create table student
(
   name varchar2(20),
   age int,
   hakbeon varchar2(20) primary key --�й��� 0���� �����ϰų� �����ڵ�� ȥ�յ� ��� ����ؼ� �׳� varchar2�� ������
);

insert into student values('�ǿ��',15,'20903');
insert into student values('���湮',25,'19703');
insert into student values('�ǽ¿�',35,'18809');
insert into student values('��ξ�',20,'22103');
insert into student values('�ǵ���',22,'21809');

select * from student;





create table teacher 
(
  name varchar2(20),
  age int,
  sabeon varchar2(20) primary key
);


insert into teacher values('�̳���',20,'2021090101');
insert into teacher values('�̵���',30,'2011080105');
insert into teacher values('��ȣ��',40,'2001030301');
insert into teacher values('�ڸ�ȸ',25,'2020101011');
insert into teacher values('��ȫ��',30,'1999030207');

select * from teacher;

delete from student where name='�ǿ��';
select * from student;

select * from teacher where name='�̳���';

select * from teacher where name='��ȣ��';

update teacher set age=25 where name='��ȣ��';
select * from teacher;
commit;
select * from teacher where sabeon='2011080105';
update teacher set name='���ֹ�';
rollback;
update teacher set name='���ֹ�' where sabeon ='2011080105';
select * from teacher;
select * from student;
commit;





