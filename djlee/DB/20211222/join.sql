-- 학생테이블에 학과정보 저장할 수 있는 컬럼을 추가

alter table student add (hakgwa varchar2(20));

select * from student;
insert into student values ('이동준',23,'99911','전자공학');
insert into student values ('이제영',24,'22211','아동가족학');
select * from student;


alter table student rename to mystudent;


SELECT * FROM STUDENT;
select * from hakgwa;
--학과 테이블을 먼저 채워야지만 학생들을 등록할 수 있다.
insert into hakgwa values('001', '컴공');
insert into hakgwa values('002', '전자공학');
insert into hakgwa values('003', '심리학');
insert into hakgwa values('004', '아동가족학');
insert into hakgwa values('005', '경제통상');
insert into hakgwa (name,code) values('도박학과','777');
insert into hakgwa (name,code) values('아마게돈과','666');

-- dual은 아무의미없는 테이블 (dummy 테이블)
-- lengthb 바이트 크기 체크
select * from dual;
select lengthb('장') from dual; --바이트크기 체크
select lengthb('a') from dual;
select lengthb('1') from dual;
select length('장') from dual; --글자 길이 체크


insert into student values ('12345', '류경문', '001');
insert into student values ('22222', '제임스본드', '007');
-- ORA-02291: 무결성 제약조건(C##SCOTT.STUDENT_FK1)이 위배되었습니다
-- 부모 키가 없습니다
-- 존재하지 않는 과를 입력하면 그 학생은 추가 자체가 안 됨.

insert into hakgwa values ('007','카지노로얄과');

select * from student;
insert into student values('11111', '권용규', '002');
insert into student values('88888', '이동준', '001');
insert into student values('43212', '이주민', '001');

--학생 5명
--학과 8개
-- 총 40개의 무의미한 데이터가 나옴
select * from student,hakgwa; --아무의미없는코드!!!
select * from student s, hakgwa h where s.hakgwa_code=h.code;
select hakbeon, s.name, h.name from student s, hakgwa h where s.hakgwa_code=h.code;

--위의 코드랑 똑같다. 위의 코드는 student는 s로  치환하고, hakgwa는 h로 치환한 게 전부다.
select * from student, hakgwa where student.hakgwa_code=hakgwa.code;
select hakbeon, student.name, hakgwa.name 
from student, hakgwa where student.hakgwa_code=hakgwa.code;


-- 002~005, 666, 777 학생 추가 전에...
-- 또다른 조인 방법(ANSI 표준)
-- ANSI SQL = 미국 표준 협회에서 표준화한 SQL문
-- inner join 혹은 join
-- 양쪽 테이블에서 매칭이 되는 것만 나타냄
-- 즉 003 심리학과 처럼... 소속된 학생이 없는 과는 안 나타남
select * from student join hakgwa on student.hakgwa_code = hakgwa.code;
select * from student inner join hakgwa on student.hakgwa_code = hakgwa.code;

-- left join
--"지금 이 student와 hakgwa"를 이용해서는 확실히 나타낼 수 없다.
-- 왜냐면... hakgwa테이블 안에 없는 값을 student에서는 만들 수 없다. 즉, 존재하지 않는 과를 가지고
-- 학생 만드는 게 불가능
-- 굳이 나타내고 싶다면 hakgwa와 student의 위치를 서로 바꾸며 된다.
-- 왼쪽 테이블에 있는 건 전부 다 나타내기
select * from student left join hakgwa on student.hakgwa_code = hakgwa.code;
-- right join
-- 오른쪽 테이블에 있는 것만 전부 다 나타냄
select * from student right join hakgwa on student.hakgwa_code = hakgwa.code;

-- outer join
-- Full join, mysql에서는 별도의 구현이 필요한 것
-- left join과 right join을 합친 것
-- left에서만 나타나는 것들, right에서만 나타나는 것들도 모두 다 출력해주는 것
select * from student full join hakgwa on student.hakgwa_code = hakgwa.code;


-- self join
-- 직접 실습해볼 것








