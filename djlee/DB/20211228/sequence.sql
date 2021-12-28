-- 데이터 삽입 전 혹은 테이블을 생성하기 전에!!!
-- 먼저 시퀀스를 만든다.
-- 시퀀스 : mysql의 ai(auto increment같이 자동증가하는 거)

--1부터 시작해서 100까지이며,
--100을 초과하면 다시 1로 돌아오는 시퀀스
create sequence myseq start with 1 increment by 1 maxvalue 100 
cycle nocache;

insert into simpletable values (myseq.nextval, '이동준');
insert into simpletable values (myseq.nextval, '권용규');
insert into simpletable values (myseq.nextval, '이원만');
select * from simpletable;

