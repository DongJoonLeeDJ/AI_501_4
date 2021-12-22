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





