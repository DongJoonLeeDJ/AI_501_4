SELECT * FROM my_web_dev_study.mvc_board;

-- 시퀀스 생성
-- 엄밀하게 따지면 sequences 테이블에 name값이 mvc_board이고, currval은 0인 데이터 하나를 추가(레코드 추가)
call create_sequence('mvc_board');

insert into mvc_board(bId, bName, bTitle, bContent, bHit, bGroup, bStep, bIndent) values 
(nextval('mvc_board'), 'name','title','contents',0, currval('mvc_board'),0,0);



