insert into mytable values ('�̵���',4);
insert into mytable values ('�̵���',5);
insert into mytable values ('�̵���',6);
insert into mytable values ('�̵���',7);
insert into mytable values ('�̵���',8);

select * from mytable;
commit;
rollback; -- ������ commit�� �������� ���ư�

--�ڵ����� Ŀ������
set autocommit on;

--autocommit IMMEDIATE -> autocommit ����
--autocommit off -> autocommit�� ���� ����
show autocommit;
set autocommit off;


