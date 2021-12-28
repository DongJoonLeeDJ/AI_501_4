select * from book order by publisher;

--출판사별 가격
select sum(price), publisher from book group by publisher;
--출판사당 책의 수
--count(*) : group by로 나눴을 때 같은 그룹으로 묶이는 것의 개수
-- 예: 굿스포츠 그룹은 3개이므로 3이 나온다.
select count(publisher), publisher from book group by publisher order by count(*) desc;

--책들의 가격 총합
select sum(price) 총가격 from book;


-- 책이 2권 이상인 출판사만 출력
select publisher from book group by publisher having count(*)>1;

select * from book;

-- 가장 비싼 가격은?
select max(price) from book;

-- 가장 비싼 책은?
-- 이럴 때 활용하는 것이 바로 중첩질의!
select * from book where price = (select max(price) from book);
select * from book where price = (select min(price) from book);








