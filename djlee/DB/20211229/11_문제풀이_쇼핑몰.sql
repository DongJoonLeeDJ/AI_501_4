--usertbl2, buytbl2, univ_student2, univ_major2

create table usertbl2
(
  userid char(8) primary key,
  username varchar2(10) not null
);

insert into userTbl2 values('KHD', '강호동');
insert into userTbl2 values('KJD', '김제동');
insert into userTbl2 values('KKJ', '김국진');
insert into userTbl2 values('KYM', '김용만');
insert into userTbl2 values('LHJ', '이휘재');
insert into userTbl2 values('LKK', '이경규');
insert into userTbl2 values('NHS', '남희석');
insert into userTbl2 values('PSH', '박수홍');
insert into userTbl2 values('SDY', '신동엽');
insert into userTbl2 values('YJS', '유재석');

select * from usertbl2;
drop sequence tblseq2;
create sequence tblseq2 increment by 1 maxvalue 100 minvalue 1 cycle nocache;

create table buytbl2
(
  num int primary key,
  userid char(8),
  prodName varchar2(50) not null,
  price int not null,
  amout int not null
);
--제약조건 추가(=외래키추가)
--userid간의 연결
alter table buytbl2 add CONSTRAINT fk_buy2 FOREIGN key (userid) REFERENCES usertbl2(userid);

INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '운동화', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '노트북', 1000, 1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KYM', '모니터', 200,  1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '모니터', 200,  5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '청바지', 50,   3);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '메모리', 80,  10);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KJD', '책'   , 15,   5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '책'   , 15,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '청바지', 50,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '운동화', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '책'   , 15,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '운동화', 30,   2);

select * from usertbl2;
select * from buytbl2;

--컬럼명 오타있었음...

--1번 문제
alter table buytbl2 rename column amout to amount;
select username, prodname, price, amount, (price*amount) as 총가격 from buytbl2 join usertbl2 
on buytbl2.userid=usertbl2.userid;

--컬럼명 오타나서 바꿈
alter table buytbl2 rename column amout to amount;

--2번 문제
-- 사람별 총구매액(=group by 필요) 표시
select username, sum(price*amount) as 총가격 from buytbl2 join usertbl2 
on buytbl2.userid=usertbl2.userid group by username;

--3번문제
-- 사람별 총구매액(=group by 필요)이 1000원이 넘는 경우
select username, sum(price*amount) as 총가격 from buytbl2 join usertbl2 
on buytbl2.userid=usertbl2.userid group by username having sum(price*amount)>1000;

--4. 총 구매액이 가장 높은 사람과 낮은 사람의 이름과 가격을 같이 
--출력하시오.
-- max 출력
select max(mg) from (select u.username, sum(b.price*b.amount) mg
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username) A;

-- min 출력
select min(mg) maxmax from (select u.username unn, sum(b.price*b.amount) mg
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username) B;

-- 4번 코드 정답 뷰 안 쓴 거
select u.username as 사용자명, sum(b.price*b.amount) as 총가격
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username 
having  sum(b.price*b.amount)=  (select max(mg) from (select u.username, sum(b.price*b.amount) mg
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username) A) or sum(b.price*b.amount) = (select min(mg) maxmax from (select u.username unn, sum(b.price*b.amount) mg
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username) B);

-- view 사용해서 좀 쉽게해보자!

create view MY_SUM_Groupby_user2 as 
select u.username, sum(b.price*b.amount) mg
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username;

select * from MY_SUM_Groupby_user2;

create view MY_MAX_FROM_SUM2 as
select max(mg) as maxmg from MY_SUM_Groupby_user2;

create view MY_MIN_FROM_SUM2 as
select min(mg) as minmg from MY_SUM_Groupby_user2;

select * from MY_MAX_FROM_SUM2;
select * from MY_MIN_FROM_SUM2;

-- 4번코드 정답(뷰 쓴 거)
select u.username as 사용자명, sum(b.price*b.amount) as 총가격
from buytbl2 b join usertbl2 u on b.userID = u.userId group by u.username 
having sum(b.price*b.amount)=(select * from my_min_from_sum2) or sum(b.price*b.amount)=(select * from my_max_from_sum2);







