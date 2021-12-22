-- drop 주의하라
drop table mytable;

create table student
(
   name varchar2(20),
   age int,
   hakbeon varchar2(20) primary key --학번이 0부터 시작하거나 영문자등과 혼합된 경우 대비해서 그냥 varchar2로 설정함
);

insert into student values('권용규',15,'20903');
insert into student values('류경문',25,'19703');
insert into student values('권승연',35,'18809');
insert into student values('김민아',20,'22103');
insert into student values('권도균',22,'21809');

select * from student;





create table teacher 
(
  name varchar2(20),
  age int,
  sabeon varchar2(20) primary key
);


insert into teacher values('이나겸',20,'2021090101');
insert into teacher values('이동준',30,'2011080105');
insert into teacher values('박호범',40,'2001030301');
insert into teacher values('박명회',25,'2020101011');
insert into teacher values('김홍근',30,'1999030207');

select * from teacher;

delete from student where name='권용규';
select * from student;

select * from teacher where name='이나겸';

select * from teacher where name='박호범';

update teacher set age=25 where name='박호범';
select * from teacher;
commit;
select * from teacher where sabeon='2011080105';
update teacher set name='이주민';
rollback;
update teacher set name='이주민' where sabeon ='2011080105';
select * from teacher;
select * from student;
commit;





