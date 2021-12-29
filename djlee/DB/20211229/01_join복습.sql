SELECT * FROM orders;
SELECT * FROM customer;
SELECT * FROM book;


-- unique 속성
-- primary key : unique + not null
-- 주민번호
-- unique : 겹치면 안 되는 데, null값은 ok
-- 전화번호

create table simple_address_book
(
   num int primary key, -- 고객번호, 겹치면 안됨(동명이인대비하기)
   name varchar2(30) not null, --이름이 없는 고객은 없다.
   phone_number varchar2(20) unique -- 전화번호가 없는 사람은 있다.
);

insert into simple_address_book values(1,'이동준',null); -- ok
insert into simple_address_book values(2,'권도균','010-xxxx-zzzz'); -- ok
insert into simple_address_book values(3,'이동준','010-2940-1613'); -- ok
insert into simple_address_book values(4,'이강호','010-2940-1613'); --fail(전화번호 중복)
insert into simple_address_book values(5,null,null);--이름이 없어서 fail
insert into simple_address_book values(6,null,'xxx-xxxx-xxxx'); --이름이 없어서 fail
select * from simple_address_book;

alter table book rename column booname to bookname;
select * from book;

select * from orders;
select * from book;

--주문번호, 책이름, 가격  -> 책 이름만 나옴
select orderid, book.bookname, orders.saleprice, orders.custid from 
orders join book on orders.bookid=book.bookid;

--주문번호, 고객명, saleprice, bookid -> 고객 이름만 나옴
select orderid, customer.name, saleprice, bookid from 
orders join customer on orders.custid=customer.custid;

-- 중첩질의를 이용해서 orders 테이블의 
-- 고객명과 책이름을 모두 출력하게 해보시오.



-- 중첩 질의 안 써도 됨
select orders.orderid , book.bookname ,orders.saleprice ,customer.name   
FROM  orders, book, customer  
where orders.custid = customer.custid and orders.bookid=book.bookid 
order by orderid;



-- 중첩 질의 써서 푸는 법 -> view랑 연관되기 때문
-- customer 테이블과 그리고 book과 orders를 join한 결과물을
-- 다시 서로 join한다.

select orderid, aa.bookname, customer.name, saleprice from 
(select orderid, book.bookname, orders.saleprice, orders.custid from 
orders join book on orders.bookid=book.bookid) aa join customer on 
aa.custid = customer.custid order by orderid;





-- book과 (orders와 customer)를 join한 테이블의 join
select orderid, aa.name, book.bookname, saleprice from 
(select orderid, customer.name, saleprice, bookid from 
orders join customer on orders.custid=customer.custid) aa join book on 
aa.bookid = book.bookid order by orderid;





