--테이블 만들기 (테이블:우리가 통상적으로 말하는 데이터베이스)
-- ctrl+enter : 1줄 실행 
-- 여기서 말하는 한 줄은 세미콜론(;) 단위 
-- F5 : 이 스크립트 전체를 실행하는 것
create table mytable 
(
   name varchar2(20),
   id number(20) primary key
);
-- primary key = pk = 기본키
-- 주민번호처럼 절대 중복되지 않는 것
-- 조회
-- *(스타) : 모든 컬럼(열) 조회
select * from mytable;
-- 삽입
insert into mytable values ('권용규',1);
insert into mytable values ('류경문',1); -- 번호 중복되서 추가 안 됨
insert into mytable values ('이동준',2);
insert into mytable (id,name) values (3,'장상은');
-- 수정
update mytable set name='이원만' where id=2;
-- 삭제
--이름이 장상은인 데이터 다지움
delete from mytable where name='장상은'; 
delete from mytable where id='3';
-- delete from mytable where id=(select name from mytable where name='장상은');

-- commit이랑 rollback
show autocommit;

-- commit
-- git의 commit이랑 비슷하다
-- 저장
-- 제대로 commit을 안 하고 접속해제하거나 꺼버리면 
-- db에 저장이 안 됨.


