select * from student;
select * from student where age=20;
select * from student where age>=20 and age<30;
select * from student order by age; --���� ��������
select * from student order by age desc; --���� ��������
--name�� �� �ձ��ڴ� ���̰�, �� �ڿ� ���� ���� �������
select * from student where name like '��%'; --���� �Ǿ��� ����� ���
insert into student values('���±�',40,'12345');
select * from student where name like '%��';