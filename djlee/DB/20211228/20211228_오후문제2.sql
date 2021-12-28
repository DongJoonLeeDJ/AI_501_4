create table mykbmajor
(
    name varchar2(30) not null,
    code char(3) primary key,
    regDate timestamp default sysdate
);

insert into mykbmajor(name,code) values('정보기술개발','001');
select * from mykbmajor;

create table mykbstudent
(
    name varchar2(30),
    age int,
    hakbeon char(10),
    hakgwa_code char(3),
    regDate timestamp default sysdate
);
--실수로 테이블 만들 때 외래키 추가를 안 했다면!?
--alter table은 테이블을 수정할 때 주로 쓰이는 키워드
--제약조건명은 크게 중요하진 않으나 중복되면 안 됨
alter table mykbstudent add CONSTRAINT fk_mykbstu FOREIGN KEY(hakgwa_code) REFERENCES mykbmajor(code);

insert into mykbstudent (name,age,hakbeon,hakgwa_code) values ('이동준',33,'123A','001');
insert into mykbstudent (name,age,hakbeon,hakgwa_code) values ('이종준',33,'123B','555'); -- 학과테이블에 555가 없으니, 안 됨!


insert into mykbmajor (name, code) values ('전자과','002');

insert into mykbstudent (name,age,hakbeon,hakgwa_code) values ('이종준',33,'123B','002');
insert into mykbstudent (name,age,hakbeon,hakgwa_code) values ('이봉준',33,'123C','001'); 


/*
이동준 123A 정보기술개발
이종준 123B 전자과
이봉준 123C 정보기술개발
*/

-- mykbstudent -> a로 치환
-- mykbmajor -> b로 치환
select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code;

-- 정보기술개발 학생들은 나타나게 하기
select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code where b.code='001';
select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code where b.name='정보기술개발';










