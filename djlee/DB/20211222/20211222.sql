--���̺� ����� (���̺�:�츮�� ��������� ���ϴ� �����ͺ��̽�)
-- ctrl+enter : 1�� ���� 
-- ���⼭ ���ϴ� �� ���� �����ݷ�(;) ���� 
-- F5 : �� ��ũ��Ʈ ��ü�� �����ϴ� ��
create table mytable 
(
   name varchar2(20),
   id number(20) primary key
);
-- primary key = pk = �⺻Ű
-- �ֹι�ȣó�� ���� �ߺ����� �ʴ� ��
-- ��ȸ
-- *(��Ÿ) : ��� �÷�(��) ��ȸ
select * from mytable;
-- ����
insert into mytable values ('�ǿ��',1);
insert into mytable values ('���湮',1); -- ��ȣ �ߺ��Ǽ� �߰� �� ��
insert into mytable values ('�̵���',2);
insert into mytable (id,name) values (3,'�����');
-- ����
update mytable set name='�̿���' where id=2;
-- ����
--�̸��� ������� ������ ������
delete from mytable where name='�����'; 
delete from mytable where id='3';
-- delete from mytable where id=(select name from mytable where name='�����');

-- commit�̶� rollback
show autocommit;

-- commit
-- git�� commit�̶� ����ϴ�
-- ����
-- ����� commit�� �� �ϰ� ���������ϰų� �������� 
-- db�� ������ �� ��.


