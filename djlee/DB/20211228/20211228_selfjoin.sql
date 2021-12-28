create table samsung
(
    id int primary key,
    name varchar2(30),
    boss_id int
);
delete from samsung;
insert into samsung values (1,'이건희',1);
insert into samsung values (2,'홍라희',2);
insert into samsung values (3,'이부진',1);
insert into samsung values (4,'이재용',1);
insert into samsung values (5,'신라호텔',3);
insert into samsung values (6,'삼성전자',4);
insert into samsung values (7,'수원삼성',4);
insert into samsung values (8,'삼성라이온즈',4);
select * from samsung;



