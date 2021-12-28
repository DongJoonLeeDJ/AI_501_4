--1. Employee 테이블 생성
--사번, 이름, 나이, 직급 
--(자료형, 길이, pk 알아서 지정)
create table Employee(
 sabeon number primary key, --pk: primary key, 기본키, 사람의 주민번호처럼 각 개체가 유일하게 갖는 것
 name varchar2(20) not null, --한글 약 6글자, 영어숫자 20글자. 공백은 안 됨
 age int,
 JikGeup varchar2(30) --한글로 10글자까지, 영어숫자는 30글자
);

--2. 최소 5명 이상의 데이터 입력하기
insert into Employee values(2009038033, 'lee', 33, 'senior');

--내가 컬럼의 순서를 모르거나, 컬럼의 순서를 명시해주고 싶은 경우
--컬럼=column=열
insert into Employee (sabeon, name, age, JikGeup) 
values (2021000111, 'park', 19, 'manager');

--일부 값을 몰라서 못 적는 경우
insert into Employee (sabeon, name) values ('2021000122','kim');

select * from Employee;

update Employee set age=77, JikGeup='beginner' where sabeon='2021000122';

insert into Employee values('2021000113', 'choi', 55, 'senior');
insert into Employee values('2021000114', 'Jang', 47, 'manager');
--insert into Employee values('2021000114', '이동준', 33, '회장님');

--예시)     2009038033 'lee' 33 'senior'
--         2021000111 'park' 19 'manager'
--         2021000122 'kim' 77 'beginner'
--         2021000113 'choi' 55 'senior'
--         2021000114 'Jang' 47 'manager'
--
--3. 나이가 30살 이하인 사람의 직급을  'beginner'로 지정하기
update Employee set jikgeup='beginner' where age<=30;
select * from Employee;
--4. 나이가 50살 이상인 사람의 직급을 'manager'로 지정하기
update Employee set jikgeup='manager' where age>=50;
select * from Employee;
--5. 나이가 70살 이상인 사람은 삭제하기
delete from Employee where age>=70;
--6. 모두 조회해보기
select * from Employee;
--7. 직급이 senior인 사람 조회해보기
select * from Employee where jikgeup = 'senior';

-- 나이 순 정렬 가능
select * from Employee order by age; --오름 차순
select * from Employee order by age desc; --내림 차순
-- 특정 컬럼만 보기
select sabeon, age from Employee;
-- 특정 컬럼에 이름 지정(as 키워드 생략 가능)
select sabeon as "사원번호", age as "나이" from Employee;

-- 이름 안에 a 라는 글자가 있는 사람만 조회하기
-- a의 앞글자는 하나도 없거나 1글자 이상이고
-- a의 뒷글자도 하나도 없거나 1글자 이상이다.
-- % : 0글자 이상
select * from employee where name like '%a%';

commit;
--commit을 자동적으로 하게 하고 싶으면
show autocommit; --현재 commit이 자동으로 되는지 확인해보고
set autocommit on; --off라면 해당 코드 작성하기





