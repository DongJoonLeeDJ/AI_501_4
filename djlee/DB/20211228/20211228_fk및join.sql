create table song (
    id int primary key,
    title varchar2(40) not null,
    price int
);

create table singer (
    id int primary key,
    name varchar2(30),
    hit_song_id int,
    FOREIGN key(hit_song_id) references song(id) --외래키 추가
);

-- 노래부터 집어넣어야 한다.
insert into song values(1, '롤린', 10000);
insert into song values(2, 'Gee', 9000);
insert into song values(3, 'Next Level', 8000);
select * from song;

--가수부터 넣을 순 있는 데 hitsong값을 null로 지정해야 함
insert into singer values(1,'브레이브걸스',null);
insert into singer values(2,'new브레이브걸스',1);
insert into singer values(3,'소녀시대',2);
insert into singer values(4,'이동준',null);
select * from singer;


-- join
-- ANSI SQL(표준 스타일)

-- 우리가 아는 일반적 조인(inner join)
select name, title from singer join song on singer.hit_song_id = song.id;
-- 히트송이 존재하는 가수만 출력함
-- 이동준이나 브레이브걸스는 출력 안 됨
-- next level도 해당 노래를 부른 가수가 없어서 출력이 안 됨
-- 교집합 형태

-- left join
select name, title from singer left join song on singer.hit_song_id = song.id;
-- 이동준이나 브레이브걸스처럼 히트송이 없는 가수들도 출력이 됨(singer에 있는 거 다 출력) 
select name, title from singer right join song on singer.hit_song_id = song.id;
-- Next Level처럼 가수가 없는 노래도 다 출력됨. 즉 song에 있는 게 다 출력됨
select name, title from singer full join song on singer.hit_song_id = song.id;
-- full join(=outer join) -> left join과 right join 합친 것
-- 즉 히트송없는 가수나 가수 없는 노래들 모두 다 출력해줌










