-- view
-- 가상테이블
-- 실제 존재하는 건 아닌 데,
-- 복잡한 쿼리문에 들어갈 select 결과물을 미리 만들어 두기

create or replace view mytestview as 
select * from orders;
select * from mytestview; -- select * from orders라는 결과를 뷰로 만듦
--or replace는 생략 가능
--이걸 써주는 이유는 이름이 겹치는 view를 만들게 되면 새걸로 덮어쓰기 위함
-- 새걸로 덮어쓸 생각이 없다면 or replace 생략가능
create view expensive_book as 
select * from book where price>10000; -- book테이블에서 만원넘는 책들만 뷰로 만듦

select * from expensive_book; -- 10000원을 넘는 책만 출력됨


-- 만약 view 생성 안 되면 system 계정으로 접속해서
--아래 쿼리를 실행한다.
grant create view to c##scott;


select orderid, aa.bookname, customer.name, saleprice from 
aa join customer on 
aa.custid = customer.custid order by orderid;

create view aa as select orderid, book.bookname, orders.saleprice, orders.custid from 
orders join book on orders.bookid=book.bookid;
