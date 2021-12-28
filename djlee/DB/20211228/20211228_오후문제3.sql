create table Book
(
   bookid int primary key,
   booname varchar2(40),
   publisher varchar2(40),
   price int
);

create table Customer 
(
  custid int primary key,
  name varchar2(40),
  address varchar2(50),
  phone varchar2(20)
);

insert into book values(1,'축구의 역사','굿스포츠',7000);
insert into book values(2,'축구아는 여자','나무수',13000);
insert into book values(3,'축구의 이해','대한미디어',22000);
insert into book values(4,'골프 바이블','대한미디어',35000);
insert into book values(5,'피겨 교본','굿스포츠',8000);
insert into book values(6,'역도 단계별기술','굿스포츠',6000);
insert into book values(7,'야구의 추억','이상미디어',20000);
insert into book values(8,'야구를 부탁해','이상미디어',13000);
insert into book values(9,'올림픽 이야기','삼성당',7500);
insert into book values(10,'Olympic Champions','Pearson',13000);
select * from book;

--(참고) unique라는 속성을 쓰면 중복이 안 되게 할 수 있음
-- 지금은 안 했는 데... 핸드폰번호같은 경우엔 중복이 안 되게 할 수 있음
-- pk랑 다른 점은 uq는 null값을 허용함
-- pk = not null + unique
insert into customer values(1,'박지성','영국 멘체스타', '000-5000-0001');
insert into customer values(2,'김연아','대한민국 서울', '000-6000-0001');
insert into customer values(3,'장미란','대한민국 강원도', '000-7000-0001');
insert into customer values(4,'추신수','미국 클리블랜드', '000-8000-0001');
insert into customer values(5,'박세리','대한민국 대전', null);

create table Orders
(
   orderid int primary key,
   custid int,
   bookid int,
   saleprice int,
   orderdate date default sysdate,
   foreign key (custid) REFERENCES customer(custid),
   foreign key (bookid) REFERENCES book(bookid)
);

--주문번호 1번. 1번 고객이 1번책을 샀다.
insert into Orders(orderid,custid,bookid) values(1,1,1);
select * from ORders;

insert into Orders(orderid,custid,bookid) values(2,1,3); --1번 고객 3번책 구매
insert into Orders(orderid,custid,bookid) values(3,2,5); --2번 고객 5번책 구매
insert into Orders(orderid,custid,bookid) values(4,3,6); --3번 고객 6번책 구매
insert into Orders(orderid,custid,bookid) values(5,4,7); --4번 고객 7번책 구매
insert into Orders(orderid,custid,bookid) values(6,1,2); --1번 고객 2번책 구매
insert into Orders(orderid,custid,bookid) values(7,4,8); --4번 고객 8번책 구매
insert into Orders(orderid,custid,bookid) values(8,3,10); --3번 고객 10번책 구매
insert into Orders(orderid,custid,bookid) values(9,2,10); --2번 고객 10번책 구매
insert into Orders(orderid,custid,bookid) values(10,3,8); --3번 고객 8번책 구매
select * from Orders order by bookid; 
--Order테이블의 fk가 2개라는 것! 즉 bookid는 book에서 참고하고, custid는 customer에서 참고함!

-- 중첩 질의(=쿼리)
-- 쿼리문 안에 또 다른 쿼리문이 들어있는 것!
update Orders set saleprice = (select price from book where bookid=1) where bookid=1;
update Orders set saleprice = (select price from book where bookid=2) where bookid=2;
update Orders set saleprice = (select price from book where bookid=3) where bookid=3;
update Orders set saleprice = (select price from book where bookid=4) where bookid=4;
update Orders set saleprice = (select price from book where bookid=5) where bookid=5;
update Orders set saleprice = (select price from book where bookid=6) where bookid=6;
update Orders set saleprice = (select price from book where bookid=7) where bookid=7;
update Orders set saleprice = (select price from book where bookid=8) where bookid=8;
update Orders set saleprice = (select price from book where bookid=9) where bookid=9;
update Orders set saleprice = (select price from book where bookid=10) where bookid=10;







