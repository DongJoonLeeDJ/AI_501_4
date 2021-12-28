create table song (
    id int primary key,
    title varchar2(40) not null,
    price int
);

create table singer (
    id int primary key,
    name varchar2(30),
    hit_song_id int,
    FOREIGN key(hit_song_id) references song(id) --�ܷ�Ű �߰�
);

-- �뷡���� ����־�� �Ѵ�.
insert into song values(1, '�Ѹ�', 10000);
insert into song values(2, 'Gee', 9000);
insert into song values(3, 'Next Level', 8000);
select * from song;

--�������� ���� �� �ִ� �� hitsong���� null�� �����ؾ� ��
insert into singer values(1,'�극�̺�ɽ�',null);
insert into singer values(2,'new�극�̺�ɽ�',1);
insert into singer values(3,'�ҳ�ô�',2);
insert into singer values(4,'�̵���',null);
select * from singer;


-- join
-- ANSI SQL(ǥ�� ��Ÿ��)

-- �츮�� �ƴ� �Ϲ��� ����(inner join)
select name, title from singer join song on singer.hit_song_id = song.id;
-- ��Ʈ���� �����ϴ� ������ �����
-- �̵����̳� �극�̺�ɽ��� ��� �� ��
-- next level�� �ش� �뷡�� �θ� ������ ��� ����� �� ��
-- ������ ����

-- left join
select name, title from singer left join song on singer.hit_song_id = song.id;
-- �̵����̳� �극�̺�ɽ�ó�� ��Ʈ���� ���� �����鵵 ����� ��(singer�� �ִ� �� �� ���) 
select name, title from singer right join song on singer.hit_song_id = song.id;
-- Next Leveló�� ������ ���� �뷡�� �� ��µ�. �� song�� �ִ� �� �� ��µ�
select name, title from singer full join song on singer.hit_song_id = song.id;
-- full join(=outer join) -> left join�� right join ��ģ ��
-- �� ��Ʈ�۾��� ������ ���� ���� �뷡�� ��� �� �������










