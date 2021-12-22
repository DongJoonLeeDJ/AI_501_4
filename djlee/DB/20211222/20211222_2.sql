insert into mytable values ('이동준',4);
insert into mytable values ('이동준',5);
insert into mytable values ('이동준',6);
insert into mytable values ('이동준',7);
insert into mytable values ('이동준',8);

select * from mytable;
commit;
rollback; -- 직전에 commit한 시점으로 돌아감

--자동으로 커밋해줌
set autocommit on;

--autocommit IMMEDIATE -> autocommit 상태
--autocommit off -> autocommit이 꺼진 상태
show autocommit;
set autocommit off;


