select * from student;
select * from student where age=20;
select * from student where age>=20 and age<30;
select * from student order by age; --나이 오름차순
select * from student order by age desc; --나이 내림차순
--name의 맨 앞글자는 권이고, 그 뒤엔 뭐가 들어가도 상관없음
select * from student where name like '권%'; --성이 권씨인 사람들 출력
insert into student values('김태균',40,'12345');
select * from student where name like '%균';